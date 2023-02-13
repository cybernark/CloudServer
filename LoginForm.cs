using CloudServer.Classes;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudServer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            DB dB = new DB();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (IsUserExists())
                return;

            DB db = new DB();
            db.openConnection();

            var querySelectUser = $"SELECT * FROM users WHERE login = '{Login.Text}' AND pass = '{Password.Text}'";
            var queryGetId = $"select id from users where login = '{Login.Text}'";
            var commandGetId = new MySqlCommand(querySelectUser, db.getConnection());

            MySqlDataReader reader= commandGetId.ExecuteReader();
            while (reader.Read())
            {
                DataStorage.idClient = reader[0].ToString();
            }
            reader.Close();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand(querySelectUser, db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                YUCloud yUCloud = new YUCloud();
                yUCloud.Show();
            }

            else
                MessageBox.Show("Имя пользователя или пароль не верны.");
            db.closeConnection();
        }

        public Boolean IsUserExists()
        {
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
            else
                return false;
        }

        private void Registerlabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void CloseAPPbtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                LoginButton_Click(LoginButton, null);
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Login.Select();
            Password.UseSystemPasswordChar = true;
        }

        private void CheckPass_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (CheckPass.Checked == true) 
            {
                Password.UseSystemPasswordChar = false;
                iconEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }

            else
            {
                Password.UseSystemPasswordChar = true;
                iconEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }    
        }
    }
}
