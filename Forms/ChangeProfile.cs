using CloudServer.Classes;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudServer.Forms
{
    public partial class ChangeProfile : Form
    {
        

        public ChangeProfile()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void ChangeProfile_MouseDown(object sender, MouseEventArgs e)

        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Дата сохранения";
            
            DB dB = new DB();
            dB.openConnection();
            if (!Regex.IsMatch(EmailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Пожалуйста, введите E-mail", caption, btn, ico);
                EmailTextBox.Select();
                return;
            }

            var email = EmailTextBox.Text;
            var changeMailQuery = $"update users set email = '{email}' where id = '{DataStorage.idClient}'";
            var command = new MySqlCommand(changeMailQuery, dB.getConnection());
            
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("E-mail успешно изменен.");
                Close();
            }
            else
            {
                MessageBox.Show("Error!");
            }
            dB.closeConnection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeProfile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnChange_Click(btnChange, null);
            }
        }
    }
}
