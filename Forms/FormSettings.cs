using MySqlConnector;
using CloudServer.Forms;
using CloudServer.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace CloudServer.Forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void RefreshData()
        {
            DB dB = new DB();
            dB.openConnection();
            var query = $"select email, login, phone_number from users where id = '{DataStorage.idClient}'";
            MySqlCommand command = new MySqlCommand(query, dB.getConnection());
            
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                DBemailLabel.Text += reader[0].ToString();
                DBloginLabel.Text += reader[1].ToString();
                DBphone_numberLabel.Text += reader[2].ToString();
            }
            reader.Close();
            dB.closeConnection();
        }

        private void ClearFields()
        {
            DBemailLabel.Text = string.Empty;
            DBloginLabel.Text = string.Empty;
            DBphone_numberLabel.Text = string.Empty;
        }

        private void LoadTheme()
        {
            ClearFields();
            RefreshData();
        }

        private void ChangeProfilebtn_Click(object sender, EventArgs e)
        {
            ChangeProfile changeprofile = new ChangeProfile();
            changeprofile.Show();
        }

        private void ChangeNumberLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePhoneNumber changePhoneNumber = new ChangePhoneNumber();
            changePhoneNumber.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearFields();
            RefreshData();
        }
    }
}
