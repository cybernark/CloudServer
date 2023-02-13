using CloudServer.Classes;
using CloudServer.Forms;
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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup.Localizer;

namespace CloudServer
{
    public partial class YUCloud : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public YUCloud()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
                index = random.Next(ThemeColor.ColorList.Count);
            {
                random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Montserrat SemiBold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    panelLogo.BackColor = Color.FromArgb(60, 16, 83);
                    panelTitleBar.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(60, 16, 83);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender); activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        

        private void Balance ()
        {
            DB dB = new DB();
            dB.openConnection();
            var balance = $"select balance from users where id = '{DataStorage.idClient}'";
            MySqlCommand Bal = new MySqlCommand(balance, dB.getConnection());
            
            MySqlDataReader reader= Bal.ExecuteReader();
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

        private void YUCloud_Load(object sender, EventArgs e)
        {
            ClearFields();
            Balance();
        }

        private void bttnVirtualServer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormVDS(), sender);
        }

        private void bttnServer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormVPS(), sender);
        }

        private void bttnServices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormServices(), sender);
        }

        private void bttnFinance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFinance(), sender);
        }

        private void bttnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSettings(), sender);
        }

        private void btthSupport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSupport(), sender);
        }

        private void CloseAPPbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximazebtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "ГЛАВНАЯ";
            panelTitleBar.BackColor = Color.FromArgb(60, 16, 83);
            panelLogo.BackColor = Color.FromArgb(60, 16, 83);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void OrderVdsButton_Click(object sender, EventArgs e)
        {
            bttnVirtualServer_Click(bttnVirtualServer, null);
        }

        private void OrderVpsButton_Click(object sender, EventArgs e)
        {
            bttnServer_Click(bttnServer, null);
        }
    }
}
