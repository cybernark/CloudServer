using CloudServer.Classes;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudServer.Forms
{
    public partial class FormVPS : Form
    {
        public FormVPS()
        {
            InitializeComponent();
            randText();
        }

        private void FormVPS_Load(object sender, EventArgs e)
        {
            Button_Disc_Click(Button_Disc, null);
            randText();
            clearfields();
            pricevalue_disc();
            pricevalue_2xRam();
            pricevalue_10gbps();
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

        private void pricevalue_disc()
        {
           DB db = new DB();
            db.openConnection();
            var RePriceval1 = $"select price from services where `services`.`service_name` = 'xeon discount'";  
            var pr1 = new MySqlCommand(RePriceval1, db.getConnection());   
            
            MySqlDataReader reader1 = pr1.ExecuteReader();
            while (reader1.Read())
            {
                xeon_disc_val.Text = reader1[0].ToString() + rub1lbl.Text;
            } 
            db.closeConnection();
        }

        private void pricevalue_2xRam()
        {
            DB dB = new DB();
            dB.openConnection();
            var RePriceval2 = $"select price from services where services.service_name = 'xeon 2x ram'";
            var pr2 = new MySqlCommand(RePriceval2, dB.getConnection());
            MySqlDataReader reader2 = pr2.ExecuteReader();
            while (reader2.Read())
            {
                xeon2xRam_val.Text = reader2[0].ToString() + rub2lbl.Text;
            }
            dB.closeConnection();
        }

        private void pricevalue_10gbps()
        {
            DB dB = new DB();
            dB.openConnection();
            var RePriceval3 = $"select price from services where services.service_name = 'xeon 10gbps'";
            var pr3 = new MySqlCommand(RePriceval3, dB.getConnection());
            MySqlDataReader reader3 = pr3.ExecuteReader();
            while (reader3.Read())
            {
                xeon10gbps_val.Text = reader3[0].ToString() + rub3lbl.Text;
            }
            dB.closeConnection();
        }

        private void clearfields()
        {
            xeon_disc_val.Text = string.Empty;
            xeon2xRam_val.Text = string.Empty;
            xeon10gbps_val.Text = string.Empty;
            rub1lbl.Visible = false;
            rub2lbl.Visible = false;
            rub2lbl.Visible = false;
            rub3lbl.Visible = false;
        }

        private void Button_Disc_Click(object sender, EventArgs e)
        {
            checkBox_Disc.Checked = true;
            checkBox_2xRam.Checked = false;
            checkBox_10gbps.Checked = false;
            CartLabel.Text = "2x Xeon-2678v3";
            FinishPrice();
        }

        private void Button_2xRam_Click(object sender, EventArgs e)
        {
            checkBox_2xRam.Checked = true;
            checkBox_Disc.Checked = false;
            checkBox_10gbps.Checked = false;
            CartLabel.Text = "2x Xeon-2678v3 2X RAM";
        }

        private void Button_10gbps_Click(object sender, EventArgs e)
        {
            checkBox_10gbps.Checked = true;
            checkBox_Disc.Checked = false;
            checkBox_2xRam.Checked = false;
            CartLabel.Text = "2x Xeon-2678v3 10 Gbps";
        }

        private void UbuntuButton_Click(object sender, EventArgs e)
        {
            checkBox_Ubuntu.Checked = true;
            checkBox_Debian.Checked = false;
            checkBox_CentOS.Checked = false;
            checkBox_Alma.Checked = false;
            checkBox_Rocky.Checked = false;
            checkBox_FreeBSD.Checked = false;
            checkBoxWinServer.Checked = false;
            checkBox_Win.Checked = false;
        }

        private void DebianButton_Click(object sender, EventArgs e)
        {
            checkBox_Debian.Checked = true;
            checkBox_Ubuntu.Checked = false;
            checkBox_CentOS.Checked = false;
            checkBox_Alma.Checked = false;
            checkBox_Rocky.Checked = false;
            checkBox_FreeBSD.Checked = false;
            checkBoxWinServer.Checked = false;
            checkBox_Win.Checked = false;
        }

        private void CentOSButton_Click(object sender, EventArgs e)
        {
            checkBox_CentOS.Checked = true;
            checkBox_Ubuntu.Checked = false;
            checkBox_Debian.Checked = false;
            checkBox_Alma.Checked = false;
            checkBox_Rocky.Checked = false;
            checkBox_FreeBSD.Checked = false;
            checkBoxWinServer.Checked = false;
            checkBox_Win.Checked = false;
        }

        private void AlmaButton_Click(object sender, EventArgs e)
        {
            checkBox_Alma.Checked = true;
            checkBox_Ubuntu.Checked = false;
            checkBox_Debian.Checked = false;
            checkBox_CentOS.Checked = false;
            checkBox_Rocky.Checked = false;
            checkBox_FreeBSD.Checked = false;
            checkBoxWinServer.Checked = false;
            checkBox_Win.Checked = false;
        }

        private void RockyButton_Click(object sender, EventArgs e)
        {
            checkBox_Rocky.Checked = true;
            checkBox_Ubuntu.Checked = false;
            checkBox_Debian.Checked = false;
            checkBox_CentOS.Checked = false;
            checkBox_Alma.Checked = false;
            checkBox_FreeBSD.Checked = false;
            checkBoxWinServer.Checked = false;
            checkBox_Win.Checked = false;
        }

        private void FreeBSDButton_Click(object sender, EventArgs e)
        {
            checkBox_FreeBSD.Checked = true;
            checkBox_Ubuntu.Checked = false;
            checkBox_Debian.Checked = false;
            checkBox_CentOS.Checked = false;
            checkBox_Alma.Checked = false;
            checkBox_Rocky.Checked = false;
            checkBoxWinServer.Checked = false;
            checkBox_Win.Checked = false;
        }

        private void WindowsServButton_Click(object sender, EventArgs e)
        {
            checkBoxWinServer.Checked = true;
            checkBox_Ubuntu.Checked = false;
            checkBox_Debian.Checked = false;
            checkBox_CentOS.Checked = false;
            checkBox_Alma.Checked = false;
            checkBox_Rocky.Checked = false;
            checkBox_FreeBSD.Checked = false;
            checkBox_Win.Checked = false;
        }

        private void WindowsButton_Click(object sender, EventArgs e)
        {
            checkBox_Win.Checked = true;
            checkBox_Ubuntu.Checked = false;
            checkBox_Debian.Checked = false;
            checkBox_CentOS.Checked = false;
            checkBox_Alma.Checked = false;
            checkBox_Rocky.Checked = false;
            checkBox_FreeBSD.Checked = false;
            checkBoxWinServer.Checked = false;
        }

        private void MonthButton_Click(object sender, EventArgs e)
        {
            checkBox_Month.Checked = true;
        }
        
        

        private void FinishPrice()
        {
            MessageBoxIcon ico = MessageBoxIcon.Question;
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            string caption = "Подтверждение оплаты";
            int disc_val = Convert.ToInt32(xeon_disc_val.Text);
            int ValueCart = Convert.ToInt32(ValueCartTextBox.Text);
            int Price = Convert.ToInt32(PriceLabel.Text);
            if (Price == disc_val * ValueCart)
            {
                MessageBox.Show("Вы уверены ?", caption, btn, ico);
            }
        }
    }
}
