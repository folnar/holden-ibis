namespace ibis_R1a
{
    partial class frmEmployee
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblOvertimeRate = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.txtLeaveDate = new System.Windows.Forms.TextBox();
            this.lblLeaveDate = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.cbxIsActive = new System.Windows.Forms.ComboBox();
            this.hesemployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.holdenengrDataSet = new ibis_R1a.holdenengrDataSet();
            this.hesemployeeTableAdapter = new ibis_R1a.holdenengrDataSetTableAdapters.hesemployeeTableAdapter();
            this.ibisyesnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ibis_yesnoTableAdapter = new ibis_R1a.holdenengrDataSetTableAdapters.ibis_yesnoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hesemployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdenengrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibisyesnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(60, 32);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 17);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_lastname", true));
            this.txtLastName.Location = new System.Drawing.Point(141, 29);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(166, 24);
            this.txtLastName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(60, 92);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(43, 62);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(92, 17);
            this.lblMiddleName.TabIndex = 3;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_middlename", true));
            this.txtMiddleName.Location = new System.Drawing.Point(141, 59);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(166, 24);
            this.txtMiddleName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_firstname", true));
            this.txtFirstName.Location = new System.Drawing.Point(141, 89);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(166, 24);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(12, 122);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(124, 17);
            this.lblEmployeeNumber.TabIndex = 4;
            this.lblEmployeeNumber.Text = "Employee Number:";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_hesnumber", true));
            this.txtEmployeeNumber.Location = new System.Drawing.Point(141, 119);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(63, 24);
            this.txtEmployeeNumber.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_password", true));
            this.textBox1.Location = new System.Drawing.Point(141, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 24);
            this.textBox1.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(68, 182);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 17);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_username", true));
            this.textBox2.Location = new System.Drawing.Point(141, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 24);
            this.textBox2.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(66, 152);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(69, 17);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_otrate", true));
            this.textBox3.Location = new System.Drawing.Point(141, 239);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(93, 24);
            this.textBox3.TabIndex = 8;
            // 
            // lblOvertimeRate
            // 
            this.lblOvertimeRate.AutoSize = true;
            this.lblOvertimeRate.Location = new System.Drawing.Point(40, 242);
            this.lblOvertimeRate.Name = "lblOvertimeRate";
            this.lblOvertimeRate.Size = new System.Drawing.Size(95, 17);
            this.lblOvertimeRate.TabIndex = 13;
            this.lblOvertimeRate.Text = "Overtime Rate:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_payrate", true));
            this.textBox4.Location = new System.Drawing.Point(141, 209);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(93, 24);
            this.textBox4.TabIndex = 7;
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(48, 212);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(87, 17);
            this.lblPayRate.TabIndex = 10;
            this.lblPayRate.Text = "Hourly Wage:";
            // 
            // txtLeaveDate
            // 
            this.txtLeaveDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_leavedate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.txtLeaveDate.Location = new System.Drawing.Point(141, 299);
            this.txtLeaveDate.Name = "txtLeaveDate";
            this.txtLeaveDate.Size = new System.Drawing.Size(116, 24);
            this.txtLeaveDate.TabIndex = 10;
            // 
            // lblLeaveDate
            // 
            this.lblLeaveDate.AutoSize = true;
            this.lblLeaveDate.Location = new System.Drawing.Point(58, 302);
            this.lblLeaveDate.Name = "lblLeaveDate";
            this.lblLeaveDate.Size = new System.Drawing.Size(77, 17);
            this.lblLeaveDate.TabIndex = 17;
            this.lblLeaveDate.Text = "Leave Date:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_startdate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.txtStartDate.Location = new System.Drawing.Point(141, 269);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(116, 24);
            this.txtStartDate.TabIndex = 9;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(66, 272);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(69, 17);
            this.lblStartDate.TabIndex = 14;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(83, 333);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(52, 17);
            this.lblIsActive.TabIndex = 18;
            this.lblIsActive.Text = "Active?:";
            // 
            // cbxIsActive
            // 
            this.cbxIsActive.DataSource = this.ibisyesnoBindingSource;
            this.cbxIsActive.DisplayMember = "ibis_yesno_label";
            this.cbxIsActive.FormattingEnabled = true;
            this.cbxIsActive.Location = new System.Drawing.Point(141, 330);
            this.cbxIsActive.Name = "cbxIsActive";
            this.cbxIsActive.Size = new System.Drawing.Size(63, 25);
            this.cbxIsActive.TabIndex = 11;
            this.cbxIsActive.ValueMember = "ibis_yesno_value";
            // 
            // hesemployeeBindingSource
            // 
            this.hesemployeeBindingSource.DataMember = "hesemployee";
            this.hesemployeeBindingSource.DataSource = this.holdenengrDataSet;
            // 
            // holdenengrDataSet
            // 
            this.holdenengrDataSet.DataSetName = "holdenengrDataSet";
            this.holdenengrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hesemployeeTableAdapter
            // 
            this.hesemployeeTableAdapter.ClearBeforeFill = true;
            // 
            // ibisyesnoBindingSource
            // 
            this.ibisyesnoBindingSource.DataMember = "ibis_yesno";
            this.ibisyesnoBindingSource.DataSource = this.holdenengrDataSet;
            // 
            // ibis_yesnoTableAdapter
            // 
            this.ibis_yesnoTableAdapter.ClearBeforeFill = true;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 617);
            this.Controls.Add(this.cbxIsActive);
            this.Controls.Add(this.lblIsActive);
            this.Controls.Add(this.txtLeaveDate);
            this.Controls.Add(this.lblLeaveDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblOvertimeRate);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblPayRate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.lblEmployeeNumber);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmployee";
            this.Text = "Employee Data";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hesemployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdenengrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibisyesnoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private holdenengrDataSet holdenengrDataSet;
        private System.Windows.Forms.BindingSource hesemployeeBindingSource;
        private holdenengrDataSetTableAdapters.hesemployeeTableAdapter hesemployeeTableAdapter;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblOvertimeRate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.TextBox txtLeaveDate;
        private System.Windows.Forms.Label lblLeaveDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.ComboBox cbxIsActive;
        private System.Windows.Forms.BindingSource ibisyesnoBindingSource;
        private holdenengrDataSetTableAdapters.ibis_yesnoTableAdapter ibis_yesnoTableAdapter;
    }
}