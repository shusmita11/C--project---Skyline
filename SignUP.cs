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
    public partial class formSignUP : MetroFramework.Forms.MetroForm
    {
        public formSignUP()
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
        /// //////////////// SIDE BAR /////////////////////////

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
            if(string.IsNullOrEmpty(txtBoxPass.Text) || string.IsNullOrEmpty(txtBoxCP.Text))
            {
                lblerror.Visible = false;
            }
            else if(txtBoxPass.Text != txtBoxCP.Text)
            {
                lblerror.Visible = true;
            }

            else
            {
                lblerror.Visible = false;
            }
        }

        private void bthConfirm_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            string email = txtBoxEmail.Text;
            string phone = txtBoxPhone.Text;
            string pass = txtBoxPass.Text;
            string Cpass = txtBoxCP.Text;
            string address = txtBoxAddress.Text;

   
            string queryStore = "select * from UserInfo where Email ='" + email + "'";
            //MessageBox.Show(query);
            string errorStore;
            DataTable dt = DataAccess.GetData(queryStore, out errorStore);
            if (string.IsNullOrEmpty(errorStore) == false)
            {
                MessageBox.Show("error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Invalid Email or Password");
                return;
            }

            string gender = "";
            if (rbtnFemale.Checked == true)
            {
                gender = "Female";
            }

            else if(rbtnMale.Checked == true)
            {
                gender = "Male";
            }

            else if(rbtnOthers.Checked == true)
            {
                gender = "Others";
            }

            else
            {
                MessageBox.Show("Select a gender");
                return;
            }

            if(string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Enter your name");
                txtBoxName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Enter your email");
                txtBoxEmail.Focus();
                return;
            }


            if (string.IsNullOrEmpty(phone) || phone.Length!=11)
            {
                MessageBox.Show("Enter a valid phone number");
                txtBoxPhone.Focus();
                return;
            }


            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Enter your password");
                txtBoxPass.Focus();
                return;
            }


            if (string.IsNullOrEmpty(Cpass))
            {
                MessageBox.Show("please confirm your password");
                txtBoxCP.Focus();
                return;
            }

            if(string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Enter your address");
                txtBoxAddress.Focus();
            }

            if(pass==Cpass)
            {
                string query = "insert into UserInfo ([Name], Email, PhoneNo, [Password], [Address], UserTypeID, Gender) output Inserted.Id values ('" + name + "', '" + email + "', '" + phone + "', '" + pass + "','" + address + "',3, '" + gender + "' ) ";
                string error;
                DataAccess.ExecuteData(query, out error);
                

                if (string.IsNullOrEmpty(error)==false)
                    {
                        MessageBox.Show("registration failed");
                        return;
                    }
                    MessageBox.Show("Successfully registered!");
    

                
                
//////////////////////////////////////////////////////////////////////////////////
                string subject = "Registered in Skyline";
                    string body = "Congratulations! you've successfully registered in skyline. Buy your favourite shoes and bags right now!";

                    //my info
                    string MyEmail = "skyline0Company@gmail.com";
                    string MyPass = "SHUSMITAdristiAysha";


                    ////back to home page

                    this.Hide();
                    login log = new login();
                    log.Show();
      /////////////////////////////////////////////////////////////////////////////          
            }
            else
            {
                MessageBox.Show("Your password and confirm password does not matched. Please try again");
                return;
            }

        }

        private void btnTogglePass_Click(object sender, EventArgs e)
        {
            if(txtBoxPass.PasswordChar == '#')
            {
                txtBoxPass.PasswordChar = '\0';
                btnTogglePass.Image = Skyline.Properties.Resources.invisible;
            }

            else
            {
                txtBoxPass.PasswordChar = '#';
                btnTogglePass.Image = Skyline.Properties.Resources.eye;
            }
        }

        private void btnToggleCP_Click(object sender, EventArgs e)
        {
            if(txtBoxCP.PasswordChar == '#')
            {
                txtBoxCP.PasswordChar = '\0';
                btnToggleCP.Image = Skyline.Properties.Resources.invisible;
            }

            else
            {
                txtBoxCP.PasswordChar = '#';
                btnToggleCP.Image = Skyline.Properties.Resources.eye;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            BackupHomePage hp = new BackupHomePage();
            hp.Show();
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
