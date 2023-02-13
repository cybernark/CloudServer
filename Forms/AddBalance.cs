using MySqlConnector;
using CloudServer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace CloudServer.Forms
{
    public partial class AddBalance : Form
    {
        

        public AddBalance()
        {
            InitializeComponent();

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator= ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddPoundBtn_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.openConnection();
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Успех";

            MessageBoxIcon icoErr = MessageBoxIcon.Error;
            string captionErr = "Ошибка";

            if (DataCard())
                return;
            var Sum = SummTextBox.Text;
            var AddBalance = $"update users set balance = balance+'{Sum}' where id = '{DataStorage.idClient}'";
            var command = new MySqlCommand(AddBalance, dB.getConnection());
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Ваш баланс пополнен!", caption, btn, ico);
                Close();
            }

            else
            {
                MessageBox.Show("Ошибка", captionErr, btn, icoErr);
            }
            dB.closeConnection();
        }

        public Boolean DataCard()
        {
            if(SummTextBox.Text == "")
            {
                MessageBox.Show("Введите сумму пополнения");
                NumberTextBox.Select();
                return true;
            }
            if (NumberTextBox.Text == "")
            {
                MessageBox.Show("Введите номер карты");
                NumberTextBox.Select();
                return true;
            }
            else if (!Regex.IsMatch(NumberTextBox.Text, "^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14})$"))
            {
                MessageBox.Show("Введите действительный номер карты");
                NumberTextBox.Select();
                return true;
            }

            if (DateTextBox.Text == "")
            {
                MessageBox.Show("Введите срок действия карты");
                DateTextBox.Select();
                return true;
            }
            else if (!Regex.IsMatch(DateTextBox.Text, "^^(?:[1][0-2])\\/(?:[2-4][3-9])|(?:[0-1][1-2])\\/(?:[3-9][0-9])$"))
            {
                MessageBox.Show("Введите действующий срок действия карты");
                NumberTextBox.Select();
                return true;
            }

            if (CvvTextBox.Text == "")
            {
                MessageBox.Show("Введите CVV/CVC код");
                CvvTextBox.Select();
                return true;
            }
            else
                return false;
        }

        private void AddBalance_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SummTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void CvvTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void DateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        public string oldText = "";
        public string currText = "";
        private void DateTextBox_TextChanged(object sender, EventArgs e)
        {
            oldText = currText;
            currText = DateTextBox.Text;
            if (oldText.Length > currText.Length)
            {
                oldText = currText;
                return;
            }
            if (DateTextBox.Text.Length == currText.Length)
            {
                if (DateTextBox.SelectionStart == 2)
                {
                    DateTextBox.Text += "/";
                    DateTextBox.SelectionStart = DateTextBox.Text.Length;
                }
            }
        }
    }
}
