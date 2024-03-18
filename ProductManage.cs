using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skyline;

namespace Skyline_mark0
{
    public partial class formProduct : MetroFramework.Forms.MetroForm
    {
        public formProduct()
        {
            InitializeComponent();
            //btnMax.BackgroundImage = Properties.Resources.max;
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
        /// 
        private void formProduct_Load(object sender, EventArgs e)
        {
            this.LoadProduct();
            cmbCategory.SelectedItem = null;
            LoadComboBox();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
           if(this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                //btnMax.BackgroundImage = Properties.Resources.restore;
                panel1.Width = 1830;
                sidebar.Height = 1500;
                panel7.Width = 1751;
                panel7.Height = 1500;
            }
           /*else if(this.WindowState == FormWindowState.Maximized)
            {
               
                panel7.Width = 1118;
                panel7.Height = 666;
                sidebar.Height = 680;
                panel1.Width = 1000;
                this.PerformLayout();
                this.WindowState = FormWindowState.Normal;
                btnMax.BackgroundImage = Properties.Resources.max;
            }*/
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadProduct();
            this.NewData();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex + "");
            if (e.RowIndex >= 0)
            {
                string id = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.LoadInfo(id);
                //MessageBox.Show(id);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.NewData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please select an item");
                return;
            }
            var result = MessageBox.Show("Are you sure you want to delete? ", "Delete Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //MessageBox.Show(txtID.Text);

                string query = "delete from Products where Id = " + txtID.Text + "";
                //MessageBox.Show("delete from Products where Id = " + txtID.Text + "");
                string error;
                DataAccess.ExecuteData(query, out error);

                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                this.LoadProduct();
                this.NewData();
                MessageBox.Show("Successfully Deleted");

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string brand = txtBrand.Text;
            string size = txtSize.Text;
            double price;
            int subcateID;
            if (!double.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Enter a valid price");
                txtPrice.Focus();
                return;
            }


            if (string.IsNullOrEmpty(txtID.Text) == false)
            {
                int id = Int32.Parse(txtID.Text);
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Enter a Name!");
                    txtName.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(brand))
                {
                    MessageBox.Show("Enter a Brand!");
                    txtBrand.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Enter a Price!");
                    txtPrice.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(size))
                {
                    MessageBox.Show("Enter a Size!");
                    txtSize.Focus();
                    return;
                }


                if (cmbCategory.SelectedItem == null)
                {
                    MessageBox.Show("Select a sub Category!");
                    return;
                }
                else
                {
                    subcateID = Convert.ToInt32(cmbCategory.SelectedValue);
                }
                byte[] imageB = ConvertImageToByte(picBimage.Image);

                UpdateData(Int32.Parse(txtID.Text), name, subcateID, brand, price, size, imageB);

            }

            else
            {
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Enter a Name!");
                    txtName.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(brand))
                {
                    MessageBox.Show("Enter a Brand!");
                    txtBrand.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Enter a Price!");
                    txtPrice.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(size))
                {
                    MessageBox.Show("Enter a Size!");
                    txtSize.Focus();
                    return;
                }


                if (cmbCategory.SelectedItem == null)
                {
                    MessageBox.Show("Select a sub Category!");
                    return;
                }
                else
                {
                    subcateID = Convert.ToInt32(cmbCategory.SelectedValue);
                }
                ///////
                byte[] imageB = ConvertImageToByte(picBimage.Image);

                InsertData(name, subcateID, brand, price, size, imageB);


            }
        }

        /// <summary>
        /// called to show data's in dgv
        /// </summary>
        private void LoadProduct()
        {
            string query = "select Products.Id, Products.Name, PSubCategory.Title as subCategory, Products.Brand, Products.Price, Products.Size, Products.Image from Products join PSubCategory  on Products.SCID=PSubCategory.ID;";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Something went wrong", MessageBoxButtons.OK);
                return;
            }

            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.DataSource = dt;
            dgvProduct.Refresh();
            dgvProduct.ClearSelection();
        }
 
        //shows info on info panel based on the selection of id
        private void LoadInfo(string id)
        {
            string query = "select * from Products join PSubCategory  on Products.SCID=PSubCategory.ID where Products.Id = " + id+"";
            string error = "";
            DataTable dt = DataAccess.GetData(query, out error);

            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show(error);
                return;
            }

            txtID.Text = dt.Rows[0]["ID"].ToString();
            txtName.Text = dt.Rows[0]["Name"].ToString();
            txtBrand.Text = dt.Rows[0]["Brand"].ToString();
            txtPrice.Text = dt.Rows[0]["Price"].ToString();
            txtSize.Text = dt.Rows[0]["Size"].ToString();
            cmbCategory.SelectedValue = Convert.ToInt32(dt.Rows[0]["SCID"]);
            if(dt.Rows[0]["Image"]!=DBNull.Value)
            {
                byte[] imageShow = (byte[])dt.Rows[0]["Image"];
                picBimage.Image = showImage(imageShow);
            }
            else
            {
                picBimage.Image = null;
            }
        }

        //makes info panel empty
        private void NewData()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtBrand.Text = "";
            txtPrice.Text = "";
            txtSize.Text = "";
            dgvProduct.ClearSelection();
            cmbCategory.SelectedItem = null;
            picBimage.Image = null;
        }

        private void UpdateData(int id, string name, int scid, string brand, double price, string size, byte [] imageB)
        {
            string query;
            string error;
            if (imageB!=null)
            {
                //query = "update Products set Name='" + name + "', Brand='" + brand + "', SCID = " + scid + ", Price=" + price + ", Size='" + size + "',Image='" + imageB + "' where Id=" + id + ";";
                string connectionString = @"Data Source=DESKTOP-TSEM9H4\SQLEXPRESS;Initial Catalog=SKYLINE_DB;Integrated Security=True";
                query = "update Products set Name=@name, Brand=@brand, SCID =@scid, Price= @price, Size= @size, Image=@image where Id=@id;";
                
                try
                {
                    //query = "insert into Products ([Name],SCID,Brand,Price,Size,[Image]) output inserted.Id values('" + name + "'," + scid + ",'" + brand + "'," + price + ",'" + size + "','"+imageB+"')";

                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@scid", scid);
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@size", size);
                    cmd.Parameters.AddWithValue("@image", imageB);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    error = "";
                }

                catch (Exception ex)
                {
                    error = ex.Message;
                }
            }
            
            else
            {
                query = "update Products set Name='" + name + "', Brand='" + brand + "', SCID = " + scid + ", Price=" + price + ", Size='" + size + "' where Id=" + id + ";";
                DataAccess.ExecuteData(query, out error);
            }

         
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show("Update failed");
                return;
            }
            this.LoadProduct();
            MessageBox.Show("Successfully Updated");
            this.NewData();
        }

        private void InsertData(string name, int scid, string brand, double price, string size, byte[] imageB)
        {
            string query;
            string error;
            if (imageB != null)
            {
                string connectionString = @"Data Source=DESKTOP-TSEM9H4\SQLEXPRESS;Initial Catalog=SKYLINE_DB;Integrated Security=True";
                query = "insert into Products ([Name],SCID,Brand,Price,Size,Image) output inserted.Id values(@name,@scid,@brand,@price,@size,@image)";
                try
                {
                    //query = "insert into Products ([Name],SCID,Brand,Price,Size,[Image]) output inserted.Id values('" + name + "'," + scid + ",'" + brand + "'," + price + ",'" + size + "','"+imageB+"')";
                    
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@scid", scid);
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@size", size);
                    cmd.Parameters.AddWithValue("@image", imageB);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    error = null;
                }

                catch (Exception ex)
                {
                    error = ex.Message;
                }

            }

            else
            {
                query = "insert into Products ([Name],SCID,Brand,Price,Size) output inserted.Id values('"+ name + "',"+ scid + ",'"+ brand + "',"+ price + ",'"+size+"')";
                DataAccess.ExecuteData(query, out error);
            }
           
            if(string.IsNullOrEmpty(error)==false)
            {
                MessageBox.Show(error);
                MessageBox.Show("Insert failed");
                //return;
            }
            this.LoadProduct();
            this.NewData();
            MessageBox.Show("Succesfully Inserted");
        }
          
        private void LoadComboBox()
        {
            string query = "Select * from PSubCategory";
            string error;
            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "Something went wrong", MessageBoxButtons.OK);
                return;
            }

            cmbCategory.DataSource = dt;
            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Title";
            cmbCategory.SelectedItem = null;
        }

        //open dialog to insert image
        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
            ofd.Title = "Select an image";

            if(ofd.ShowDialog()==DialogResult.OK)
            {
                string path = ofd.FileName;

                picBimage.Image = Image.FromFile(path);
            }
        }

        // convert image to byte
        private byte[] ConvertImageToByte(Image image)
        {
            if(image==null)
            {
                return null;
            }
            MemoryStream store = new MemoryStream();
            image.Save(store, ImageFormat.Jpeg);
            return store.ToArray();
        }

        //convert byte array to image
        private Image showImage(byte[] imageShow)
        {
            if(imageShow!=null)
            {
                MemoryStream store = new MemoryStream(imageShow);
                return Image.FromStream(store);
                //return picBimage.Image = img;
            }

            else
            {
                picBimage.Image = null;
                return null;
            }
        }

        private void btn_Hover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.CadetBlue;
        }

        private void btn_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
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
    }
}
