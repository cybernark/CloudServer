using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CloudServer
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }


        private void RegisterButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Успех";

            MessageBoxButtons btnErr = MessageBoxButtons.OK;
            MessageBoxIcon icoErr = MessageBoxIcon.Error;
            string captionErr = "Ошибка";

            if (IsUserExists())
                return;

            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `email`, `phone_number`) VALUES (@login, @pass, @email, @phone_number)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email.Text;
            command.Parameters.Add("@phone_number", MySqlDbType.VarChar).Value = PhoneNumber.Text;


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно зарегистрирован", caption, btn, ico);
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }

            else
            {
                MessageBox.Show("Аккаунт не был зарегестрирован", captionErr, btnErr, icoErr);
            }
            db.closeConnection();

        }
        public Boolean IsUserExists()
        {
            String loginUser = Login.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE login = @uL", db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = Login.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Exclamation;
            string caption = "Ошибка";

            if (Login.Text == "")
            {
                MessageBox.Show("Введите имя пользователя", caption, btn, ico);
                Login.Select();
                return true;
            }

            if (Password.Text == "")
            {
                MessageBox.Show("Введите пароль", caption, btn, ico);
                Password.Select();
                return true;
            }

            if (Password2.Text == "")
            {
                MessageBox.Show("Введите пароль повторно", caption, btn, ico);
                Password2.Select();
                return true;
            }

            if (Password.Text != Password2.Text)
            {
                MessageBox.Show("Ваш пароль и подтвержденный пароль не совпадают", caption, btn, ico);
                Password2.Select();
                return true;
            }

            if (!Regex.IsMatch(Email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Пожалуйста, введите E-mail", caption, btn, ico);
                Email.Select();
                return true;
            }

            if (!Regex.IsMatch(PhoneNumber.Text, "^[+][7][9][0-9]{7,12}$"))
            {
                MessageBox.Show("Пожалуйста, введите номер телефона", caption, btn, ico);
                PhoneNumber.Select();
                return true;
            }

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Этот пользователь уже зарегистрирован", caption, btn, ico);
                return true;
            }

            else
                return false;
        }

        private void Loginlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.Dispose();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RegisterForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter) 
            {
                RegisterButton_Click(RegisterButton, null);
            }
        }

        private void CloseAPPbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            Login.Select();
            Password.UseSystemPasswordChar = true;
            Password2.UseSystemPasswordChar = true;
        }

        private void CheckPass_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (CheckPass.Checked == true) 
            {
                Password.UseSystemPasswordChar = false;
                Password2.UseSystemPasswordChar = false;
                iconEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
                Password2.UseSystemPasswordChar = true;
                iconEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }
    }
}
