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
    public partial class formUProfile : MetroFramework.Forms.MetroForm
    {
        public formUProfile()
        {
            InitializeComponent();
            lblerror.Visible = false;
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

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            panel1.Width = 1830;
            sidebar.Height = 1500;
            panel7.Width = 1751;
            panel7.Height = 1500;
            pnlHeading.Width = 850;
            pnlEdit.Width = 400;
            pnlEdit.Height = 740;
            pnlEdit.Location = new System.Drawing.Point(380, 100);
            lblHeading.Location = new System.Drawing.Point(330, 30);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pass_Change(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxNPass.Text) || string.IsNullOrEmpty(txtENPass.Text))
            {
                lblerror.Visible = false;
            }
            else if (txtBoxNPass.Text != txtENPass.Text)
            {
                lblerror.Visible = true;
            }

            else
            {
                lblerror.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtBoxPhone.Text;
            string address = txtBoxAddress.Text;
            string cpass = txtBoxNPass.Text;
            string pass = txtENPass.Text;
            string email = "";

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Enter your name");
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtBoxPhone.Text) || txtBoxPhone.Text.Length!=11)
            {
                MessageBox.Show("Enter a valid phone number");
                txtBoxPhone.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Enter your password");
                txtBoxNPass.Focus();
                return;
            }

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Enter your address");
                txtBoxAddress.Focus();
                return;
            }

            if (pass == cpass)
            {
                string query = "update UserInfo set [Name] ='"+name+"', PhoneNo='"+phone+"', [Password] ='"+pass+"', [Address] = '"+address+"' where Id ='"+login.ID+"';";
                string error;
                //MessageBox.Show("update UserInfo set [Name] ='" + name + "', PhoneNo='" + phone + "', [Password] ='" + pass + "', [Address] = '" + address + "' where Id ='" + login.ID + "';");
                DataAccess.ExecuteData(query, out error);
                {
                    if (string.IsNullOrEmpty(error) == false)
                    {
                        MessageBox.Show("update failed");
                        return;
                    }
                    MessageBox.Show("Successfully updated!");

                    this.Hide();
                    BackupHomePage hp = new BackupHomePage();
                    hp.Show();
                }
            }
            else
            {
                MessageBox.Show("Your password and confirm password does not matched. Please try again");
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            this.Show();
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnTogglePass_Click(object sender, EventArgs e)
        {
            if (txtBoxNPass.PasswordChar == '#')
            {
                txtBoxNPass.PasswordChar = '\0';
                btnTogglePass.Image = Skyline.Properties.Resources.invisible;
            }

            else
            {
                txtBoxNPass.PasswordChar = '#';
                btnTogglePass.Image = Skyline.Properties.Resources.eye;
            }
        }

        private void btnToggleCP_Click(object sender, EventArgs e)
        {
            if (txtENPass.PasswordChar == '#')
            {
                txtENPass.PasswordChar = '\0';
                btnToggleCP.Image = Skyline.Properties.Resources.invisible;
            }

            else
            {
                txtENPass.PasswordChar = '#';
                btnToggleCP.Image = Skyline.Properties.Resources.eye;
            }
        }
    }
}

