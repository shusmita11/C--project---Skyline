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
    public partial class StartingPage : MetroFramework.Forms.MetroForm
    {
        public StartingPage()
        {
            InitializeComponent();
        }
           /// < summary >
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

        private void btnExplore_Click(object sender, EventArgs e)
        {
            this.Hide();
            BackupHomePage hp = new BackupHomePage();
            hp.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        /// //////////////// SIDE BAR /////////////////////////
    }
}
