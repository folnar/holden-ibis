namespace ibis_R1a
{
    partial class frmContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContact));
            this.radioMode_Search = new System.Windows.Forms.RadioButton();
            this.radioMode_Edit = new System.Windows.Forms.RadioButton();
            this.panelCompany = new System.Windows.Forms.Panel();
            this.radioMode_AddNew = new System.Windows.Forms.RadioButton();
            this.lblCurrentModeLabel = new System.Windows.Forms.Label();
            this.btnCommitToDB = new System.Windows.Forms.Button();
            this.ibiscbxMailingCountry = new IbisUtils.IbisComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMailingCountry = new System.Windows.Forms.Label();
            this.txtMailingAddress2 = new System.Windows.Forms.TextBox();
            this.txtMailingAddress3 = new System.Windows.Forms.TextBox();
            this.ibiscbxMailingState = new IbisUtils.IbisComboBox();
            this.lblMailingState = new System.Windows.Forms.Label();
            this.txtMailingZip = new System.Windows.Forms.TextBox();
            this.lblMailingZip = new System.Windows.Forms.Label();
            this.txtMailingCity = new System.Windows.Forms.TextBox();
            this.lblMailingCity = new System.Windows.Forms.Label();
            this.txtMailingAddress1 = new System.Windows.Forms.TextBox();
            this.lblMailingAddress = new System.Windows.Forms.Label();
            this.ibiscbxAccountID = new IbisUtils.IbisComboBox();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.ibiscbxStreetCountry = new IbisUtils.IbisComboBox();
            this.lblStreetCountry = new System.Windows.Forms.Label();
            this.txtStreetAddress2 = new System.Windows.Forms.TextBox();
            this.txtStreetAddress3 = new System.Windows.Forms.TextBox();
            this.ibiscbxStreetState = new IbisUtils.IbisComboBox();
            this.lblStreetState = new System.Windows.Forms.Label();
            this.txtStreetZip = new System.Windows.Forms.TextBox();
            this.lblStreetZip = new System.Windows.Forms.Label();
            this.txtStreetCity = new System.Windows.Forms.TextBox();
            this.lblStreetCity = new System.Windows.Forms.Label();
            this.txtStreetAddress1 = new System.Windows.Forms.TextBox();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.ibiscbxMailingAddressLabel = new IbisUtils.IbisComboBox();
            this.lblMailingAddressLabel = new System.Windows.Forms.Label();
            this.ibiscbxStreetAddressLabel = new IbisUtils.IbisComboBox();
            this.lblStreetAddressLabel = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtWorkPhone = new System.Windows.Forms.TextBox();
            this.txtEmailAddr = new System.Windows.Forms.TextBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblWorkPhone = new System.Windows.Forms.Label();
            this.lblMobilePhone = new System.Windows.Forms.Label();
            this.ibiscbxContactLabel = new IbisUtils.IbisComboBox();
            this.lblContactLabel = new System.Windows.Forms.Label();
            this.panelCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioMode_Search
            // 
            this.radioMode_Search.AutoSize = true;
            this.radioMode_Search.Checked = true;
            this.radioMode_Search.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMode_Search.Location = new System.Drawing.Point(3, -3);
            this.radioMode_Search.Name = "radioMode_Search";
            this.radioMode_Search.Size = new System.Drawing.Size(77, 25);
            this.radioMode_Search.TabIndex = 1;
            this.radioMode_Search.TabStop = true;
            this.radioMode_Search.Text = "Search";
            this.radioMode_Search.UseVisualStyleBackColor = true;
            this.radioMode_Search.CheckedChanged += new System.EventHandler(this.radioMode_Search_CheckedChanged);
            // 
            // radioMode_Edit
            // 
            this.radioMode_Edit.AutoSize = true;
            this.radioMode_Edit.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMode_Edit.Location = new System.Drawing.Point(86, -3);
            this.radioMode_Edit.Name = "radioMode_Edit";
            this.radioMode_Edit.Size = new System.Drawing.Size(60, 25);
            this.radioMode_Edit.TabIndex = 2;
            this.radioMode_Edit.TabStop = true;
            this.radioMode_Edit.Text = "Edit";
            this.radioMode_Edit.UseVisualStyleBackColor = true;
            this.radioMode_Edit.CheckedChanged += new System.EventHandler(this.radioMode_Edit_CheckedChanged);
            // 
            // panelCompany
            // 
            this.panelCompany.Controls.Add(this.radioMode_Search);
            this.panelCompany.Controls.Add(this.radioMode_AddNew);
            this.panelCompany.Controls.Add(this.radioMode_Edit);
            this.panelCompany.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCompany.Location = new System.Drawing.Point(135, 10);
            this.panelCompany.Name = "panelCompany";
            this.panelCompany.Size = new System.Drawing.Size(267, 20);
            this.panelCompany.TabIndex = 114;
            // 
            // radioMode_AddNew
            // 
            this.radioMode_AddNew.AutoSize = true;
            this.radioMode_AddNew.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMode_AddNew.Location = new System.Drawing.Point(152, -3);
            this.radioMode_AddNew.Name = "radioMode_AddNew";
            this.radioMode_AddNew.Size = new System.Drawing.Size(102, 25);
            this.radioMode_AddNew.TabIndex = 3;
            this.radioMode_AddNew.TabStop = true;
            this.radioMode_AddNew.Text = "Add New";
            this.radioMode_AddNew.UseVisualStyleBackColor = true;
            this.radioMode_AddNew.CheckedChanged += new System.EventHandler(this.radioMode_AddNew_CheckedChanged);
            // 
            // lblCurrentModeLabel
            // 
            this.lblCurrentModeLabel.AutoSize = true;
            this.lblCurrentModeLabel.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentModeLabel.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentModeLabel.Name = "lblCurrentModeLabel";
            this.lblCurrentModeLabel.Size = new System.Drawing.Size(120, 21);
            this.lblCurrentModeLabel.TabIndex = 113;
            this.lblCurrentModeLabel.Text = "Current Mode:";
            // 
            // btnCommitToDB
            // 
            this.btnCommitToDB.Enabled = false;
            this.btnCommitToDB.Image = global::ibis_R1a.Resource1.ADDNEW_BUTTON_32;
            this.btnCommitToDB.Location = new System.Drawing.Point(945, 40);
            this.btnCommitToDB.Name = "btnCommitToDB";
            this.btnCommitToDB.Size = new System.Drawing.Size(50, 50);
            this.btnCommitToDB.TabIndex = 105;
            this.toolTip1.SetToolTip(this.btnCommitToDB, "Commit this new address to the database.");
            this.btnCommitToDB.UseVisualStyleBackColor = true;
            this.btnCommitToDB.Click += new System.EventHandler(this.btnCommitToDB_Click);
            // 
            // ibiscbxMailingCountry
            // 
            this.ibiscbxMailingCountry.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxMailingCountry.FormattingEnabled = true;
            this.ibiscbxMailingCountry.IsInExistingEditMode = false;
            this.ibiscbxMailingCountry.IsInNewStringMode = false;
            this.ibiscbxMailingCountry.IsInSearchMode = false;
            this.ibiscbxMailingCountry.Location = new System.Drawing.Point(782, 184);
            this.ibiscbxMailingCountry.Name = "ibiscbxMailingCountry";
            this.ibiscbxMailingCountry.Size = new System.Drawing.Size(144, 26);
            this.ibiscbxMailingCountry.srchdtxt = null;
            this.ibiscbxMailingCountry.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::ibis_R1a.Resource1.EXIT_BUTTON_32;
            this.btnExit.Location = new System.Drawing.Point(945, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 106;
            this.toolTip1.SetToolTip(this.btnExit, "Close Address Form");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Image = global::ibis_R1a.Resource1.REFRESH_BUTTON_32;
            this.btnReset.Location = new System.Drawing.Point(945, 96);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 50);
            this.btnReset.TabIndex = 149;
            this.toolTip1.SetToolTip(this.btnReset, "Close Address Form");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMailingCountry
            // 
            this.lblMailingCountry.AutoSize = true;
            this.lblMailingCountry.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailingCountry.Location = new System.Drawing.Point(713, 187);
            this.lblMailingCountry.Name = "lblMailingCountry";
            this.lblMailingCountry.Size = new System.Drawing.Size(63, 18);
            this.lblMailingCountry.TabIndex = 112;
            this.lblMailingCountry.Text = "Country:";
            // 
            // txtMailingAddress2
            // 
            this.txtMailingAddress2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMailingAddress2.Location = new System.Drawing.Point(601, 100);
            this.txtMailingAddress2.Name = "txtMailingAddress2";
            this.txtMailingAddress2.Size = new System.Drawing.Size(325, 25);
            this.txtMailingAddress2.TabIndex = 14;
            // 
            // txtMailingAddress3
            // 
            this.txtMailingAddress3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMailingAddress3.Location = new System.Drawing.Point(601, 128);
            this.txtMailingAddress3.Name = "txtMailingAddress3";
            this.txtMailingAddress3.Size = new System.Drawing.Size(325, 25);
            this.txtMailingAddress3.TabIndex = 15;
            // 
            // ibiscbxMailingState
            // 
            this.ibiscbxMailingState.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxMailingState.FormattingEnabled = true;
            this.ibiscbxMailingState.IsInExistingEditMode = false;
            this.ibiscbxMailingState.IsInNewStringMode = false;
            this.ibiscbxMailingState.IsInSearchMode = false;
            this.ibiscbxMailingState.Location = new System.Drawing.Point(857, 156);
            this.ibiscbxMailingState.Name = "ibiscbxMailingState";
            this.ibiscbxMailingState.Size = new System.Drawing.Size(69, 26);
            this.ibiscbxMailingState.srchdtxt = null;
            this.ibiscbxMailingState.TabIndex = 17;
            // 
            // lblMailingState
            // 
            this.lblMailingState.AutoSize = true;
            this.lblMailingState.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailingState.Location = new System.Drawing.Point(807, 159);
            this.lblMailingState.Name = "lblMailingState";
            this.lblMailingState.Size = new System.Drawing.Size(44, 18);
            this.lblMailingState.TabIndex = 111;
            this.lblMailingState.Text = "State:";
            // 
            // txtMailingZip
            // 
            this.txtMailingZip.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMailingZip.Location = new System.Drawing.Point(601, 184);
            this.txtMailingZip.Name = "txtMailingZip";
            this.txtMailingZip.Size = new System.Drawing.Size(93, 25);
            this.txtMailingZip.TabIndex = 18;
            // 
            // lblMailingZip
            // 
            this.lblMailingZip.AutoSize = true;
            this.lblMailingZip.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailingZip.Location = new System.Drawing.Point(560, 187);
            this.lblMailingZip.Name = "lblMailingZip";
            this.lblMailingZip.Size = new System.Drawing.Size(35, 18);
            this.lblMailingZip.TabIndex = 110;
            this.lblMailingZip.Text = "Zip:";
            // 
            // txtMailingCity
            // 
            this.txtMailingCity.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMailingCity.Location = new System.Drawing.Point(601, 156);
            this.txtMailingCity.Name = "txtMailingCity";
            this.txtMailingCity.Size = new System.Drawing.Size(196, 25);
            this.txtMailingCity.TabIndex = 16;
            // 
            // lblMailingCity
            // 
            this.lblMailingCity.AutoSize = true;
            this.lblMailingCity.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailingCity.Location = new System.Drawing.Point(557, 159);
            this.lblMailingCity.Name = "lblMailingCity";
            this.lblMailingCity.Size = new System.Drawing.Size(38, 18);
            this.lblMailingCity.TabIndex = 109;
            this.lblMailingCity.Text = "City:";
            // 
            // txtMailingAddress1
            // 
            this.txtMailingAddress1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMailingAddress1.Location = new System.Drawing.Point(601, 72);
            this.txtMailingAddress1.Name = "txtMailingAddress1";
            this.txtMailingAddress1.Size = new System.Drawing.Size(325, 25);
            this.txtMailingAddress1.TabIndex = 13;
            // 
            // lblMailingAddress
            // 
            this.lblMailingAddress.AutoSize = true;
            this.lblMailingAddress.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailingAddress.Location = new System.Drawing.Point(532, 75);
            this.lblMailingAddress.Name = "lblMailingAddress";
            this.lblMailingAddress.Size = new System.Drawing.Size(63, 18);
            this.lblMailingAddress.TabIndex = 108;
            this.lblMailingAddress.Text = "Address:";
            // 
            // ibiscbxAccountID
            // 
            this.ibiscbxAccountID.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxAccountID.FormattingEnabled = true;
            this.ibiscbxAccountID.IsInExistingEditMode = false;
            this.ibiscbxAccountID.IsInNewStringMode = false;
            this.ibiscbxAccountID.IsInSearchMode = false;
            this.ibiscbxAccountID.Location = new System.Drawing.Point(135, 73);
            this.ibiscbxAccountID.Name = "ibiscbxAccountID";
            this.ibiscbxAccountID.Size = new System.Drawing.Size(325, 26);
            this.ibiscbxAccountID.srchdtxt = null;
            this.ibiscbxAccountID.TabIndex = 4;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountID.Location = new System.Drawing.Point(63, 76);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(66, 18);
            this.lblAccountID.TabIndex = 107;
            this.lblAccountID.Text = "Account:";
            // 
            // ibiscbxStreetCountry
            // 
            this.ibiscbxStreetCountry.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxStreetCountry.FormattingEnabled = true;
            this.ibiscbxStreetCountry.IsInExistingEditMode = false;
            this.ibiscbxStreetCountry.IsInNewStringMode = false;
            this.ibiscbxStreetCountry.IsInSearchMode = false;
            this.ibiscbxStreetCountry.Location = new System.Drawing.Point(782, 360);
            this.ibiscbxStreetCountry.Name = "ibiscbxStreetCountry";
            this.ibiscbxStreetCountry.Size = new System.Drawing.Size(144, 26);
            this.ibiscbxStreetCountry.srchdtxt = null;
            this.ibiscbxStreetCountry.TabIndex = 27;
            // 
            // lblStreetCountry
            // 
            this.lblStreetCountry.AutoSize = true;
            this.lblStreetCountry.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetCountry.Location = new System.Drawing.Point(713, 363);
            this.lblStreetCountry.Name = "lblStreetCountry";
            this.lblStreetCountry.Size = new System.Drawing.Size(63, 18);
            this.lblStreetCountry.TabIndex = 128;
            this.lblStreetCountry.Text = "Country:";
            // 
            // txtStreetAddress2
            // 
            this.txtStreetAddress2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetAddress2.Location = new System.Drawing.Point(601, 276);
            this.txtStreetAddress2.Name = "txtStreetAddress2";
            this.txtStreetAddress2.Size = new System.Drawing.Size(325, 25);
            this.txtStreetAddress2.TabIndex = 22;
            // 
            // txtStreetAddress3
            // 
            this.txtStreetAddress3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetAddress3.Location = new System.Drawing.Point(601, 304);
            this.txtStreetAddress3.Name = "txtStreetAddress3";
            this.txtStreetAddress3.Size = new System.Drawing.Size(325, 25);
            this.txtStreetAddress3.TabIndex = 23;
            // 
            // ibiscbxStreetState
            // 
            this.ibiscbxStreetState.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxStreetState.FormattingEnabled = true;
            this.ibiscbxStreetState.IsInExistingEditMode = false;
            this.ibiscbxStreetState.IsInNewStringMode = false;
            this.ibiscbxStreetState.IsInSearchMode = false;
            this.ibiscbxStreetState.Location = new System.Drawing.Point(857, 332);
            this.ibiscbxStreetState.Name = "ibiscbxStreetState";
            this.ibiscbxStreetState.Size = new System.Drawing.Size(69, 26);
            this.ibiscbxStreetState.srchdtxt = null;
            this.ibiscbxStreetState.TabIndex = 25;
            // 
            // lblStreetState
            // 
            this.lblStreetState.AutoSize = true;
            this.lblStreetState.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetState.Location = new System.Drawing.Point(807, 335);
            this.lblStreetState.Name = "lblStreetState";
            this.lblStreetState.Size = new System.Drawing.Size(44, 18);
            this.lblStreetState.TabIndex = 127;
            this.lblStreetState.Text = "State:";
            // 
            // txtStreetZip
            // 
            this.txtStreetZip.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetZip.Location = new System.Drawing.Point(601, 360);
            this.txtStreetZip.Name = "txtStreetZip";
            this.txtStreetZip.Size = new System.Drawing.Size(93, 25);
            this.txtStreetZip.TabIndex = 26;
            // 
            // lblStreetZip
            // 
            this.lblStreetZip.AutoSize = true;
            this.lblStreetZip.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetZip.Location = new System.Drawing.Point(560, 363);
            this.lblStreetZip.Name = "lblStreetZip";
            this.lblStreetZip.Size = new System.Drawing.Size(35, 18);
            this.lblStreetZip.TabIndex = 126;
            this.lblStreetZip.Text = "Zip:";
            // 
            // txtStreetCity
            // 
            this.txtStreetCity.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetCity.Location = new System.Drawing.Point(601, 332);
            this.txtStreetCity.Name = "txtStreetCity";
            this.txtStreetCity.Size = new System.Drawing.Size(196, 25);
            this.txtStreetCity.TabIndex = 24;
            // 
            // lblStreetCity
            // 
            this.lblStreetCity.AutoSize = true;
            this.lblStreetCity.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetCity.Location = new System.Drawing.Point(557, 335);
            this.lblStreetCity.Name = "lblStreetCity";
            this.lblStreetCity.Size = new System.Drawing.Size(38, 18);
            this.lblStreetCity.TabIndex = 125;
            this.lblStreetCity.Text = "City:";
            // 
            // txtStreetAddress1
            // 
            this.txtStreetAddress1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetAddress1.Location = new System.Drawing.Point(601, 248);
            this.txtStreetAddress1.Name = "txtStreetAddress1";
            this.txtStreetAddress1.Size = new System.Drawing.Size(325, 25);
            this.txtStreetAddress1.TabIndex = 21;
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress.Location = new System.Drawing.Point(532, 251);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(63, 18);
            this.lblStreetAddress.TabIndex = 124;
            this.lblStreetAddress.Text = "Address:";
            // 
            // ibiscbxMailingAddressLabel
            // 
            this.ibiscbxMailingAddressLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxMailingAddressLabel.FormattingEnabled = true;
            this.ibiscbxMailingAddressLabel.IsInExistingEditMode = false;
            this.ibiscbxMailingAddressLabel.IsInNewStringMode = false;
            this.ibiscbxMailingAddressLabel.IsInSearchMode = false;
            this.ibiscbxMailingAddressLabel.Location = new System.Drawing.Point(601, 40);
            this.ibiscbxMailingAddressLabel.Name = "ibiscbxMailingAddressLabel";
            this.ibiscbxMailingAddressLabel.Size = new System.Drawing.Size(325, 26);
            this.ibiscbxMailingAddressLabel.srchdtxt = null;
            this.ibiscbxMailingAddressLabel.TabIndex = 12;
            this.ibiscbxMailingAddressLabel.SelectionChangeCommitted += new System.EventHandler(this.ibiscbxMailingAddressLabel_SelectionChangeCommitted);
            // 
            // lblMailingAddressLabel
            // 
            this.lblMailingAddressLabel.AutoSize = true;
            this.lblMailingAddressLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailingAddressLabel.Location = new System.Drawing.Point(481, 43);
            this.lblMailingAddressLabel.Name = "lblMailingAddressLabel";
            this.lblMailingAddressLabel.Size = new System.Drawing.Size(114, 18);
            this.lblMailingAddressLabel.TabIndex = 130;
            this.lblMailingAddressLabel.Text = "Mailing Address:";
            // 
            // ibiscbxStreetAddressLabel
            // 
            this.ibiscbxStreetAddressLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxStreetAddressLabel.FormattingEnabled = true;
            this.ibiscbxStreetAddressLabel.IsInExistingEditMode = false;
            this.ibiscbxStreetAddressLabel.IsInNewStringMode = false;
            this.ibiscbxStreetAddressLabel.IsInSearchMode = false;
            this.ibiscbxStreetAddressLabel.Location = new System.Drawing.Point(601, 216);
            this.ibiscbxStreetAddressLabel.Name = "ibiscbxStreetAddressLabel";
            this.ibiscbxStreetAddressLabel.Size = new System.Drawing.Size(325, 26);
            this.ibiscbxStreetAddressLabel.srchdtxt = null;
            this.ibiscbxStreetAddressLabel.TabIndex = 20;
            this.ibiscbxStreetAddressLabel.SelectionChangeCommitted += new System.EventHandler(this.ibiscbxStreetAddressLabel_SelectionChangeCommitted);
            // 
            // lblStreetAddressLabel
            // 
            this.lblStreetAddressLabel.AutoSize = true;
            this.lblStreetAddressLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddressLabel.Location = new System.Drawing.Point(491, 219);
            this.lblStreetAddressLabel.Name = "lblStreetAddressLabel";
            this.lblStreetAddressLabel.Size = new System.Drawing.Size(104, 18);
            this.lblStreetAddressLabel.TabIndex = 132;
            this.lblStreetAddressLabel.Text = "Street Address:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(135, 105);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(146, 25);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(135, 136);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(146, 25);
            this.txtMiddleName.TabIndex = 6;
            this.txtMiddleName.TextChanged += new System.EventHandler(this.txtMiddleName_TextChanged);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(135, 198);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(325, 25);
            this.txtDepartment.TabIndex = 8;
            this.txtDepartment.TextChanged += new System.EventHandler(this.txtDepartment_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(135, 167);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(227, 25);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkPhone.Location = new System.Drawing.Point(135, 260);
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(325, 25);
            this.txtWorkPhone.TabIndex = 10;
            this.txtWorkPhone.TextChanged += new System.EventHandler(this.txtWorkPhone_TextChanged);
            // 
            // txtEmailAddr
            // 
            this.txtEmailAddr.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddr.Location = new System.Drawing.Point(135, 229);
            this.txtEmailAddr.Name = "txtEmailAddr";
            this.txtEmailAddr.Size = new System.Drawing.Size(325, 25);
            this.txtEmailAddr.TabIndex = 9;
            this.txtEmailAddr.TextChanged += new System.EventHandler(this.txtEmailAddr_TextChanged);
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobilePhone.Location = new System.Drawing.Point(135, 291);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(325, 25);
            this.txtMobilePhone.TabIndex = 11;
            this.txtMobilePhone.TextChanged += new System.EventHandler(this.txtMobilePhone_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(48, 170);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(81, 18);
            this.lblLastName.TabIndex = 140;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(46, 108);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 18);
            this.lblFirstName.TabIndex = 141;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(31, 139);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(98, 18);
            this.lblMiddleName.TabIndex = 142;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(41, 201);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(88, 18);
            this.lblDepartment.TabIndex = 143;
            this.lblDepartment.Text = "Department:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(24, 232);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(105, 18);
            this.lblEmailAddress.TabIndex = 144;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkPhone.Location = new System.Drawing.Point(38, 263);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(91, 18);
            this.lblWorkPhone.TabIndex = 145;
            this.lblWorkPhone.Text = "Work Phone:";
            // 
            // lblMobilePhone
            // 
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobilePhone.Location = new System.Drawing.Point(29, 294);
            this.lblMobilePhone.Name = "lblMobilePhone";
            this.lblMobilePhone.Size = new System.Drawing.Size(100, 18);
            this.lblMobilePhone.TabIndex = 146;
            this.lblMobilePhone.Text = "Mobile Phone:";
            // 
            // ibiscbxContactLabel
            // 
            this.ibiscbxContactLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxContactLabel.FormattingEnabled = true;
            this.ibiscbxContactLabel.IsInExistingEditMode = false;
            this.ibiscbxContactLabel.IsInNewStringMode = false;
            this.ibiscbxContactLabel.IsInSearchMode = false;
            this.ibiscbxContactLabel.Location = new System.Drawing.Point(135, 40);
            this.ibiscbxContactLabel.Name = "ibiscbxContactLabel";
            this.ibiscbxContactLabel.Size = new System.Drawing.Size(325, 26);
            this.ibiscbxContactLabel.srchdtxt = null;
            this.ibiscbxContactLabel.TabIndex = 4;
            this.ibiscbxContactLabel.SelectionChangeCommitted += new System.EventHandler(this.ibiscbxContactLabel_SelectionChangeCommitted);
            // 
            // lblContactLabel
            // 
            this.lblContactLabel.AutoSize = true;
            this.lblContactLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactLabel.Location = new System.Drawing.Point(67, 43);
            this.lblContactLabel.Name = "lblContactLabel";
            this.lblContactLabel.Size = new System.Drawing.Size(62, 18);
            this.lblContactLabel.TabIndex = 148;
            this.lblContactLabel.Text = "Contact:";
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 412);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.ibiscbxContactLabel);
            this.Controls.Add(this.lblContactLabel);
            this.Controls.Add(this.lblMobilePhone);
            this.Controls.Add(this.lblWorkPhone);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtMobilePhone);
            this.Controls.Add(this.txtWorkPhone);
            this.Controls.Add(this.txtEmailAddr);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.ibiscbxStreetAddressLabel);
            this.Controls.Add(this.lblStreetAddressLabel);
            this.Controls.Add(this.ibiscbxMailingAddressLabel);
            this.Controls.Add(this.lblMailingAddressLabel);
            this.Controls.Add(this.ibiscbxStreetCountry);
            this.Controls.Add(this.lblStreetCountry);
            this.Controls.Add(this.txtStreetAddress2);
            this.Controls.Add(this.txtStreetAddress3);
            this.Controls.Add(this.ibiscbxStreetState);
            this.Controls.Add(this.lblStreetState);
            this.Controls.Add(this.txtStreetZip);
            this.Controls.Add(this.lblStreetZip);
            this.Controls.Add(this.txtStreetCity);
            this.Controls.Add(this.lblStreetCity);
            this.Controls.Add(this.txtStreetAddress1);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.panelCompany);
            this.Controls.Add(this.lblCurrentModeLabel);
            this.Controls.Add(this.btnCommitToDB);
            this.Controls.Add(this.ibiscbxMailingCountry);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMailingCountry);
            this.Controls.Add(this.txtMailingAddress2);
            this.Controls.Add(this.txtMailingAddress3);
            this.Controls.Add(this.ibiscbxMailingState);
            this.Controls.Add(this.lblMailingState);
            this.Controls.Add(this.txtMailingZip);
            this.Controls.Add(this.lblMailingZip);
            this.Controls.Add(this.txtMailingCity);
            this.Controls.Add(this.lblMailingCity);
            this.Controls.Add(this.txtMailingAddress1);
            this.Controls.Add(this.lblMailingAddress);
            this.Controls.Add(this.ibiscbxAccountID);
            this.Controls.Add(this.lblAccountID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContact";
            this.Text = "Contact Form";
            this.Load += new System.EventHandler(this.frmContact_Load);
            this.panelCompany.ResumeLayout(false);
            this.panelCompany.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioMode_Search;
        private System.Windows.Forms.RadioButton radioMode_Edit;
        private System.Windows.Forms.Panel panelCompany;
        private System.Windows.Forms.RadioButton radioMode_AddNew;
        private System.Windows.Forms.Label lblCurrentModeLabel;
        private System.Windows.Forms.Button btnCommitToDB;
        private System.Windows.Forms.ToolTip toolTip1;
        private IbisUtils.IbisComboBox ibiscbxMailingCountry;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMailingCountry;
        private System.Windows.Forms.TextBox txtMailingAddress2;
        private System.Windows.Forms.TextBox txtMailingAddress3;
        private IbisUtils.IbisComboBox ibiscbxMailingState;
        private System.Windows.Forms.Label lblMailingState;
        private System.Windows.Forms.TextBox txtMailingZip;
        private System.Windows.Forms.Label lblMailingZip;
        private System.Windows.Forms.TextBox txtMailingCity;
        private System.Windows.Forms.Label lblMailingCity;
        private System.Windows.Forms.TextBox txtMailingAddress1;
        private System.Windows.Forms.Label lblMailingAddress;
        private IbisUtils.IbisComboBox ibiscbxAccountID;
        private System.Windows.Forms.Label lblAccountID;
        private IbisUtils.IbisComboBox ibiscbxStreetCountry;
        private System.Windows.Forms.Label lblStreetCountry;
        private System.Windows.Forms.TextBox txtStreetAddress2;
        private System.Windows.Forms.TextBox txtStreetAddress3;
        private IbisUtils.IbisComboBox ibiscbxStreetState;
        private System.Windows.Forms.Label lblStreetState;
        private System.Windows.Forms.TextBox txtStreetZip;
        private System.Windows.Forms.Label lblStreetZip;
        private System.Windows.Forms.TextBox txtStreetCity;
        private System.Windows.Forms.Label lblStreetCity;
        private System.Windows.Forms.TextBox txtStreetAddress1;
        private System.Windows.Forms.Label lblStreetAddress;
        private IbisUtils.IbisComboBox ibiscbxMailingAddressLabel;
        private System.Windows.Forms.Label lblMailingAddressLabel;
        private IbisUtils.IbisComboBox ibiscbxStreetAddressLabel;
        private System.Windows.Forms.Label lblStreetAddressLabel;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtWorkPhone;
        private System.Windows.Forms.TextBox txtEmailAddr;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblWorkPhone;
        private System.Windows.Forms.Label lblMobilePhone;
        private IbisUtils.IbisComboBox ibiscbxContactLabel;
        private System.Windows.Forms.Label lblContactLabel;
        private System.Windows.Forms.Button btnReset;
    }
}