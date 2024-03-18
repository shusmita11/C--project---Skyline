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
    public partial class BackupHomePage : MetroFramework.Forms.MetroForm
    {
        public static int CID;
        private Guna.UI2.WinForms.Guna2TileButton btnName = new Guna.UI2.WinForms.Guna2TileButton();
        public BackupHomePage()
        {
            InitializeComponent();
            CatagoryLayout(null, null);
            UC_Shoe uc_shoe = new UC_Shoe();
            addUserControl(uc_shoe);
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

        /// //////////////// SIDE BAR /////////////////////////
        private void CatagoryLayout(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ProductCategory";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Connection Problem");
                return;
            }
            int CategoryCnt = dt.Rows.Count;
            tloCatagory.ColumnCount = CategoryCnt;

            for (int i = 0; i < CategoryCnt; i++)
            {
                tloCatagory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (100 / CategoryCnt)));
                var name = CategoryTile("Category" + dt.Rows[i]["Id"], dt.Rows[i]["Title"]);
                this.tloCatagory.Controls.Add(name, i, 0);
            }
        }

        private Control CategoryTile(string btnName, object text)
        {
            this.btnName = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnName.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnName.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(139)))));
            this.btnName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnName.ForeColor = System.Drawing.Color.White;
            this.btnName.Name = btnName;
            this.btnName.TabIndex = 0;
            this.btnName.Text = text.ToString();
            this.btnName.Click += new EventHandler(Category_Click);
            return this.btnName;
        }

        public void Category_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TileButton btn = (Guna.UI2.WinForms.Guna2TileButton)sender;
            if(sender == null)
            {
                return;
            }

            var catID = btn.Name.Replace("Category", "");
            CID = Convert.ToInt32(catID);
            UC_Shoe.Category = CID;
            UC_Shoe.useless = 0;
            UC_Shoe.cnt_1 = 0;
            UC_Shoe.cnt_2 = 0;


            UC_Shoe uc = new UC_Shoe();
            //uc.Initially();
            uc.DoRefresh();
           
        }

        private void addUserControl(UserControl userControl)
        {
            if (userControl != null)
            {
                userControl.Dock = DockStyle.Fill;
                MainPnl.Controls.Clear();
                MainPnl.Controls.Add(userControl);
                userControl.BringToFront();
            }
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            this.Close();
            UC_Shoe uc = new UC_Shoe();
            uc.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnCross_Click(sender, e);
            StartingPage sp = new StartingPage();
            sp.Show();

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
            if (login.USERTYPE == "")
            {
                login log = new login();
                log.Show();
            }
            
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
            StartingPage sp = new StartingPage();
            sp.Show();
        }
    }
}
