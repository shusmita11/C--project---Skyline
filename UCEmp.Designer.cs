namespace Skyline
{
    partial class UCEmp
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgJoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uselesslbl = new System.Windows.Forms.Label();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.rdbtnOther = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbtnFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbtnMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtSalary = new MetroFramework.Controls.MetroTextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtCnPass = new MetroFramework.Controls.MetroTextBox();
            this.lblCnPass = new System.Windows.Forms.Label();
            this.dateTimeEmp = new MetroFramework.Controls.MetroDateTime();
            this.cmboxEmpType = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtPhnNo = new MetroFramework.Controls.MetroTextBox();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblPhn = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvEmployee);
            this.panel1.Location = new System.Drawing.Point(17, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 420);
            this.panel1.TabIndex = 0;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvName,
            this.dgvEmail,
            this.dgvPhn,
            this.dgvGender,
            this.dgvSalary,
            this.dgvType,
            this.dgvAddress,
            this.dvgJoiningDate});
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(588, 420);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvID.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvID.HeaderText = "ID";
            this.dgvID.MinimumWidth = 6;
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Width = 50;
            // 
            // dgvName
            // 
            this.dgvName.DataPropertyName = "Name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvName.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            this.dgvName.Width = 125;
            // 
            // dgvEmail
            // 
            this.dgvEmail.DataPropertyName = "Email";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvEmail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.MinimumWidth = 6;
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            this.dgvEmail.Width = 125;
            // 
            // dgvPhn
            // 
            this.dgvPhn.DataPropertyName = "Phone No";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPhn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPhn.HeaderText = "Phone No";
            this.dgvPhn.MinimumWidth = 6;
            this.dgvPhn.Name = "dgvPhn";
            this.dgvPhn.ReadOnly = true;
            this.dgvPhn.Width = 125;
            // 
            // dgvGender
            // 
            this.dgvGender.DataPropertyName = "Gender";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvGender.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGender.HeaderText = "Gender";
            this.dgvGender.MinimumWidth = 6;
            this.dgvGender.Name = "dgvGender";
            this.dgvGender.ReadOnly = true;
            this.dgvGender.Width = 50;
            // 
            // dgvSalary
            // 
            this.dgvSalary.DataPropertyName = "Salary";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSalary.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSalary.HeaderText = "Salary";
            this.dgvSalary.MinimumWidth = 6;
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.ReadOnly = true;
            this.dgvSalary.Width = 50;
            // 
            // dgvType
            // 
            this.dgvType.DataPropertyName = "Type";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvType.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvType.HeaderText = "Type";
            this.dgvType.MinimumWidth = 6;
            this.dgvType.Name = "dgvType";
            this.dgvType.ReadOnly = true;
            this.dgvType.Width = 50;
            // 
            // dgvAddress
            // 
            this.dgvAddress.DataPropertyName = "Address";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAddress.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAddress.HeaderText = "Address";
            this.dgvAddress.MinimumWidth = 6;
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            this.dgvAddress.Width = 125;
            // 
            // dvgJoiningDate
            // 
            this.dvgJoiningDate.DataPropertyName = "JoiningDate";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dvgJoiningDate.DefaultCellStyle = dataGridViewCellStyle9;
            this.dvgJoiningDate.HeaderText = "Joining Date";
            this.dvgJoiningDate.MinimumWidth = 6;
            this.dvgJoiningDate.Name = "dvgJoiningDate";
            this.dvgJoiningDate.ReadOnly = true;
            this.dvgJoiningDate.Width = 125;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uselesslbl);
            this.panel2.Controls.Add(this.pnlGender);
            this.panel2.Controls.Add(this.txtSalary);
            this.panel2.Controls.Add(this.lblSalary);
            this.panel2.Controls.Add(this.lblGender);
            this.panel2.Controls.Add(this.txtCnPass);
            this.panel2.Controls.Add(this.lblCnPass);
            this.panel2.Controls.Add(this.dateTimeEmp);
            this.panel2.Controls.Add(this.cmboxEmpType);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtPhnNo);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.lblType);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.lblPass);
            this.panel2.Controls.Add(this.lblPhn);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Location = new System.Drawing.Point(622, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 420);
            this.panel2.TabIndex = 1;
            // 
            // uselesslbl
            // 
            this.uselesslbl.AutoSize = true;
            this.uselesslbl.Location = new System.Drawing.Point(266, 576);
            this.uselesslbl.Name = "uselesslbl";
            this.uselesslbl.Size = new System.Drawing.Size(0, 17);
            this.uselesslbl.TabIndex = 38;
            // 
            // pnlGender
            // 
            this.pnlGender.Controls.Add(this.rdbtnOther);
            this.pnlGender.Controls.Add(this.rdbtnFemale);
            this.pnlGender.Controls.Add(this.rdbtnMale);
            this.pnlGender.Location = new System.Drawing.Point(124, 324);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(279, 30);
            this.pnlGender.TabIndex = 37;
            // 
            // rdbtnOther
            // 
            this.rdbtnOther.AutoSize = true;
            this.rdbtnOther.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(109)))), ((int)(((byte)(150)))));
            this.rdbtnOther.CheckedState.BorderThickness = 0;
            this.rdbtnOther.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbtnOther.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbtnOther.CheckedState.InnerOffset = -4;
            this.rdbtnOther.Font = new System.Drawing.Font("Candara", 10.8F);
            this.rdbtnOther.Location = new System.Drawing.Point(179, 1);
            this.rdbtnOther.Name = "rdbtnOther";
            this.rdbtnOther.Size = new System.Drawing.Size(86, 27);
            this.rdbtnOther.TabIndex = 2;
            this.rdbtnOther.Text = "Others";
            this.rdbtnOther.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbtnOther.UncheckedState.BorderThickness = 2;
            this.rdbtnOther.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbtnOther.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(109)))), ((int)(((byte)(150)))));
            this.rdbtnFemale.CheckedState.BorderThickness = 0;
            this.rdbtnFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbtnFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbtnFemale.CheckedState.InnerOffset = -4;
            this.rdbtnFemale.Font = new System.Drawing.Font("Candara", 10.8F);
            this.rdbtnFemale.Location = new System.Drawing.Point(82, 1);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(89, 27);
            this.rdbtnFemale.TabIndex = 1;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbtnFemale.UncheckedState.BorderThickness = 2;
            this.rdbtnFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbtnFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbtnMale.CheckedState.BorderThickness = 0;
            this.rdbtnMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbtnMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbtnMale.Font = new System.Drawing.Font("Candara", 10.8F);
            this.rdbtnMale.Location = new System.Drawing.Point(4, 1);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(70, 27);
            this.rdbtnMale.TabIndex = 0;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbtnMale.UncheckedState.BorderThickness = 2;
            this.rdbtnMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbtnMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // txtSalary
            // 
            // 
            // 
            // 
            this.txtSalary.CustomButton.Image = null;
            this.txtSalary.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.txtSalary.CustomButton.Name = "";
            this.txtSalary.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalary.CustomButton.TabIndex = 1;
            this.txtSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalary.CustomButton.UseSelectable = true;
            this.txtSalary.CustomButton.Visible = false;
            this.txtSalary.Lines = new string[0];
            this.txtSalary.Location = new System.Drawing.Point(124, 375);
            this.txtSalary.MaxLength = 32767;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.PromptText = "Salary";
            this.txtSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalary.SelectedText = "";
            this.txtSalary.SelectionLength = 0;
            this.txtSalary.SelectionStart = 0;
            this.txtSalary.ShortcutsEnabled = true;
            this.txtSalary.Size = new System.Drawing.Size(280, 30);
            this.txtSalary.TabIndex = 36;
            this.txtSalary.UseSelectable = true;
            this.txtSalary.WaterMark = "Salary";
            this.txtSalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSalary
            // 
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(40, 375);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(74, 23);
            this.lblSalary.TabIndex = 35;
            this.lblSalary.Text = "Salary :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(31, 325);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(83, 23);
            this.lblGender.TabIndex = 33;
            this.lblGender.Text = "Gender :";
            // 
            // txtCnPass
            // 
            // 
            // 
            // 
            this.txtCnPass.CustomButton.Image = null;
            this.txtCnPass.CustomButton.Location = new System.Drawing.Point(251, 2);
            this.txtCnPass.CustomButton.Name = "";
            this.txtCnPass.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCnPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCnPass.CustomButton.TabIndex = 1;
            this.txtCnPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCnPass.CustomButton.UseSelectable = true;
            this.txtCnPass.CustomButton.Visible = false;
            this.txtCnPass.Lines = new string[0];
            this.txtCnPass.Location = new System.Drawing.Point(124, 273);
            this.txtCnPass.MaxLength = 32767;
            this.txtCnPass.Name = "txtCnPass";
            this.txtCnPass.PasswordChar = '*';
            this.txtCnPass.PromptText = "Re-type Password";
            this.txtCnPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCnPass.SelectedText = "";
            this.txtCnPass.SelectionLength = 0;
            this.txtCnPass.SelectionStart = 0;
            this.txtCnPass.ShortcutsEnabled = true;
            this.txtCnPass.Size = new System.Drawing.Size(279, 30);
            this.txtCnPass.TabIndex = 32;
            this.txtCnPass.UseSelectable = true;
            this.txtCnPass.WaterMark = "Re-type Password";
            this.txtCnPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCnPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCnPass
            // 
            this.lblCnPass.AutoSize = true;
            this.lblCnPass.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnPass.Location = new System.Drawing.Point(16, 274);
            this.lblCnPass.Name = "lblCnPass";
            this.lblCnPass.Size = new System.Drawing.Size(98, 23);
            this.lblCnPass.TabIndex = 31;
            this.lblCnPass.Text = "Con Pass :";
            // 
            // dateTimeEmp
            // 
            this.dateTimeEmp.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.dateTimeEmp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEmp.Location = new System.Drawing.Point(124, 477);
            this.dateTimeEmp.MinimumSize = new System.Drawing.Size(4, 30);
            this.dateTimeEmp.Name = "dateTimeEmp";
            this.dateTimeEmp.Size = new System.Drawing.Size(279, 30);
            this.dateTimeEmp.TabIndex = 30;
            // 
            // cmboxEmpType
            // 
            this.cmboxEmpType.FormattingEnabled = true;
            this.cmboxEmpType.ItemHeight = 24;
            this.cmboxEmpType.Location = new System.Drawing.Point(124, 426);
            this.cmboxEmpType.Name = "cmboxEmpType";
            this.cmboxEmpType.Size = new System.Drawing.Size(279, 30);
            this.cmboxEmpType.TabIndex = 29;
            this.cmboxEmpType.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Date :";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(251, 2);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(124, 120);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Email";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(279, 30);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Email";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhnNo
            // 
            // 
            // 
            // 
            this.txtPhnNo.CustomButton.Image = null;
            this.txtPhnNo.CustomButton.Location = new System.Drawing.Point(251, 2);
            this.txtPhnNo.CustomButton.Name = "";
            this.txtPhnNo.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPhnNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhnNo.CustomButton.TabIndex = 1;
            this.txtPhnNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhnNo.CustomButton.UseSelectable = true;
            this.txtPhnNo.CustomButton.Visible = false;
            this.txtPhnNo.Lines = new string[0];
            this.txtPhnNo.Location = new System.Drawing.Point(124, 171);
            this.txtPhnNo.MaxLength = 32767;
            this.txtPhnNo.Name = "txtPhnNo";
            this.txtPhnNo.PasswordChar = '\0';
            this.txtPhnNo.PromptText = "Phone No";
            this.txtPhnNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhnNo.SelectedText = "";
            this.txtPhnNo.SelectionLength = 0;
            this.txtPhnNo.SelectionStart = 0;
            this.txtPhnNo.ShortcutsEnabled = true;
            this.txtPhnNo.Size = new System.Drawing.Size(279, 30);
            this.txtPhnNo.TabIndex = 26;
            this.txtPhnNo.UseSelectable = true;
            this.txtPhnNo.WaterMark = "Phone No";
            this.txtPhnNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhnNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(124, 528);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PromptText = "Address";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(279, 45);
            this.txtAddress.TabIndex = 24;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMark = "Address";
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(251, 2);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(124, 222);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PromptText = "Password";
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(279, 30);
            this.txtPass.TabIndex = 23;
            this.txtPass.UseSelectable = true;
            this.txtPass.WaterMark = "Password";
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(251, 2);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(124, 69);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Name";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(279, 30);
            this.txtName.TabIndex = 22;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Name";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(251, 2);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(124, 18);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PromptText = "Auto Generated";
            this.txtID.ReadOnly = true;
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(279, 30);
            this.txtID.TabIndex = 21;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMark = "Auto Generated";
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(53, 427);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(61, 23);
            this.lblType.TabIndex = 20;
            this.lblType.Text = "Type :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(26, 529);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(88, 23);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "Address :";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(14, 223);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(100, 23);
            this.lblPass.TabIndex = 18;
            this.lblPass.Text = "Password :";
            // 
            // lblPhn
            // 
            this.lblPhn.AutoSize = true;
            this.lblPhn.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhn.Location = new System.Drawing.Point(8, 172);
            this.lblPhn.Name = "lblPhn";
            this.lblPhn.Size = new System.Drawing.Size(106, 23);
            this.lblPhn.TabIndex = 17;
            this.lblPhn.Text = "Phone No :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(47, 121);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 23);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(43, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 23);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(74, 19);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(40, 23);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID :";
            // 
            // btnNew
            // 
            this.btnNew.AutoRoundedCorners = true;
            this.btnNew.BorderColor = System.Drawing.Color.Transparent;
            this.btnNew.BorderRadius = 21;
            this.btnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(17, 469);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(190, 45);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 21;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(216, 469);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 45);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoRoundedCorners = true;
            this.btnRefresh.BorderColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderRadius = 21;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(415, 469);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(190, 45);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 21;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(622, 469);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(457, 45);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UCEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCEmp";
            this.Size = new System.Drawing.Size(1082, 540);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtPhnNo;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtID;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblPhn;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime dateTimeEmp;
        private MetroFramework.Controls.MetroComboBox cmboxEmpType;
        private System.Windows.Forms.Label lblGender;
        private MetroFramework.Controls.MetroTextBox txtCnPass;
        private System.Windows.Forms.Label lblCnPass;
        private MetroFramework.Controls.MetroTextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Panel pnlGender;
        private Guna.UI2.WinForms.Guna2RadioButton rdbtnOther;
        private Guna.UI2.WinForms.Guna2RadioButton rdbtnFemale;
        private Guna.UI2.WinForms.Guna2RadioButton rdbtnMale;
        private System.Windows.Forms.Label uselesslbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgJoiningDate;
    }
}
