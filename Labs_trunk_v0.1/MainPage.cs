using System;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace Labs_trunk_v0._1
{
    public partial class MainPage : Form
    {
        SqlConnection sqlConnection;

        public MainPage(Guid Id)
        {
            InitializeComponent();
            this.UserId = Id;
        }

        Guid UserId;
        Guid AdminId = new Guid("7f3b869f-34f3-4f20-ab4d-7480a5fdf647");
        string UserLogin;
        string SecurityCurrentUserPassword;
        bool UserActive;
        bool UserRulesPass;
        bool UpdateUserPass;
       string connectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Lab_DB.mdf;Integrated Security=True");


        private async void MainPage_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_DBDataSet.SysAdminUnit". При необходимости она может быть перемещена или удалена.
            this.sysAdminUnitTableAdapter.Fill(this.lab_DBDataSet.SysAdminUnit);

            if (UserId != AdminId) { tabControl1.TabPages.Remove(tabPage2); }

            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlCommand command = new SqlCommand("SELECT * FROM SysAdminUnit WHERE Id = '"
                    + UserId + "'", sqlConnection);

            SqlDataReader sqlReader = null;
            try
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlReader = await command.ExecuteReaderAsync();
                    while (await sqlReader.ReadAsync())
                    {
                        UserLogin = UserName.Text = sqlReader["Loggin"].ToString();
                        SecurityCurrentUserPassword = sqlReader["UserPassword"].ToString();
                        UserActive = Convert.ToBoolean(sqlReader["Active"]);
                        UserRulesPass = Convert.ToBoolean(sqlReader["RulesPass"]);
                        UpdateUserPass = Convert.ToBoolean(sqlReader["UpdatePassword"]);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Erorr", "Error");
            }
            finally {
                if (sqlReader != null)
                    sqlReader.Close();
            }
            if (UpdateUserPass) {
                MessageBox.Show("Вам необходимо изменить пароль!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE [SysUserSession] SET [SessionEndDate]=@SessionEndDate, [Active] = 0 WHERE [UserId]=@Id " +
            "AND SessionEndDate IS NULL", sqlConnection);

            command.Parameters.AddWithValue("Id", UserId);
            command.Parameters.AddWithValue("SessionEndDate", DateTime.Now);
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                await command.ExecuteNonQueryAsync();
            
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();

            Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sysAdminUnitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sysAdminUnitBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab_DBDataSet);

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (SecurityCurrentUserPassword == SecurityHash(UserName.Text, OldPasswordBox.Text))
                {
                    if (UserRulesPass)
                    {
                        var input = NewPasswordBox.Text;
                        var hasNumber = new Regex(@"[0-9]");
                        var hasChar = new Regex(@"[a-zA-Zа-яА-я]");
                        var hasSymbols = new Regex(@"[^0-9a-zA-Z_]");

                        if (!hasNumber.IsMatch(input))
                        {
                            MessageBox.Show("Пароль должен иметь цифры и буквы",
                                   "Изменение пароля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!hasChar.IsMatch(input))
                        {
                            MessageBox.Show("Пароль должен иметь цифры и буквы",
                                   "Изменение пароля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!hasSymbols.IsMatch(input))
                        {
                            MessageBox.Show("Пароль должен иметь цифры и буквы",
                                   "Изменение пароля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (NewPasswordBox.Text == NewPassVerificationBox.Text)
                            {
                                SqlCommand command = new SqlCommand("UPDATE [SysAdminUnit] SET [UserPassword]=@NewUserPassword, [UpdatePassword] = @UpdatePassword WHERE [Id]=@Id", sqlConnection);

                                command.Parameters.AddWithValue("Id", UserId);
                                command.Parameters.AddWithValue("NewUserPassword", SecurityHash(UserLogin, NewPasswordBox.Text));
                                command.Parameters.AddWithValue("UpdatePassword", false);

                                await command.ExecuteNonQueryAsync();
                                MessageBox.Show("Пароль успешно изменен.",
                               "Изменение пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else MessageBox.Show("Введенные пароли не совпадают!",
                                "Ошибка при изменении пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else {
                        if (NewPasswordBox.Text == NewPassVerificationBox.Text)
                        {
                            SqlCommand command = new SqlCommand("UPDATE [SysAdminUnit] SET [UserPassword]=@NewUserPassword WHERE [Id]=@Id", sqlConnection);

                            command.Parameters.AddWithValue("Id", UserId);
                            command.Parameters.AddWithValue("NewUserPassword", SecurityHash(UserLogin, NewPasswordBox.Text));

                            await command.ExecuteNonQueryAsync();
                            MessageBox.Show("Пароль успешно изменен.",
                           "Изменение пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Введенные пароли не совпадают!",
                            "Ошибка при изменении пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Вы ввели некорректный пароль!",
                        "Ошибка при изменении пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Erorr", "Error");
            }
        }
        private string SecurityHash(string login, string password)
        {
            byte[] HashValue;
            string Messagestring = login + password;

            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] messagebyte = UE.GetBytes(Messagestring);
            MD5 SHhash = new MD5CryptoServiceProvider();
            HashValue = SHhash.ComputeHash(messagebyte);

            string HashValueResult = "";
            foreach (byte b in HashValue)
            {
                HashValueResult += string.Format("{0:x3}", b);
            }
            return HashValueResult;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заричный Антон, ФБ-63.\nЗадание:\nНаличие букв, цифр и разделительных знаков.",
                       "Информация о програме", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void AddNewUser_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT Loggin FROM SysAdminUnit WHERE Loggin = '"
                    + NewUser.Text + "'", sqlConnection);
            try
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlReader = await command.ExecuteReaderAsync();

                    if (await sqlReader.ReadAsync())
                    {
                        MessageBox.Show("Пользователь с таким именем уже существует. Пожалуйста, введите уникальное имя пользователя!",
                           "Педупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (sqlReader != null)
                            sqlReader.Close();
                    }
                    else
                    {
                        if (sqlReader != null)
                            sqlReader.Close();
                        SqlCommand command1 = new SqlCommand("INSERT INTO [dbo].[SysAdminUnit] (Loggin, UserPassword) " +
                            "VALUES(@Loggin, @UserPassword)", sqlConnection);
                        command1.Parameters.AddWithValue("Loggin", NewUser.Text);
                        command1.Parameters.AddWithValue("UserPassword", SecurityHash(NewUser.Text, ""));
                        await command1.ExecuteNonQueryAsync();
                        MessageBox.Show("Новый пользователь успешно добавлен.",
                           "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateValueGridView();
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

        private void UpdateValueGridView()
        {
            sysAdminUnitDataGridView.DataSource = null;
            sysAdminUnitDataGridView.Rows.Clear();
            var select = "SELECT Id, Loggin, UserPassword, Active, RulesPass FROM dbo.SysAdminUnit";
            var c = new SqlConnection(connectionString);
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            sysAdminUnitDataGridView.ReadOnly = true;
            sysAdminUnitDataGridView.DataSource = ds.Tables[0];
        }

        private async void AddUserManagement_Click(object sender, EventArgs e)
        {
            if (UserNameManagement == null) {
                MessageBox.Show("Укажите имя пользователя",
                           "Имя пользователя пустое", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                sqlConnection = new SqlConnection(connectionString);
                await sqlConnection.OpenAsync();
                SqlCommand command = new SqlCommand("SELECT * FROM SysAdminUnit WHERE Loggin = '"
                        + UserNameManagement.Text + "'", sqlConnection);

                SqlDataReader sqlReader = null;
                try
                {
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        sqlReader = await command.ExecuteReaderAsync();

                        if (await sqlReader.ReadAsync())
                        {
                            if (sqlReader != null)
                                sqlReader.Close();
                            bool updatePass = false;
                            if (UsersRules.Checked)
                            {
                                updatePass = true;
                            }
                            SqlCommand command1 = new SqlCommand("UPDATE [SysAdminUnit] SET [Active]=@Active, [RulesPass] =@RulesPass, [UpdatePassword] = @UpdatePassword  WHERE [Loggin]=@Loggin", sqlConnection);

                            command1.Parameters.AddWithValue("Loggin", UserNameManagement.Text);
                            command1.Parameters.AddWithValue("Active", ActiveUser.Checked);
                            command1.Parameters.AddWithValue("RulesPass", UsersRules.Checked);
                            command1.Parameters.AddWithValue("UpdatePassword", updatePass);

                            await command1.ExecuteNonQueryAsync();
                            MessageBox.Show("Профиль указанного пользователя успешно изменен.",
                            "Изменение учетной записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        } else
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
                }
                UserNameManagement.Text = null;
                ActiveUser.Checked = false;
                UsersRules.Checked = false;
                UpdateValueGridView();
            }
        }
    }
 }
 