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
using System.Windows.Threading;

namespace Skyline
{
    public partial class UC_Shoe : UserControl
    {
        public static int Category = 1, useless = 0;
        public static int cnt_1 = 0, cnt_2;
        public static string ID_1, ID_2, PRICE_1, PRICE_2;

        private delegate void EmptyDelegate();
        public UC_Shoe()
        {
            InitializeComponent();
            Refresh();
            UC_Shoe_Load_1();
            UC_Shoe_Load_2();
        }

        private void UC_Show_BuyNow()
        {
            BackupHomePage hp = new BackupHomePage();
            hp.Hide();

            if (string.IsNullOrEmpty(login.USERTYPE))
            {
                login l = new login();
                l.Show();
            }
            else
            {
                BuyNow buy = new BuyNow();
                buy.Show();
            }    
        }

       


        public void UC_Shoe_Load_1()
        {
            
            string query = "select Products.Id, Products.Name, Products.Brand, Products.Size, Products.Price, Products.Image from PSubCategory inner join Products on Products.SCID = PSubCategory.Id where CategoryID = '" + Category+"'";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
            if(string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }
            int length = dt.Rows.Count / 2;

            if(dt.Rows.Count < 1)
            {
                return;
            }

            try
            {
                lblNameValue1.Text = dt.Rows[cnt_1]["Name"].ToString();
                lblBrandValue1.Text = dt.Rows[cnt_1]["Brand"].ToString();
                lblSizeValue1.Text = dt.Rows[cnt_1]["Size"].ToString();
                lblPriceValue1.Text = dt.Rows[cnt_1]["Price"].ToString();
                ID_1 = dt.Rows[cnt_1]["Id"].ToString();
                PRICE_1 = dt.Rows[cnt_1]["Price"].ToString();
                DoRefresh();

                if (dt.Rows[0]["Image"] != DBNull.Value)
                {
                    byte[] imageShow = (byte[])dt.Rows[cnt_1]["Image"];
                    pb1.Image = showImage(imageShow);
                }
                else
                {
                    pb1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cnt_1 = (cnt_1 + 1) % length;
            DoRefresh();
        }

        public void btnLeft_Click(object sender, EventArgs e)
        {
            UC_Shoe_Load_1();
        }

        public void btnRight_Click(object sender, EventArgs e)
        {
            UC_Shoe_Load_2();
        }

        private void btnBuyNow1_Click(object sender, EventArgs e)
        {
            UC_Show_BuyNow();
        }

        public void UC_Shoe_Load_2()
        {
            
            string query = "select Products.Id, Products.Name, Products.Brand, Products.Size, Products.Price, Products.Image from PSubCategory inner join Products on Products.SCID = PSubCategory.Id where CategoryID = '"+ Category + "'";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }
            int length = dt.Rows.Count;
            if(dt.Rows.Count < 2)
            {
                return;
            }
            if (useless == 0 || cnt_2 == dt.Rows.Count)
            {
                cnt_2 = dt.Rows.Count / 2;
            }
            useless++;

            try
            {
                lblNameValue2.Text = dt.Rows[cnt_2]["Name"].ToString();
                lblBrandValue2.Text = dt.Rows[cnt_2]["Brand"].ToString();
                lblSizeValue2.Text = dt.Rows[cnt_2]["Size"].ToString();
                lblPriceValue2.Text = dt.Rows[cnt_2]["Price"].ToString();
                ID_2 = dt.Rows[cnt_2]["Id"].ToString();
                PRICE_2 = dt.Rows[cnt_2]["Price"].ToString();
                DoRefresh();

                if (dt.Rows[0]["Image"] != DBNull.Value)
                {
                    byte[] imageShow = (byte[])dt.Rows[cnt_2]["Image"];
                    pb2.Image = showImage(imageShow);
                }
                else
                {
                    pb2.Image = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  
            cnt_2 = (cnt_2 + 1);
            
        }



        private void btnCart_1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(login.USERTYPE))
            {
                login l = new login();
                l.Show();
                return;
            }
           
            string query = "insert into [OrderDetails] (orderID, ProductID, Price) Values ('"+login.ORDERID+"', '"+ID_1+"', '"+PRICE_1+"')";
            string error;
            DataAccess.ExecuteData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }
            BuyNow.AMOUNT += Convert.ToDecimal(PRICE_1);

        }

        private void btnCart_2(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(login.USERTYPE))
            {
                login l = new login();
                l.Show();
                return;
            }
            string query = "insert into [OrderDetails] (orderID, ProductID, Price) Values ('" + login.ORDERID + "', '" + ID_2 + "', '" + PRICE_2 + "')";
            string error;
            DataAccess.ExecuteData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }
            BuyNow.AMOUNT += Convert.ToDecimal(PRICE_2);
        }

        public void Initially()
        {
            lblNameValue1.Text = "";
            lblBrandValue1.Text = "";
            lblSizeValue1.Text = "";
            lblPriceValue1.Text = "";

            lblNameValue2.Text = "";
            lblBrandValue2.Text = "";
            lblSizeValue2.Text = "";
            lblPriceValue2.Text = "";
        }

        private Image showImage(byte[] imageShow)
        {
            if (imageShow != null)
            {
                MemoryStream store = new MemoryStream(imageShow);
                return Image.FromStream(store);
            }

            else
            {
                pb1.Image = null;
                return null;
            }
        }

        public void DoRefresh()
        {
            Dispatcher.CurrentDispatcher.Invoke(DispatcherPriority.Background, new EmptyDelegate(delegate { }));
        }
    }
}
