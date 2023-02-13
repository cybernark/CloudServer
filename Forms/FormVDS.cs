using System;
using CloudServer.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using MySqlConnector;

namespace CloudServer.Forms
{
    public partial class FormVDS : Form
    {
        public FormVDS()
        {
            InitializeComponent();
            randText();
        }

        public void randText()
        {
            Random rand = new Random();
            for (int i = hostname.randNames.Count; i > 0; i--)
            {
                int flag = rand.Next(hostname.randNames.Count);
                hostnameTextBox.Text = (hostname.randNames[flag]);
                hostnameTextBox.PlaceholderText = (hostname.randNames[flag]);
                hostname.randNames.RemoveAt(flag);
            }
        }

        private void EPs_1Btn_Click(object sender, EventArgs e)
        {
            WindowsServButton.Enabled = false;
            WindowsButton.Enabled = false;
            Windows_disLabel.Visible = true;
        }

        private void EPs_2Btn_Click(object sender, EventArgs e)
        {
            WindowsServButton.Enabled = true;
            WindowsButton.Enabled = true;
            Windows_disLabel.Visible = false;
        }

        private void EPs_3Btn_Click(object sender, EventArgs e)
        {
            WindowsServButton.Enabled = true;
            WindowsButton.Enabled = true;
            Windows_disLabel.Visible = false;
        }

        private void EPs_4Btn_Click(object sender, EventArgs e)
        {
            WindowsServButton.Enabled = true;
            WindowsButton.Enabled = true;
            Windows_disLabel.Visible = false;
        }

        private void EPs_5Btn_Click(object sender, EventArgs e)
        {
            WindowsServButton.Enabled = true;
            WindowsButton.Enabled = true;
            Windows_disLabel.Visible = false;
        }

        private void pricevalue_Eps_1()
        {
            DB db = new DB();
            db.openConnection();
            var RePriceval1 = $"select price from services where `services`.`service_name` = 'Eps_1'";
            var pr1 = new MySqlCommand(RePriceval1, db.getConnection());

            MySqlDataReader reader = pr1.ExecuteReader();
            while (reader.Read())
            {
                Eps_1Price.Text = reader[0].ToString() + Rub1_lbl.Text;
            }
            db.closeConnection();
        }

        private void pricevalue_Eps_2()
        {
            DB db = new DB();
            db.openConnection();
            var RePriceval2 = $"select price from services where `services`.`service_name` = 'Eps_2'";
            var pr1 = new MySqlCommand(RePriceval2, db.getConnection());

            MySqlDataReader reader = pr1.ExecuteReader();
            while (reader.Read())
            {
                Eps_2Price.Text = reader[0].ToString() + Rub2_lbl.Text;
            }
            db.closeConnection();
        }

        private void pricevalue_Eps_3()
        {
            DB db = new DB();
            db.openConnection();
            var RePriceval3 = $"select price from services where `services`.`service_name` = 'Eps_3'";
            var pr1 = new MySqlCommand(RePriceval3, db.getConnection());

            MySqlDataReader reader = pr1.ExecuteReader();
            while (reader.Read())
            {
                Eps_3Price.Text = reader[0].ToString() + Rub3_lbl.Text;
            }
            db.closeConnection();
        }

        private void pricevalue_Eps_4()
        {
            DB db = new DB();
            db.openConnection();
            var RePriceval4 = $"select price from services where `services`.`service_name` = 'Eps_4'";
            var pr1 = new MySqlCommand(RePriceval4, db.getConnection());

            MySqlDataReader reader = pr1.ExecuteReader();
            while (reader.Read())
            {
                Eps_4Price.Text = reader[0].ToString() + Rub4_lbl.Text;
            }
            db.closeConnection();
        }

        private void pricevalue_Eps_5()
        {
            DB db = new DB();
            db.openConnection();
            var RePriceval5 = $"select price from services where `services`.`service_name` = 'Eps_4'";
            var pr1 = new MySqlCommand(RePriceval5, db.getConnection());

            MySqlDataReader reader = pr1.ExecuteReader();
            while (reader.Read())
            {
                Eps_5Price.Text = reader[0].ToString() + Rub5_lbl.Text;
            }
            db.closeConnection();
        }

        private void clearfields()
        {
            Eps_1Price.Text = string.Empty;
            Eps_2Price.Text = string.Empty;
            Eps_3Price.Text = string.Empty;
            Eps_4Price.Text = string.Empty;
            Eps_5Price.Text = string.Empty;
            Rub1_lbl.Visible = false;
            Rub2_lbl.Visible = false;
            Rub3_lbl.Visible = false;
            Rub4_lbl.Visible = false;
            Rub5_lbl.Visible = false;
        }

        private void FormVDS_Load(object sender, EventArgs e)
        {
            clearfields();
            pricevalue_Eps_1();
            pricevalue_Eps_2();
            pricevalue_Eps_3();
            pricevalue_Eps_4();
            pricevalue_Eps_5();
        }
    }
}
