using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Skyline_mark0;
namespace Skyline
{
    public partial class ForgetPass : MetroFramework.Forms.MetroForm
    {
        string to, from, pass, sub, body;
        int time = 0, sec = 0;
        long randVal;
        public ForgetPass()
        {
            InitializeComponent();
        }

        public void sendMail()
        {
            Random r = new Random();
            randVal = r.Next();

            from = "skyline0Company@gmail.com"; //our mail
            
            pass = "otpucqqwyprsmbir"; //pass
            sub = "Skyline verification code.";
            body = "Your Skyline Password reset code is : " + randVal;

            

            string query = "select Email from UserInfo where Email = '" + txtEmail.Text + "'";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
            if(string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Something went wrong!");
            }

            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Enter a registerd Email!");
                txtEmail.Focus();
                txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;

            }
            else
            {
                FTimer.Start();
                to = txtEmail.Text;
                lblMsg.Text += "\n" + to;
                MailMessage mailMsg = new MailMessage();
                mailMsg.To.Add(to);
                mailMsg.From = new MailAddress(from);
                mailMsg.Subject = sub;
                mailMsg.Body = body;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(mailMsg);
                    btnSend.Enabled = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }    


           
            
            
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

        private void FPTimer_Tick(object sender, EventArgs e)
        {
            time++;
            if(time % 60 == 0)
            {
                lblTimeValue.Text = sec.ToString();
                sec++;
            }
            if(sec == 60)
            {
                FTimer.Stop();
                MessageBox.Show("Time out!");
                this.Hide();
                login log = new login();
                log.Show();
                return;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(randVal.ToString() == txtVCODE.Text)
            {
                MessageBox.Show("Verified");
                pnlPass.Visible = true;
                pnl.Visible = false;
                FTimer.Stop();
            }
            else
            {
                MessageBox.Show("Code is incorrect");
            }
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            if(txtEmail.Text == "")
            {
                txtEmail.Focus();
                txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            }
            else
            {
                sendMail();
                
            }
        }

        private void lblResend_Click(object sender, EventArgs e)
        {
            sendMail();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(txtPass.Text == "")
            {
                txtPass.Focus();
                txtPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            }
            if (txtCpass.Text == "")
            {
                txtCpass.Focus();
                txtCpass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            }

            if(txtCpass.Text == txtPass.Text)
            {
                MessageBox.Show(login.ID);
                string query = "Update UserInfo set Password = '" + txtPass.Text + "' where Email = '" + to + "'";
                string error;

                DataAccess.ExecuteData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show("registration failed");
                    return;
                }
                this.Hide();
                BackupHomePage hp = new BackupHomePage();
                hp.Show();
            }
            else
            {
                MessageBox.Show("Password and confirm password does not matches");
                return;
            }
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            BackupHomePage hp = new BackupHomePage();
            hp.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTogglePass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '#')
            {
                txtPass.PasswordChar = '\0';
                btnTogglePass.Image = Skyline.Properties.Resources.invisible;
            }

            else
            {
                txtPass.PasswordChar = '#';
                btnTogglePass.Image = Skyline.Properties.Resources.eye;
            }
        }

        private void btnToggleCP_Click(object sender, EventArgs e)
        {
            if (txtCpass.PasswordChar == '#')
            {
                txtCpass.PasswordChar = '\0';
                btnToggleCP.Image = Skyline.Properties.Resources.invisible;
            }

            else
            {
                txtCpass.PasswordChar = '#';
                btnToggleCP.Image = Skyline.Properties.Resources.eye;
            }
        }

        private void lblerror_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }

        /// //////////////// SIDE BAR /////////////////////////
        /// 
        private void Pass_Change(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtCpass.Text))
            {
                lblerror.Visible = false;
            }
            else if (txtPass.Text != txtCpass.Text)
            {
                lblerror.Visible = true;
            }

            else
            {
                lblerror.Visible = false;
            }
        }
    }
}
