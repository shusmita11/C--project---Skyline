using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyline
{
    public partial class UCCust : UserControl
    {
        string id;
        string name = null, email = null, password = null, addresss = null, gender = null;
        int phn;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM UserInfo WHERE Id = '"+id+"'";
            string error = null;

            DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == true)
            {
                MessageBox.Show("Connection Problem");
                return;
            }
            btnRefresh_Click(sender, e);
            MessageBox.Show("Deleted");
            
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                id = dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();

                string query = "SELECT * from UserInfo WHERE Id = '" + id + "'";
                string err = null;

                DataTable dt = DataAccess.GetData(query, out err);
                if (string.IsNullOrEmpty(err) == true)
                {
                    MessageBox.Show("Connection Problem");
                    return;
                }
                txtID.Text = id;
                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtPhnNo.Text = dt.Rows[0]["PhoneNo"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                txtGender.Text = dt.Rows[0]["Gender"].ToString();
                txtPass.Text = dt.Rows[0]["Password"].ToString();
                txtCnPass.Text = dt.Rows[0]["Password"].ToString();

                if (txtGender.Text == "Male")
                {
                    rdbtnMale.Checked = true;
                }
                else if (txtGender.Text == "Female")
                {
                    rdbtnFemale.Checked = true;
                }
                else if (txtGender.Text == "Other")
                {
                    rdbtnOther.Checked = true;
                }
            }           
        }

        internal void btnNew_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhnNo.Text = "";
            txtAddress.Text = "";
            txtCnPass.Text = "";
            rdbtnMale.Checked = false;
            rdbtnFemale.Checked = false;
            rdbtnOther.Checked = false;
            txtPass.Text = "";
            dgvCustomer.ClearSelection();
        }

        internal void btnRefresh_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM UserInfo WHERE UserTypeId = 3";
            string err;

            DataTable dt = DataAccess.GetData(query, out err);
            if (string.IsNullOrEmpty(err) == false)
            {
                MessageBox.Show("Failed");
            }
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = dt;
            btnNew_Click(sender, e);
            dgvCustomer.ClearSelection();
            dgvCustomer.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool done = GetValue();
            string query;
            string error;

            if (done == false)
            {
                return;
            }

            if(txtID.Text == "")
            {
                query = "INSERT INTO UserInfo ([Name], Email, PhoneNo, [Password], [Address], UserTypeID, Gender) VALUES('" + name + "', '" + email + "', '" + phn + "', '" + password + "', '" + addresss + "', 3, '" + gender + "')";
                DataAccess.ExecuteData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                query = "Update UserInfo set Name = '" + name + "', Email = '" + email + "', PhoneNo = '" + phn + "', Password = '" + password + "', Address = '" + addresss + "', Gender = '" + gender + "' where Id = '" + txtID.Text + "'";
                DataAccess.GetData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    //MessageBox.Show("Failed");
                }
            }
            btnRefresh_Click(sender, e);
        }

        public UCCust()
        {
            InitializeComponent();
        }

        public bool GetValue()
        {
            
                if (string.IsNullOrEmpty(txtName.Text) == false)
                {
                    name = txtName.Text;
                }
                else
                {
                    txtName.Focus();
                    txtName.Style = MetroFramework.MetroColorStyle.Red;
                    return false;
                }

                if (string.IsNullOrEmpty(txtEmail.Text) == false)
                {
                    string query = "Select Email from UserInfo where Email = '" + txtEmail.Text + "'";
                    string error;

                    DataTable dt = DataAccess.GetData(query, out error);
                    if (String.IsNullOrEmpty(error) == false)
                    {
                        MessageBox.Show("Something went Wrong!");
                    }

                    if (dt.Rows.Count == 0)
                    {
                        email = txtEmail.Text;
                    }
                    else
                    {
                        txtEmail.Focus();
                        txtEmail.Style = MetroFramework.MetroColorStyle.Red;
                        return false;
                    }
                }
                else
                {
                    txtEmail.Focus();
                    txtEmail.Style = MetroFramework.MetroColorStyle.Red;
                    return false;
                }

                if (string.IsNullOrEmpty(txtPhnNo.Text) == false && txtPhnNo.Text.Length == 11)
                {
                try
                {
                    phn = Convert.ToInt32(txtPhnNo.Text);
                }
                catch (Exception ex)
                {
                    txtPhnNo.Focus();
                    txtPhnNo.Style = MetroFramework.MetroColorStyle.Red;
                    return false;
                }
                }
                else
                {
                    txtPhnNo.Focus();
                    txtPhnNo.Style = MetroFramework.MetroColorStyle.Red;
                    return false;
                }

                if (rdbtnMale.Checked)
                {
                    gender = "Male";
                }
                else if (rdbtnFemale.Checked)
                {
                    gender = "Female";
                }
                else if (rdbtnOther.Checked)
                {
                    gender = "Other";
                }
                else
                {
                    pnlGender.BorderStyle = BorderStyle.FixedSingle;
                    return false;
                }

                if ((txtCnPass.Text == txtPass.Text) && string.IsNullOrEmpty(txtPass.Text) == false && string.IsNullOrEmpty(txtCnPass.Text) == false)
                {
                    password = txtPass.Text;
                }
                else
                {
                    txtPass.Focus();
                    txtCnPass.Focus();
                    txtCnPass.Style = MetroFramework.MetroColorStyle.Red;
                    txtPass.Style = MetroFramework.MetroColorStyle.Red;
                    return false;
                }

                if (string.IsNullOrEmpty(txtAddress.Text) == false)
                {
                    addresss = txtAddress.Text;
                }
                else
                {
                    txtAddress.Focus();
                    txtAddress.Style = MetroFramework.MetroColorStyle.Red;
                    return false;
                }
            return true;         
        }        
    }
}
