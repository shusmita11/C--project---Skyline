using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skyline_mark0;

namespace Skyline
{
    public partial class login : MetroFramework.Forms.MetroForm
    {
        public static int ORDERID = 0;
        public static string EMAIL, PASSWORD, USERTYPE, ID;
        public login()
        {
            InitializeComponent();
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
                if (sidebar.Width <= 70)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            BackupHomePage hp = new BackupHomePage();
            hp.Show();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
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
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
                btnTogglePass.Image = Skyline.Properties.Resources.invisible;
            }

            else
            {
                txtPass.PasswordChar = '*';
                btnTogglePass.Image = Skyline.Properties.Resources.eye;
            }
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            EMAIL = txtEmail.Text;
            PASSWORD = txtPass.Text;
            string query = "select * from UserInfo where Email ='"+EMAIL+"' and Password ='"+ PASSWORD +"'";
            //MessageBox.Show(query);
            string error;
            DataTable dt = DataAccess.GetData(query, out error);
            if(string.IsNullOrEmpty(error)==false)
            {
               MessageBox.Show("error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Email or Password");
                return;
            }
            ID = dt.Rows[0]["Id"].ToString();
            USERTYPE = dt.Rows[0]["UserTypeID"].ToString();

            ///////////////// ORDER Table Insertion
            query = "Insert into [Order] (CustomerID, [Date]) output inserted.Id values ('" + ID + "', '" + DateTime.Now + "')";
            dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ORDERID = Convert.ToInt32(dt.Rows[0]["Id"]);
           
            this.Hide();

            //MessageBox.Show(ID + EMAIL + PASSWORD);
             

            if (USERTYPE == "3")
            {
                BackupHomePage hp = new BackupHomePage();
                hp.Show();
            }
            else if(USERTYPE == "2")
            {
                EmployeeView ev = new EmployeeView();
                ev.Show();
            }
            else
            {
                form mngr = new form();
                mngr.Show();
            }
            
        }

        private void btnSIgnUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSignUP signUp = new formSignUP();
            signUp.Show();
        }

        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            EMAIL = txtEmail.Text;
            this.Hide();
            ForgetPass fp = new ForgetPass();
            fp.Show();
        }

        /// //////////////// SIDE BAR /////////////////////////

    }
}
