using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skyline;

namespace Skyline_mark0
{
    public partial class formPayment : MetroFramework.Forms.MetroForm
    {
        public formPayment()
        {
            InitializeComponent();
            lblAmount.Text = BuyNow.AMOUNT.ToString();
        }
        /// <summary>
        /// //////////////// SIDE BAR /////////////////////////
        /// </summary>
        bool sideBarExpand = false;
        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand == false)
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 180)
                {
                    sideBarExpand = true;
                    SideBarTimer.Stop();

                }
            }
            else
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 60)
                {
                    sideBarExpand = false;
                    SideBarTimer.Stop();
                }
            }
        }

        private void sidebar_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTogglePIN_Click(object sender, EventArgs e)
        {
            if (txtPIN.PasswordChar == '#')
            {
                txtPIN.PasswordChar = '\0';
                btnTogglePIN.Image = Skyline.Properties.Resources.invisible;
            }

            else
            {
                txtPIN.PasswordChar = '#';
                btnTogglePIN.Image = Skyline.Properties.Resources.eye;
            }
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyNow buy = new BuyNow();
            buy.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyNow buy = new BuyNow();
            buy.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtPIN.Text == "")
            {
                txtPIN.Focus();
                txtPIN.Style = MetroFramework.MetroColorStyle.Red;
            }
            if (txtOTP.Text == "")
            {
                txtOTP.Focus();
                txtOTP.Style = MetroFramework.MetroColorStyle.Red;
            }
            this.Hide();

            if(txtPhone.Text.Length==11)
            {
                MessageBox.Show("Payment Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuyNow.StoreAmount();
                login.ORDERID = 0;
                login.EMAIL = null;
                login.PASSWORD = null;
                login.USERTYPE = null;
                login.ID = null;
                BackupHomePage hp = new BackupHomePage();
                hp.Show();
            }

            else
            {
                MessageBox.Show("Enter a valid phone number");
                return;
            }
            
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            BackupHomePage hp = new BackupHomePage();
            hp.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            formUProfile ep = new formUProfile();
            ep.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.ORDERID = 0;
            login.EMAIL = null;
            login.PASSWORD = null;
            login.USERTYPE = null;
            login.ID = null;
            StartingPage hp = new StartingPage();
            hp.Show();
        }
    }
}
