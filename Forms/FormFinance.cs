using Bunifu.UI.WinForms;
using CloudServer.Classes;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudServer.Forms
{
    public partial class FormFinance : Form
    {
        public FormFinance()
        {
            InitializeComponent();
            Balance_btn.LinkColor = Color.Black;
        }

        private void Balance_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bunifuPages1.SetPage("tabPage1");
            Balance_btn.LinkColor = Color.Black;
            History_label.LinkColor= Color.Gainsboro;
        }

        private void History_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bunifuPages1.SetPage("tabPage2");
            History_label.LinkColor= Color.Black;
            Balance_btn.LinkColor= Color.Gainsboro;
        }

        

        private void Balance()
        {
            DB dB = new DB();
            dB.openConnection();
            var balance = $"select balance from users where id = '{DataStorage.idClient}'";
            MySqlCommand Bal = new MySqlCommand(balance, dB.getConnection());
            
            MySqlDataReader reader = Bal.ExecuteReader();
            while (reader.Read())
            {
                BalanceValueLabel.Text = reader[0].ToString() + RUBLabel.Text;
            }
            reader.Close();
            dB.closeConnection();
        }

        private void ClearFields()
        {
            BalanceValueLabel.Text = string.Empty;
            RUBLabel.Visible = false;
        }

        private void FormFinance_Load(object sender, EventArgs e)
        {
            ClearFields();
            Balance();
        }

        private void AddPoundsButton_Click(object sender, EventArgs e)
        {
            AddBalance addBalance = new AddBalance();
            addBalance.Show();
        }

        private void btnRefreshBalance_Click(object sender, EventArgs e)
        {
            ClearFields();
            Balance();
        }
    }
}
