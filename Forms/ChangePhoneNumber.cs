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
    public partial class ChangePhoneNumber : Form
    {
        

        public ChangePhoneNumber()
        {
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
            DB dB = new DB();
            dB.openConnection();
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Дата сохранения";

            if (!Regex.IsMatch(NumberTextBox.Text, "^[+][7][9][0-9]{7,12}$"))
            {
                MessageBox.Show("Пожалуйста, введите номер телефона", caption, btn, ico);
                NumberTextBox.Select();
                return;
            }

            var Num = NumberTextBox.Text;
            var changeNumQuery = $"update users set phone_number = '{Num}' where id = '{DataStorage.idClient}'";
            var command = new MySqlCommand(changeNumQuery, dB.getConnection());
            
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Номер телефона успешно изменен.");
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

        private void NumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnChange_Click(btnChange, null);
            }
        }
    }
}
