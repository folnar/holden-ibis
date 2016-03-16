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
            this.hesemployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.holdenengrDataSet = new ibis_R1a.holdenengrDataSet();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtOTRate = new System.Windows.Forms.TextBox();
            this.lblOvertimeRate = new System.Windows.Forms.Label();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.txtLeaveDate = new System.Windows.Forms.TextBox();
            this.lblLeaveDate = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.cbxIsActive = new System.Windows.Forms.ComboBox();
            this.ibisyesnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hesemployeeTableAdapter = new ibis_R1a.holdenengrDataSetTableAdapters.hesemployeeTableAdapter();
            this.ibis_yesnoTableAdapter = new ibis_R1a.holdenengrDataSetTableAdapters.ibis_yesnoTableAdapter();
            this.lblPermProfile = new System.Windows.Forms.Label();
            this.cbxPermProfile = new System.Windows.Forms.ComboBox();
            this.ibispermsforDDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ibis_perms_forDDTableAdapter = new ibis_R1a.holdenengrDataSetTableAdapters.ibis_perms_forDDTableAdapter();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.ibisstateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblState = new System.Windows.Forms.Label();
            this.ibis_stateTableAdapter = new ibis_R1a.holdenengrDataSetTableAdapters.ibis_stateTableAdapter();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.lblMobilePhone = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtHoldenLocation = new System.Windows.Forms.TextBox();
            this.lblHoldenLocation = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCommitToDB = new System.Windows.Forms.Button();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tstxtLastNameSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.hesemployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdenengrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibisyesnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibispermsforDDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibisstateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(60, 40);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 17);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_lastname", true));
            this.txtLastName.Location = new System.Drawing.Point(141, 37);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(166, 24);
            this.txtLastName.TabIndex = 1;
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
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(60, 100);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(43, 70);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(92, 17);
            this.lblMiddleName.TabIndex = 3;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_middlename", true));
            this.txtMiddleName.Location = new System.Drawing.Point(141, 67);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(166, 24);
            this.txtMiddleName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_firstname", true));
            this.txtFirstName.Location = new System.Drawing.Point(141, 97);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(166, 24);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(12, 130);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(124, 17);
            this.lblEmployeeNumber.TabIndex = 4;
            this.lblEmployeeNumber.Text = "Employee Number:";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_hesnumber", true));
            this.txtEmployeeNumber.Location = new System.Drawing.Point(141, 127);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(63, 24);
            this.txtEmployeeNumber.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_password", true));
            this.txtPassword.Location = new System.Drawing.Point(141, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(166, 24);
            this.txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(68, 190);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 17);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_username", true));
            this.txtUsername.Location = new System.Drawing.Point(141, 157);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(166, 24);
            this.txtUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(66, 160);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(69, 17);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username:";
            // 
            // txtOTRate
            // 
            this.txtOTRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_otrate", true));
            this.txtOTRate.Location = new System.Drawing.Point(141, 247);
            this.txtOTRate.Name = "txtOTRate";
            this.txtOTRate.Size = new System.Drawing.Size(93, 24);
            this.txtOTRate.TabIndex = 8;
            // 
            // lblOvertimeRate
            // 
            this.lblOvertimeRate.AutoSize = true;
            this.lblOvertimeRate.Location = new System.Drawing.Point(40, 250);
            this.lblOvertimeRate.Name = "lblOvertimeRate";
            this.lblOvertimeRate.Size = new System.Drawing.Size(95, 17);
            this.lblOvertimeRate.TabIndex = 13;
            this.lblOvertimeRate.Text = "Overtime Rate:";
            // 
            // txtPayRate
            // 
            this.txtPayRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_payrate", true));
            this.txtPayRate.Location = new System.Drawing.Point(141, 217);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(93, 24);
            this.txtPayRate.TabIndex = 7;
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(48, 220);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(87, 17);
            this.lblPayRate.TabIndex = 10;
            this.lblPayRate.Text = "Hourly Wage:";
            // 
            // txtLeaveDate
            // 
            this.txtLeaveDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_leavedate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.txtLeaveDate.Location = new System.Drawing.Point(141, 307);
            this.txtLeaveDate.Name = "txtLeaveDate";
            this.txtLeaveDate.Size = new System.Drawing.Size(116, 24);
            this.txtLeaveDate.TabIndex = 10;
            // 
            // lblLeaveDate
            // 
            this.lblLeaveDate.AutoSize = true;
            this.lblLeaveDate.Location = new System.Drawing.Point(58, 310);
            this.lblLeaveDate.Name = "lblLeaveDate";
            this.lblLeaveDate.Size = new System.Drawing.Size(77, 17);
            this.lblLeaveDate.TabIndex = 17;
            this.lblLeaveDate.Text = "Leave Date:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_startdate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.txtStartDate.Location = new System.Drawing.Point(141, 277);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(116, 24);
            this.txtStartDate.TabIndex = 9;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(66, 280);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(69, 17);
            this.lblStartDate.TabIndex = 14;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(83, 341);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(52, 17);
            this.lblIsActive.TabIndex = 18;
            this.lblIsActive.Text = "Active?:";
            // 
            // cbxIsActive
            // 
            this.cbxIsActive.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hesemployeeBindingSource, "hesemployee_active", true));
            this.cbxIsActive.DataSource = this.ibisyesnoBindingSource;
            this.cbxIsActive.DisplayMember = "ibis_yesno_label";
            this.cbxIsActive.FormattingEnabled = true;
            this.cbxIsActive.Location = new System.Drawing.Point(141, 338);
            this.cbxIsActive.Name = "cbxIsActive";
            this.cbxIsActive.Size = new System.Drawing.Size(63, 25);
            this.cbxIsActive.TabIndex = 11;
            this.cbxIsActive.ValueMember = "ibis_yesno_value";
            // 
            // ibisyesnoBindingSource
            // 
            this.ibisyesnoBindingSource.DataMember = "ibis_yesno";
            this.ibisyesnoBindingSource.DataSource = this.holdenengrDataSet;
            // 
            // hesemployeeTableAdapter
            // 
            this.hesemployeeTableAdapter.ClearBeforeFill = true;
            // 
            // ibis_yesnoTableAdapter
            // 
            this.ibis_yesnoTableAdapter.ClearBeforeFill = true;
            // 
            // lblPermProfile
            // 
            this.lblPermProfile.AutoSize = true;
            this.lblPermProfile.Location = new System.Drawing.Point(313, 40);
            this.lblPermProfile.Name = "lblPermProfile";
            this.lblPermProfile.Size = new System.Drawing.Size(120, 17);
            this.lblPermProfile.TabIndex = 19;
            this.lblPermProfile.Text = "Permissions Profile:";
            // 
            // cbxPermProfile
            // 
            this.cbxPermProfile.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hesemployeeBindingSource, "hesemployee_permprofile", true));
            this.cbxPermProfile.DataSource = this.ibispermsforDDBindingSource;
            this.cbxPermProfile.DisplayMember = "ibis_perms_profilename";
            this.cbxPermProfile.FormattingEnabled = true;
            this.cbxPermProfile.Location = new System.Drawing.Point(439, 37);
            this.cbxPermProfile.Name = "cbxPermProfile";
            this.cbxPermProfile.Size = new System.Drawing.Size(166, 25);
            this.cbxPermProfile.TabIndex = 12;
            this.cbxPermProfile.ValueMember = "ibis_perms_id";
            // 
            // ibispermsforDDBindingSource
            // 
            this.ibispermsforDDBindingSource.DataMember = "ibis_perms_forDD";
            this.ibispermsforDDBindingSource.DataSource = this.holdenengrDataSet;
            // 
            // ibis_perms_forDDTableAdapter
            // 
            this.ibis_perms_forDDTableAdapter.ClearBeforeFill = true;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_city", true));
            this.txtCity.Location = new System.Drawing.Point(439, 127);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(166, 24);
            this.txtCity.TabIndex = 15;
            // 
            // txtAddress2
            // 
            this.txtAddress2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_address2", true));
            this.txtAddress2.Location = new System.Drawing.Point(439, 97);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(166, 24);
            this.txtAddress2.TabIndex = 14;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(387, 130);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(46, 17);
            this.lblTown.TabIndex = 23;
            this.lblTown.Text = "Town:";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_address", true));
            this.txtAddress.Location = new System.Drawing.Point(439, 67);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(166, 24);
            this.txtAddress.TabIndex = 13;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(375, 70);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 17);
            this.lblAddress.TabIndex = 20;
            this.lblAddress.Text = "Address:";
            // 
            // cbxState
            // 
            this.cbxState.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hesemployeeBindingSource, "hesemployee_state", true));
            this.cbxState.DataSource = this.ibisstateBindingSource;
            this.cbxState.DisplayMember = "state_abbr";
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Location = new System.Drawing.Point(439, 157);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(63, 25);
            this.cbxState.TabIndex = 16;
            this.cbxState.ValueMember = "state_id";
            // 
            // ibisstateBindingSource
            // 
            this.ibisstateBindingSource.DataMember = "ibis_state";
            this.ibisstateBindingSource.DataSource = this.holdenengrDataSet;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(395, 160);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 17);
            this.lblState.TabIndex = 25;
            this.lblState.Text = "State:";
            // 
            // ibis_stateTableAdapter
            // 
            this.ibis_stateTableAdapter.ClearBeforeFill = true;
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_mobilephone", true));
            this.txtMobilePhone.Location = new System.Drawing.Point(439, 247);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(127, 24);
            this.txtMobilePhone.TabIndex = 19;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_homephone", true));
            this.txtHomePhone.Location = new System.Drawing.Point(439, 217);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(127, 24);
            this.txtHomePhone.TabIndex = 18;
            // 
            // lblMobilePhone
            // 
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.Location = new System.Drawing.Point(341, 250);
            this.lblMobilePhone.Name = "lblMobilePhone";
            this.lblMobilePhone.Size = new System.Drawing.Size(92, 17);
            this.lblMobilePhone.TabIndex = 30;
            this.lblMobilePhone.Text = "Mobile Phone:";
            // 
            // txtZipCode
            // 
            this.txtZipCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_zip", true));
            this.txtZipCode.Location = new System.Drawing.Point(439, 187);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(91, 24);
            this.txtZipCode.TabIndex = 17;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(365, 190);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(68, 17);
            this.lblZipCode.TabIndex = 29;
            this.lblZipCode.Text = "Zip Code:";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_jobtitle", true));
            this.txtJobTitle.Location = new System.Drawing.Point(439, 307);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(166, 24);
            this.txtJobTitle.TabIndex = 21;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(372, 310);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(61, 17);
            this.lblJobTitle.TabIndex = 35;
            this.lblJobTitle.Text = "Job Title:";
            // 
            // txtHoldenLocation
            // 
            this.txtHoldenLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesemployeeBindingSource, "hesemployee_heslocation", true));
            this.txtHoldenLocation.Location = new System.Drawing.Point(439, 277);
            this.txtHoldenLocation.Name = "txtHoldenLocation";
            this.txtHoldenLocation.Size = new System.Drawing.Size(166, 24);
            this.txtHoldenLocation.TabIndex = 20;
            // 
            // lblHoldenLocation
            // 
            this.lblHoldenLocation.AutoSize = true;
            this.lblHoldenLocation.Location = new System.Drawing.Point(324, 280);
            this.lblHoldenLocation.Name = "lblHoldenLocation";
            this.lblHoldenLocation.Size = new System.Drawing.Size(109, 17);
            this.lblHoldenLocation.TabIndex = 34;
            this.lblHoldenLocation.Text = "Holden Location:";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(345, 220);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(88, 17);
            this.lblHomePhone.TabIndex = 36;
            this.lblHomePhone.Text = "Home Phone:";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.hesemployeeBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.tstxtLastNameSearch,
            this.tsbtnSearch});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(685, 25);
            this.bindingNavigator1.TabIndex = 37;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::ibis_R1a.Resource1.EXIT_BUTTON_32;
            this.btnExit.Location = new System.Drawing.Point(623, 93);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 23;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCommitToDB
            // 
            this.btnCommitToDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommitToDB.Image = global::ibis_R1a.Resource1.SAVE_BTN_ADD2;
            this.btnCommitToDB.Location = new System.Drawing.Point(623, 37);
            this.btnCommitToDB.Name = "btnCommitToDB";
            this.btnCommitToDB.Size = new System.Drawing.Size(50, 50);
            this.btnCommitToDB.TabIndex = 22;
            this.btnCommitToDB.UseVisualStyleBackColor = true;
            this.btnCommitToDB.Click += new System.EventHandler(this.btnCommitToDB_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tstxtLastNameSearch
            // 
            this.tstxtLastNameSearch.Name = "tstxtLastNameSearch";
            this.tstxtLastNameSearch.Size = new System.Drawing.Size(100, 25);
            this.tstxtLastNameSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tstxtLastNameSearch_KeyPress);
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearch.Image")));
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSearch.Text = "toolStripButton1";
            this.tsbtnSearch.Click += new System.EventHandler(this.tsbtnSearch_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 386);
            this.Controls.Add(this.btnCommitToDB);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.lblHomePhone);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.txtHoldenLocation);
            this.Controls.Add(this.lblHoldenLocation);
            this.Controls.Add(this.txtMobilePhone);
            this.Controls.Add(this.txtHomePhone);
            this.Controls.Add(this.lblMobilePhone);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.cbxPermProfile);
            this.Controls.Add(this.lblPermProfile);
            this.Controls.Add(this.cbxIsActive);
            this.Controls.Add(this.lblIsActive);
            this.Controls.Add(this.txtLeaveDate);
            this.Controls.Add(this.lblLeaveDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtOTRate);
            this.Controls.Add(this.lblOvertimeRate);
            this.Controls.Add(this.txtPayRate);
            this.Controls.Add(this.lblPayRate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
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
            ((System.ComponentModel.ISupportInitialize)(this.ibispermsforDDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibisstateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtOTRate;
        private System.Windows.Forms.Label lblOvertimeRate;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.TextBox txtLeaveDate;
        private System.Windows.Forms.Label lblLeaveDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.ComboBox cbxIsActive;
        private System.Windows.Forms.BindingSource ibisyesnoBindingSource;
        private holdenengrDataSetTableAdapters.ibis_yesnoTableAdapter ibis_yesnoTableAdapter;
        private System.Windows.Forms.Label lblPermProfile;
        private System.Windows.Forms.ComboBox cbxPermProfile;
        private System.Windows.Forms.BindingSource ibispermsforDDBindingSource;
        private holdenengrDataSetTableAdapters.ibis_perms_forDDTableAdapter ibis_perms_forDDTableAdapter;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.BindingSource ibisstateBindingSource;
        private holdenengrDataSetTableAdapters.ibis_stateTableAdapter ibis_stateTableAdapter;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.Label lblMobilePhone;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox txtHoldenLocation;
        private System.Windows.Forms.Label lblHoldenLocation;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCommitToDB;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripTextBox tstxtLastNameSearch;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
    }
}