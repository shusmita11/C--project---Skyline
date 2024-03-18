using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using Skyline_mark0;

namespace Skyline
{
    
    public partial class BuyNow : MetroFramework.Forms.MetroForm
    {
        public BuyNow()
        {

            InitializeComponent();
            CmbBoxData();
           
        }

        /// <summary>
        /// //////////////// SIDE BAR /////////////////////////
        /// </summary>
        bool sideBarExpand = false;
        static int i = 0;
        public static decimal AMOUNT = 0;
        static int PRODUCTID = 0;

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

        private void btnCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowItems(string x)
        {
            string query = "Select * from Products where Id = '"+x+"'";
            string error;
            int pID = Convert.ToInt32(x);

            var dt = DataAccess.GetData(query, out error);
            if(string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Something went wrong!");
            }

            

            lblNameValue.Text = dt.Rows[0]["Name"].ToString();
            lblBrandValue.Text = dt.Rows[0]["Brand"].ToString();
            lblSizeValue.Text = dt.Rows[0]["Size"].ToString();
            lblPriceValue.Text = dt.Rows[0]["Price"].ToString();
            PRODUCTID = Convert.ToInt32(dt.Rows[0]["Id"].ToString());

         if (dt.Rows[0]["Image"] != DBNull.Value)
                {
                    byte[] imageShow = (byte[])dt.Rows[0]["Image"];
                    pbImage.Image = showImage(imageShow);
                }
                else
                {
                    pbImage.Image = null;
                }
            
        }

        private Image showImage(byte[] imageShow)
        {
            if (imageShow != null)
            {
                MemoryStream store = new MemoryStream(imageShow);
                return Image.FromStream(store);
                //return picBimage.Image = img;
            }

            else
            {
                pbImage.Image = null;
                return null;
            }
        }

        private void CmbBoxData()
        {
            string query = "select * from PaymentMethod";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Something went Wrong!");
                return;
            }

            cmbMethod.DataSource = dt;
            cmbMethod.DisplayMember = "Type";
            cmbMethod.ValueMember = "Id";
        }

        private void btnRightArrow_Click(object sender, EventArgs e)
        {
            string query = "select * from OrderDetails where OrderID = '"+login.ORDERID+"'";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Something went Wrong!");
                return;
            }

            int length = dt.Rows.Count;

            lblTtlItemsValue.Text = length.ToString();
            lblAmountValue.Text = AMOUNT.ToString();
            lblTtlAmountValue.Text = (Convert.ToDouble(AMOUNT) + (Convert.ToDouble(AMOUNT) * 0.05)).ToString();
            if (i < length)
            {
                ShowItems(dt.Rows[i]["ProductID"].ToString());
                i++;
            }
            else
            {
                i = 0;
            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = "Delete TOP(1) from OrderDetails Where OrderID = '" + login.ORDERID + "' and ProductID = '"+PRODUCTID+"'";
            string error;
            DataAccess.ExecuteData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Something went Wrong!");
                return;
            }

            query = "Select Price from Products where Id = '"+PRODUCTID+"'";
            DataTable dt = DataAccess.GetData(query, out error);

            AMOUNT -= Convert.ToDecimal(dt.Rows[0]["Price"]);
        }

        public static void StoreAmount()
        {
            string query = "Insert into PaymentDetails (MethodID, TotalPrice) Values ('"+ cmbMethod.SelectedValue+"', '"+AMOUNT+"')";
            string error;

            DataAccess.ExecuteData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Something went Wrong!");
                return;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if(cmbMethod.SelectedValue.ToString() == "2")
            {
                this.Hide();
                formPayment pay = new formPayment();
                pay.Show();
            }
            else //Cash
            {
                MessageBox.Show("Purchase Confimed!");
                StoreAmount();
                login.ORDERID = 0;
                login.EMAIL = null;
                login.PASSWORD = null;
                login.USERTYPE = null;
                login.ID = null;
                BackupHomePage hp = new BackupHomePage();
                hp.Show();
            }
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

        /// //////////////// SIDE BAR /////////////////////////
    }
}
