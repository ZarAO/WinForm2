namespace Labs_trunk_v0._1
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.NewPassVerificationBox = new System.Windows.Forms.TextBox();
            this.NewPasswordBox = new System.Windows.Forms.TextBox();
            this.OldPasswordBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AddNewUser = new System.Windows.Forms.Button();
            this.NewUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InfoNewUser = new System.Windows.Forms.Label();
            this.InfoUserManagement = new System.Windows.Forms.Label();
            this.UserManagement = new System.Windows.Forms.Label();
            this.sysAdminUnitDataGridView = new System.Windows.Forms.DataGridView();
            this.fKSysUserSeUserI25869641BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rulesPassDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sysAdminUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab_DBDataSet = new Labs_trunk_v0._1.Lab_DBDataSet();
            this.sysAdminUnitTableAdapter = new Labs_trunk_v0._1.Lab_DBDataSetTableAdapters.SysAdminUnitTableAdapter();
            this.tableAdapterManager = new Labs_trunk_v0._1.Lab_DBDataSetTableAdapters.TableAdapterManager();
            this.sysUserSessionTableAdapter = new Labs_trunk_v0._1.Lab_DBDataSetTableAdapters.SysUserSessionTableAdapter();
            this.UserNameManagement = new System.Windows.Forms.TextBox();
            this.ActiveUser = new System.Windows.Forms.CheckBox();
            this.UsersRules = new System.Windows.Forms.CheckBox();
            this.AddUserManagement = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sysAdminUnitDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSysUserSeUserI25869641BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysAdminUnitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(367, 448);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.NewPassVerificationBox);
            this.tabPage1.Controls.Add(this.NewPasswordBox);
            this.tabPage1.Controls.Add(this.OldPasswordBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.UserName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(359, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ваш профиль";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewPassVerificationBox
            // 
            this.NewPassVerificationBox.Location = new System.Drawing.Point(162, 181);
            this.NewPassVerificationBox.Name = "NewPassVerificationBox";
            this.NewPassVerificationBox.PasswordChar = '*';
            this.NewPassVerificationBox.Size = new System.Drawing.Size(123, 20);
            this.NewPassVerificationBox.TabIndex = 5;
            // 
            // NewPasswordBox
            // 
            this.NewPasswordBox.Location = new System.Drawing.Point(162, 139);
            this.NewPasswordBox.Name = "NewPasswordBox";
            this.NewPasswordBox.PasswordChar = '*';
            this.NewPasswordBox.Size = new System.Drawing.Size(123, 20);
            this.NewPasswordBox.TabIndex = 5;
            // 
            // OldPasswordBox
            // 
            this.OldPasswordBox.Location = new System.Drawing.Point(162, 100);
            this.OldPasswordBox.Name = "OldPasswordBox";
            this.OldPasswordBox.PasswordChar = '*';
            this.OldPasswordBox.Size = new System.Drawing.Size(123, 20);
            this.OldPasswordBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Подтвердите новый пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Новый пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Текущий пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Чтобы изменить свой пароль введите старый, затем \r\nдважды введите новый в соответ" +
    "ствии с требованиями к нему";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UserName.Font = new System.Drawing.Font("Stencil", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(8, 3);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(193, 40);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "UserName";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Controls.Add(this.sysAdminUnitDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(359, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Страница администратора";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 223);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AddNewUser);
            this.splitContainer1.Panel1.Controls.Add(this.NewUser);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.InfoNewUser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AddUserManagement);
            this.splitContainer1.Panel2.Controls.Add(this.UsersRules);
            this.splitContainer1.Panel2.Controls.Add(this.ActiveUser);
            this.splitContainer1.Panel2.Controls.Add(this.UserNameManagement);
            this.splitContainer1.Panel2.Controls.Add(this.InfoUserManagement);
            this.splitContainer1.Panel2.Controls.Add(this.UserManagement);
            this.splitContainer1.Size = new System.Drawing.Size(353, 196);
            this.splitContainer1.SplitterDistance = 117;
            this.splitContainer1.TabIndex = 1;
            // 
            // AddNewUser
            // 
            this.AddNewUser.Location = new System.Drawing.Point(25, 104);
            this.AddNewUser.Name = "AddNewUser";
            this.AddNewUser.Size = new System.Drawing.Size(75, 23);
            this.AddNewUser.TabIndex = 3;
            this.AddNewUser.Text = "Добавить";
            this.AddNewUser.UseVisualStyleBackColor = true;
            this.AddNewUser.Click += new System.EventHandler(this.AddNewUser_Click);
            // 
            // NewUser
            // 
            this.NewUser.Location = new System.Drawing.Point(11, 68);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(100, 20);
            this.NewUser.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Введите имя нового\r\n      пользователя";
            // 
            // InfoNewUser
            // 
            this.InfoNewUser.AutoSize = true;
            this.InfoNewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoNewUser.Location = new System.Drawing.Point(0, 0);
            this.InfoNewUser.Name = "InfoNewUser";
            this.InfoNewUser.Size = new System.Drawing.Size(111, 26);
            this.InfoNewUser.TabIndex = 0;
            this.InfoNewUser.Text = "Добавление нового \r\nпользователя\r\n";
            // 
            // InfoUserManagement
            // 
            this.InfoUserManagement.AutoSize = true;
            this.InfoUserManagement.Location = new System.Drawing.Point(19, 36);
            this.InfoUserManagement.Name = "InfoUserManagement";
            this.InfoUserManagement.Size = new System.Drawing.Size(192, 52);
            this.InfoUserManagement.TabIndex = 2;
            this.InfoUserManagement.Text = "     Введите имя существующего\r\n                  пользователя\r\nзатем измените па" +
    "раметры учетной\r\n                        записи";
            // 
            // UserManagement
            // 
            this.UserManagement.AutoSize = true;
            this.UserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserManagement.Location = new System.Drawing.Point(0, 0);
            this.UserManagement.Name = "UserManagement";
            this.UserManagement.Size = new System.Drawing.Size(160, 26);
            this.UserManagement.TabIndex = 1;
            this.UserManagement.Text = "Управление существующими \r\nпользователями\r\n";
            // 
            // sysAdminUnitDataGridView
            // 
            this.sysAdminUnitDataGridView.AllowUserToAddRows = false;
            this.sysAdminUnitDataGridView.AllowUserToDeleteRows = false;
            this.sysAdminUnitDataGridView.AutoGenerateColumns = false;
            this.sysAdminUnitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sysAdminUnitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logginDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.rulesPassDataGridViewCheckBoxColumn});
            this.sysAdminUnitDataGridView.DataSource = this.sysAdminUnitBindingSource;
            this.sysAdminUnitDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.sysAdminUnitDataGridView.Location = new System.Drawing.Point(3, 3);
            this.sysAdminUnitDataGridView.Name = "sysAdminUnitDataGridView";
            this.sysAdminUnitDataGridView.ReadOnly = true;
            this.sysAdminUnitDataGridView.Size = new System.Drawing.Size(353, 220);
            this.sysAdminUnitDataGridView.TabIndex = 0;
            // 
            // fKSysUserSeUserI25869641BindingSource
            // 
            this.fKSysUserSeUserI25869641BindingSource.DataMember = "FK__SysUserSe__UserI__25869641";
            this.fKSysUserSeUserI25869641BindingSource.DataSource = this.sysAdminUnitBindingSource;
            // 
            // logginDataGridViewTextBoxColumn
            // 
            this.logginDataGridViewTextBoxColumn.DataPropertyName = "Loggin";
            this.logginDataGridViewTextBoxColumn.HeaderText = "Loggin";
            this.logginDataGridViewTextBoxColumn.Name = "logginDataGridViewTextBoxColumn";
            this.logginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // rulesPassDataGridViewCheckBoxColumn
            // 
            this.rulesPassDataGridViewCheckBoxColumn.DataPropertyName = "RulesPass";
            this.rulesPassDataGridViewCheckBoxColumn.HeaderText = "RulesPass";
            this.rulesPassDataGridViewCheckBoxColumn.Name = "rulesPassDataGridViewCheckBoxColumn";
            this.rulesPassDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // sysAdminUnitBindingSource
            // 
            this.sysAdminUnitBindingSource.DataMember = "SysAdminUnit";
            this.sysAdminUnitBindingSource.DataSource = this.lab_DBDataSet;
            // 
            // lab_DBDataSet
            // 
            this.lab_DBDataSet.DataSetName = "Lab_DBDataSet";
            this.lab_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sysAdminUnitTableAdapter
            // 
            this.sysAdminUnitTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SysAdminUnitTableAdapter = this.sysAdminUnitTableAdapter;
            this.tableAdapterManager.SysUserSessionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Labs_trunk_v0._1.Lab_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sysUserSessionTableAdapter
            // 
            this.sysUserSessionTableAdapter.ClearBeforeFill = true;
            // 
            // UserNameManagement
            // 
            this.UserNameManagement.Location = new System.Drawing.Point(60, 91);
            this.UserNameManagement.Name = "UserNameManagement";
            this.UserNameManagement.Size = new System.Drawing.Size(100, 20);
            this.UserNameManagement.TabIndex = 3;
            // 
            // ActiveUser
            // 
            this.ActiveUser.AutoSize = true;
            this.ActiveUser.Location = new System.Drawing.Point(3, 129);
            this.ActiveUser.Name = "ActiveUser";
            this.ActiveUser.Size = new System.Drawing.Size(76, 17);
            this.ActiveUser.TabIndex = 4;
            this.ActiveUser.Text = "Активный";
            this.ActiveUser.UseVisualStyleBackColor = true;
            // 
            // UsersRules
            // 
            this.UsersRules.AutoSize = true;
            this.UsersRules.Location = new System.Drawing.Point(85, 116);
            this.UsersRules.Name = "UsersRules";
            this.UsersRules.Size = new System.Drawing.Size(132, 43);
            this.UsersRules.TabIndex = 4;
            this.UsersRules.Text = "  Дополнительные\r\nтребованя к паролю \r\n      пользователя";
            this.UsersRules.UseVisualStyleBackColor = true;
            // 
            // AddUserManagement
            // 
            this.AddUserManagement.Location = new System.Drawing.Point(71, 165);
            this.AddUserManagement.Name = "AddUserManagement";
            this.AddUserManagement.Size = new System.Drawing.Size(75, 23);
            this.AddUserManagement.TabIndex = 5;
            this.AddUserManagement.Text = "Изменить";
            this.AddUserManagement.UseVisualStyleBackColor = true;
            this.AddUserManagement.Click += new System.EventHandler(this.AddUserManagement_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(367, 472);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZARICHNYI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sysAdminUnitDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSysUserSeUserI25869641BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysAdminUnitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TabPage tabPage2;
        private Lab_DBDataSet lab_DBDataSet;
        private System.Windows.Forms.BindingSource sysAdminUnitBindingSource;
        private Lab_DBDataSetTableAdapters.SysAdminUnitTableAdapter sysAdminUnitTableAdapter;
        private Lab_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NewPassVerificationBox;
        private System.Windows.Forms.TextBox NewPasswordBox;
        private System.Windows.Forms.TextBox OldPasswordBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView sysAdminUnitDataGridView;
        private System.Windows.Forms.BindingSource fKSysUserSeUserI25869641BindingSource;
        private Lab_DBDataSetTableAdapters.SysUserSessionTableAdapter sysUserSessionTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button AddNewUser;
        private System.Windows.Forms.TextBox NewUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label InfoNewUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn logginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rulesPassDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label InfoUserManagement;
        private System.Windows.Forms.Label UserManagement;
        private System.Windows.Forms.CheckBox UsersRules;
        private System.Windows.Forms.CheckBox ActiveUser;
        private System.Windows.Forms.TextBox UserNameManagement;
        private System.Windows.Forms.Button AddUserManagement;
    }
}