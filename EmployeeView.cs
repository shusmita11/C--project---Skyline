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
    public partial class EmployeeView : MetroFramework.Forms.MetroForm
    {
        string catORsub = "Cat";
        string id;
        string Sid;
        public EmployeeView()
        {
            InitializeComponent();
            Load_DB_Cat();
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

        private void Catagory_Click(object sender, EventArgs e)
        {
            catORsub = "Cat";
            pnlCat.Visible = true;
            dgvCat.Visible = true;
            pnlSCat.Visible = false;
            dgvScat.Visible = false;
            Load_DB_Cat();
        }

        private void SubCat_Click(object sender, EventArgs e)
        {
            catORsub = "Sub";
            pnlCat.Visible = false;
            dgvCat.Visible = false;
            pnlSCat.Visible = true;
            dgvScat.Visible = true;
            Load_DB_SubCat();
        }

        private void gubUPDATE_Click(object sender, EventArgs e)
        {
            gubREFRESH_Click(sender, e);
        }
        private void NewData()
        {
            if(catORsub == "Cat")
            {
                txtid.Text = " ";
                txttitle.Text = " ";
                dgvCat.ClearSelection();
            }
            else
            {
                txtsid.Text = " ";
                txtstitle.Text = " ";
                cmbS.SelectedItem = null;
                dgvScat.ClearSelection();
            }
            
        }

        private void Load_DB_Cat()
        {
            string query = "SELECT * FROM ProductCategory";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                //return;
            }

            dgvCat.AutoGenerateColumns = false;
            dgvCat.DataSource = dt;
            dgvCat.ClearSelection();
            dgvCat.Refresh();

        }
        private void Load_DB_SubCat()
        {
            string query = "SELECT PSubCategory.Id ID, PSubCategory.Title Title, ProductCategory.Title Category FROM PSubCategory inner join ProductCategory on ProductCategory.Id = PSubCategory.CategoryID";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                //return;
            }
            dgvScat.AutoGenerateColumns = false;
            dgvScat.DataSource = dt;
            dgvScat.ClearSelection();
            dgvScat.Refresh();

            query = "SELECT * FROM ProductCategory";
            dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                //return;
            }
            //cmbS.SelectedValue = Convert.ToInt32(dt.Rows[0]["Title"]);
            cmbS.DataSource = dt;
            cmbS.DisplayMember = "Title";
            cmbS.ValueMember = "Id";



        }

        private void gubDELETE_Click(object sender, EventArgs e)
        {
            if(catORsub == "Cat")
            {
                if (string.IsNullOrEmpty(txtid.Text))
                {
                    MessageBox.Show(" Please select a row ");
                    return;
                }
                var result = MessageBox.Show(" Are you sure? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {

                    var query = " delete from ProductCategory where id = '" + txtid.Text + "'";
                    string error;
                    DataAccess.ExecuteData(query, out error);
                    if (string.IsNullOrEmpty(error) == false)
                    {
                        MessageBox.Show(error);
                        return;
                    }
                    this.Load_DB_Cat();
                    this.NewData();
                    MessageBox.Show("Deleted");
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtsid.Text))
                {
                    MessageBox.Show(" Please select a row ");
                    return;
                }
                var result = MessageBox.Show(" Are you sure? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {

                    var query = " delete from PSubCategory where id = '" + txtsid.Text + "'";
                    string error;
                    DataAccess.ExecuteData(query, out error);
                    if (string.IsNullOrEmpty(error) == false)
                    {
                        MessageBox.Show(error);
                        return;
                    }
                    this.Load_DB_SubCat();
                    this.NewData();
                    MessageBox.Show("Deleted");
                }
            }
            


        }



        private void gubSAVE_Click(object sender, EventArgs e)
        {
            if (catORsub == "Cat")
            {
                string id = txtid.Text;
                string title = txttitle.Text;
                string query;
                if (string.IsNullOrEmpty(title))
                {
                    MessageBox.Show("Invalid title");
                    txttitle.Focus();
                    return;

                }

                else
                {
                    if (string.IsNullOrEmpty(id))
                    {
                        query = "INSERT INTO ProductCategory (Title) VALUES ('" + title + "')";

                    }
                    else
                    {
                        query = "UPDATE ProductCategory set Title = '" + title + "' where Id = '" + id + "'";
                    }
                    string error;
                    DataAccess.ExecuteData(query, out error);
                    if (string.IsNullOrEmpty(error) == false)
                    {
                        MessageBox.Show(error);
                        return;
                    }
                    this.Load_DB_Cat();
                    this.NewData();
                    MessageBox.Show("Updated");
                }
            }
            else
            {
                string id = txtsid.Text;
                string title = txtstitle.Text;
                string query;
                string cat = cmbS.SelectedValue.ToString();
                if (string.IsNullOrEmpty(title))
                {
                    MessageBox.Show("Invalid title");
                    txttitle.Focus();
                    return;

                }
                
                else
                {
                    if (string.IsNullOrEmpty(id))
                    {
                        query = "INSERT INTO PSubCategory (Title, CategoryID) VALUES ('" + title + "', '"+cat+"')";

                    }
                    else
                    {
                        query = "UPDATE PSubCategory set Title = '" + title + "', CategoryID = '"+cat+"' where Id = '" + id + "'";
                    }
                    string error;
                    DataAccess.ExecuteData(query, out error);
                    if (string.IsNullOrEmpty(error) == false)
                    {
                        MessageBox.Show(error);
                        return;
                    }
                    this.Load_DB_SubCat();
                    this.NewData();
                    MessageBox.Show("Updated");
                }
            }
        }

        private void gubREFRESH_Click(object sender, EventArgs e)
        {
            NewData();
        }

        private void dgvCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                id = dgvCat.Rows[e.RowIndex].Cells[0].Value.ToString();

                string query = "SELECT * from ProductCategory WHERE Id = '" + id + "'";
                string err = null;

                DataTable dt = DataAccess.GetData(query, out err);

                txtid.Text = id;
                txttitle.Text = dt.Rows[0]["Title"].ToString();
            }


        }

        private void dgvScat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Sid = dgvScat.Rows[e.RowIndex].Cells[0].Value.ToString();

                string query = "SELECT PSubCategory.Id ID, PSubCategory.Title Title, ProductCategory.Title Category FROM PSubCategory inner join ProductCategory on ProductCategory.Id = PSubCategory.CategoryID Where PSubCategory.Id = '" + Sid + "'";
                string err = null;

                DataTable dt = DataAccess.GetData(query, out err);

                txtsid.Text = Sid;
                txtstitle.Text = dt.Rows[0]["Title"].ToString();
                //cmbS.SelectedValue = Convert.ToInt32(dt.Rows[0]["PID"]);
                   // cmboxEmpType.SelectedValue = Convert.ToInt32(dt.Rows[0]["UserTypeID"])

            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            formProduct p = new formProduct();
            p.Show();
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
    }
}
