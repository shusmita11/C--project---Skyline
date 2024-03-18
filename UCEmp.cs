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
    public partial class UCEmp : UserControl
    {
        string id;
        string name = null, email = null, password = null, addresss = null, gender = null, JoiningDate = null, type = null;
        decimal Salary;
        int phn;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Employee WHERE Id = '" + id + "'";
            string error = null;

            DataAccess.ExecuteData(query, out error);

            query = "DELETE FROM UserInfo WHERE Id = '" + id + "'";
            DataAccess.ExecuteData(query, out error);

            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Connection Problem");
                return;
            }
            btnRefresh_Click_1(sender, e);
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = dgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();

                string query = "SELECT us.Name Name, us.Email Email, us.PhoneNo [Phone No], us.Address Address, us.Gender Gender, us.Password Password, us.UserTypeID UserTypeID, e.Salary Salary, e.JoiningDate JoiningDate from UserInfo us inner join Employee e on us.Id = e.Id inner join UserType ut on us.UserTypeID = ut.Id where us.Id = '"+id+"'";

                string err = null;

                DataTable dt = DataAccess.GetData(query, out err);
                if (string.IsNullOrEmpty(err) == false)
                {
                    MessageBox.Show("Connection Problem");
                    return;
                }

                txtID.Text = id;
                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtPhnNo.Text = dt.Rows[0]["Phone No"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                gender = dt.Rows[0]["Gender"].ToString();
                txtPass.Text = dt.Rows[0]["Password"].ToString();
                txtCnPass.Text = dt.Rows[0]["Password"].ToString();
                cmboxEmpType.SelectedValue = Convert.ToInt32(dt.Rows[0]["UserTypeID"]);
                type = cmboxEmpType.SelectedValue.ToString();

                txtSalary.Text = dt.Rows[0]["Salary"].ToString();
                dateTimeEmp.Value = Convert.ToDateTime(dt.Rows[0]["JoiningDate"].ToString());


                if (gender == "Male")
                {
                    rdbtnMale.Checked = true;
                }
                else if (gender == "Female")
                {
                    rdbtnFemale.Checked = true;
                }
                else if (gender == "Other")
                {
                    rdbtnOther.Checked = true;
                }
            }
        }

       
        private void btnNew_Click(object sender, EventArgs e)
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
            txtSalary.Text = null;
            dateTimeEmp.Value = DateTime.Now;
            cmboxEmpType.SelectedItem = null;
            dgvEmployee.ClearSelection();
        }

        internal void btnRefresh_Click_1(object sender, EventArgs e)
        {          
            string query = "Select UserInfo.Id ID, UserInfo.[Name] [Name], UserInfo.Email Email, UserInfo.PhoneNo [Phone No], UserInfo.Gender Gender, Employee.Salary Salary, UserType.[Type] [Type], UserInfo.[Address] [Address], Employee.JoiningDate from UserInfo Inner Join Employee on Employee.Id = UserInfo.Id Inner Join UserType on UserInfo.UserTypeID = UserType.Id";
            string err;

            DataTable dt = DataAccess.GetData(query, out err);
            if (string.IsNullOrEmpty(err) == false)
            {
                MessageBox.Show("Failed");
            }

            dgvEmployee.AutoGenerateColumns = false;         
            dgvEmployee.DataSource = dt;
            btnNew_Click(sender, e);
            dgvEmployee.Refresh();
            dgvEmployee.ClearSelection();
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool done = GetValue();
            string query1, query2;
            string error;

            if (done == false)
            {
                return;
            }

            if (txtID.Text == "")
            {
                query1 = "INSERT INTO UserInfo ([Name], Email, PhoneNo, [Password], [Address], UserTypeID, Gender) OUTPUT INSERTED.Id VALUES('" + name + "', '" + email + "', '" + phn + "', '" + password + "', '" + addresss + "', '" + type + "', '" + gender + "')";
                DataTable dt = DataAccess.GetData(query1, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show("Failed");
                }
                var id = dt.Rows[0]["Id"].ToString();

                query2 = "INSERT INTO Employee (Id, Salary, JoiningDate) VALUES ('" + id + "', '" + Salary + "', '" + JoiningDate + "')";
                DataAccess.ExecuteData(query2, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                }

            }
            else
            {
                query1 = "Update UserInfo set Name = '" + name + "', Email = '" + email + "', PhoneNo = '" + phn + "', Password = '" + password + "', Address = '" + addresss + "', UserTypeID = '" + type + "', Gender = '" + gender + "' where Id = '"+txtID.Text+"'";
                DataAccess.GetData(query1, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    //MessageBox.Show("Failed");
                }
                query2 = "Update Employee set Id = '" + id + "', Salary = '" + Salary + "', JoiningDate = '" + JoiningDate + "' where Id = '" + txtID.Text + "'";
                DataAccess.ExecuteData(query2, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    //MessageBox.Show(error);
                }
            }   
            btnRefresh_Click_1(sender, e);
        }

  

        public UCEmp()
        {
            InitializeComponent();
            CmbBoxData();
            btnRefresh_Click_1(null, null);
  
        }

        private void CmbBoxData()
        {
            string query = "select * from UserType where Id <> 3";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
            if(String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Something went Wrong!");
                return;
            }

            cmboxEmpType.DataSource = dt;
            cmboxEmpType.DisplayMember = "Type";
            cmboxEmpType.ValueMember = "Id";
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

                if(dt.Rows.Count == 0)
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

            if (string.IsNullOrEmpty(dateTimeEmp.Text) == false)
            {
                dateTimeEmp.Format = DateTimePickerFormat.Custom;
                dateTimeEmp.CustomFormat = "dd-MM-yyyy";
                JoiningDate = dateTimeEmp.Value.ToString();
            }
            else
            {
                dateTimeEmp.Focus();
                dateTimeEmp.Style = MetroFramework.MetroColorStyle.Red;
                return false;
            }

            if (string.IsNullOrEmpty(txtSalary.Text) == false)
            {
                try
                {
                    Salary = Convert.ToDecimal(txtSalary.Text); 
                }
                catch(Exception ex)
                {
                    txtSalary.Focus();
                    txtSalary.Style = MetroFramework.MetroColorStyle.Red;
                    return false;
                }
            }
            else
            {
                txtSalary.Focus();
                txtSalary.Style = MetroFramework.MetroColorStyle.Red;
                return false;
            }

            if(cmboxEmpType.SelectedItem != null)
            {
                type = cmboxEmpType.SelectedValue.ToString();
            }
            else
            {
                cmboxEmpType.Focus();
                cmboxEmpType.Style = MetroFramework.MetroColorStyle.Red;
                return false;
            }

            return true;
        }
    }
}
