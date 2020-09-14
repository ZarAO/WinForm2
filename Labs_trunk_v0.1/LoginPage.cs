using System;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Labs_trunk_v0._1
{
    public partial class LoginPage : Form
    {
        SqlConnection sqlConnection;
        public LoginPage()
        {
            InitializeComponent();
        }

        int loginAttempts = 3;

        private async void button1_Click(object sender, EventArgs e)
        {
            byte[] HashValue;
            string login = LoginBox.Text;
            string password = PasswordBox.Text;
            string Messagestring = login + password;

            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] messagebyte = UE.GetBytes(Messagestring);
            MD5 SHhash = new MD5CryptoServiceProvider();
            HashValue = SHhash.ComputeHash(messagebyte);

            string hash = "";
            foreach (byte b in HashValue)
            {
                hash += string.Format("{0:x3}", b);
            }

            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT Id, Loggin, UserPassword, Active FROM SysAdminUnit WHERE Loggin = '"
                    + LoginBox.Text + "'", sqlConnection);
            try
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlReader = await command.ExecuteReaderAsync();

                    if (await sqlReader.ReadAsync())
                    {
                        while (loginAttempts > 0)
                        {
                            if (sqlReader["Loggin"].ToString() == LoginBox.Text && sqlReader["UserPassword"].ToString() == hash)
                            {
                                if (Convert.ToBoolean(sqlReader["Active"]))
                                {
                                    Guid UserId = new Guid(sqlReader["Id"].ToString());

                                    if (sqlReader != null)
                                        sqlReader.Close();
                                    SqlCommand command1 = new SqlCommand("INSERT INTO [dbo].[SysUserSession] (Id, SessionStartDate, UserId, Active) " +
                                        "VALUES(@Id, @SessionStartDate, @UserId, @Active)", sqlConnection);
                                    command1.Parameters.AddWithValue("Id", Guid.NewGuid());
                                    command1.Parameters.AddWithValue("SessionStartDate", DateTime.Now);
                                    command1.Parameters.AddWithValue("UserId", UserId);
                                    command1.Parameters.AddWithValue("Active", true);
                                    await command1.ExecuteNonQueryAsync();

                                    this.Hide();
                                    MainPage f = new MainPage(UserId);
                                    f.Owner = this;
                                    f.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show(String.Format("Ваш акаунт неактивен. \nОбратитесь к администратору.", loginAttempts),
                                "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    if (sqlReader != null)
                                        sqlReader.Close();
                                    return;
                                }
                            }
                            else
                            {
                                --loginAttempts;
                                MessageBox.Show(String.Format("Вы ввели некорректный пароль!\nУ Вас остальнось {0} попыток.", loginAttempts),
                                    "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if (sqlReader != null)
                                        sqlReader.Close();
                                if (loginAttempts == 0)
                                    this.Close();
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователя с указанным именем не существует!\nПожалуйста, проверьте корректность введенных данных.",
                             "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (sqlReader != null)
                            sqlReader.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erorr", "Error");
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
        private async void LoginPage_Load(object sender, EventArgs e)
        {
            string connectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Lab_DB.mdf;Integrated Security=True");
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
        }
        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }
    }
}
