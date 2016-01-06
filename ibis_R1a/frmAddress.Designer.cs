namespace ibis_R1a
{
    partial class frmAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddress));
            this.lblState = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCommitToDB = new System.Windows.Forms.Button();
            this.ibiscbxCountry = new IbisUtils.IbisComboBox();
            this.ibiscbxState = new IbisUtils.IbisComboBox();
            this.ibiscbxAddressLabel = new IbisUtils.IbisComboBox();
            this.lblCurrentModeLabel = new System.Windows.Forms.Label();
            this.panelCompany = new System.Windows.Forms.Panel();
            this.radioMode_Search = new System.Windows.Forms.RadioButton();
            this.radioMode_AddNew = new System.Windows.Forms.RadioButton();
            this.radioMode_Edit = new System.Windows.Forms.RadioButton();
            this.panelCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(332, 157);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 18);
            this.lblState.TabIndex = 89;
            this.lblState.Text = "State:";
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(126, 182);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(93, 25);
            this.txtZip.TabIndex = 10;
            this.txtZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZip.TextChanged += new System.EventHandler(this.txtZip_TextChanged);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(85, 185);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(35, 18);
            this.lblZip.TabIndex = 87;
            this.lblZip.Text = "Zip:";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(126, 154);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(196, 25);
            this.txtCity.TabIndex = 8;
            this.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(82, 157);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(38, 18);
            this.lblCity.TabIndex = 85;
            this.lblCity.Text = "City:";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(126, 70);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(325, 25);
            this.txtAddress1.TabIndex = 5;
            this.txtAddress1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddress1.TextChanged += new System.EventHandler(this.txtAddress1_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(57, 73);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 18);
            this.lblAddress.TabIndex = 83;
            this.lblAddress.Text = "Address:";
            // 
            // lblAddressLabel
            // 
            this.lblAddressLabel.AutoSize = true;
            this.lblAddressLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLabel.Location = new System.Drawing.Point(19, 43);
            this.lblAddressLabel.Name = "lblAddressLabel";
            this.lblAddressLabel.Size = new System.Drawing.Size(102, 18);
            this.lblAddressLabel.TabIndex = 81;
            this.lblAddressLabel.Text = "Address Label:";
            // 
            // txtAddress3
            // 
            this.txtAddress3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress3.Location = new System.Drawing.Point(126, 126);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(325, 25);
            this.txtAddress3.TabIndex = 7;
            this.txtAddress3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddress3.TextChanged += new System.EventHandler(this.txtAddress3_TextChanged);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(126, 98);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(325, 25);
            this.txtAddress2.TabIndex = 6;
            this.txtAddress2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddress2.TextChanged += new System.EventHandler(this.txtAddress2_TextChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(238, 185);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(63, 18);
            this.lblCountry.TabIndex = 94;
            this.lblCountry.Text = "Country:";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::ibis_R1a.Resource1.EXIT_BUTTON_32;
            this.btnExit.Location = new System.Drawing.Point(468, 158);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnExit, "Close Address Form");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCommitToDB
            // 
            this.btnCommitToDB.Enabled = false;
            this.btnCommitToDB.Image = global::ibis_R1a.Resource1.SAVE_BTN_ADD2;
            this.btnCommitToDB.Location = new System.Drawing.Point(468, 98);
            this.btnCommitToDB.Name = "btnCommitToDB";
            this.btnCommitToDB.Size = new System.Drawing.Size(50, 50);
            this.btnCommitToDB.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnCommitToDB, "Commit this new address to the database.");
            this.btnCommitToDB.UseVisualStyleBackColor = true;
            this.btnCommitToDB.Click += new System.EventHandler(this.btnCommitToDB_Click);
            // 
            // ibiscbxCountry
            // 
            this.ibiscbxCountry.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxCountry.FormattingEnabled = true;
            this.ibiscbxCountry.IsInExistingEditMode = false;
            this.ibiscbxCountry.IsInNewStringMode = false;
            this.ibiscbxCountry.IsInSearchMode = false;
            this.ibiscbxCountry.Location = new System.Drawing.Point(307, 182);
            this.ibiscbxCountry.Name = "ibiscbxCountry";
            this.ibiscbxCountry.Size = new System.Drawing.Size(144, 26);
            this.ibiscbxCountry.srchdtxt = null;
            this.ibiscbxCountry.TabIndex = 11;
            this.ibiscbxCountry.SelectionChangeCommitted += new System.EventHandler(this.ibiscbxCountry_SelectionChangeCommitted);
            // 
            // ibiscbxState
            // 
            this.ibiscbxState.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxState.FormattingEnabled = true;
            this.ibiscbxState.IsInExistingEditMode = false;
            this.ibiscbxState.IsInNewStringMode = false;
            this.ibiscbxState.IsInSearchMode = false;
            this.ibiscbxState.Location = new System.Drawing.Point(382, 154);
            this.ibiscbxState.Name = "ibiscbxState";
            this.ibiscbxState.Size = new System.Drawing.Size(69, 26);
            this.ibiscbxState.srchdtxt = null;
            this.ibiscbxState.TabIndex = 9;
            this.ibiscbxState.SelectionChangeCommitted += new System.EventHandler(this.ibiscbxState_SelectionChangeCommitted);
            // 
            // ibiscbxAddressLabel
            // 
            this.ibiscbxAddressLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxAddressLabel.FormattingEnabled = true;
            this.ibiscbxAddressLabel.IsInExistingEditMode = false;
            this.ibiscbxAddressLabel.IsInNewStringMode = false;
            this.ibiscbxAddressLabel.IsInSearchMode = false;
            this.ibiscbxAddressLabel.Location = new System.Drawing.Point(126, 40);
            this.ibiscbxAddressLabel.Name = "ibiscbxAddressLabel";
            this.ibiscbxAddressLabel.Size = new System.Drawing.Size(325, 26);
            this.ibiscbxAddressLabel.srchdtxt = null;
            this.ibiscbxAddressLabel.TabIndex = 4;
            this.ibiscbxAddressLabel.SelectionChangeCommitted += new System.EventHandler(this.ibiscbxAddressLabel_SelectionChangeCommitted);
            this.ibiscbxAddressLabel.TextUpdate += new System.EventHandler(this.ibiscbxAddressLabel_TextUpdate);
            // 
            // lblCurrentModeLabel
            // 
            this.lblCurrentModeLabel.AutoSize = true;
            this.lblCurrentModeLabel.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentModeLabel.Location = new System.Drawing.Point(3, 9);
            this.lblCurrentModeLabel.Name = "lblCurrentModeLabel";
            this.lblCurrentModeLabel.Size = new System.Drawing.Size(120, 21);
            this.lblCurrentModeLabel.TabIndex = 95;
            this.lblCurrentModeLabel.Text = "Current Mode:";
            // 
            // panelCompany
            // 
            this.panelCompany.Controls.Add(this.radioMode_Search);
            this.panelCompany.Controls.Add(this.radioMode_AddNew);
            this.panelCompany.Controls.Add(this.radioMode_Edit);
            this.panelCompany.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCompany.Location = new System.Drawing.Point(126, 10);
            this.panelCompany.Name = "panelCompany";
            this.panelCompany.Size = new System.Drawing.Size(267, 20);
            this.panelCompany.TabIndex = 96;
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
            // frmAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 221);
            this.Controls.Add(this.panelCompany);
            this.Controls.Add(this.lblCurrentModeLabel);
            this.Controls.Add(this.btnCommitToDB);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ibiscbxCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress3);
            this.Controls.Add(this.ibiscbxState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.ibiscbxAddressLabel);
            this.Controls.Add(this.lblAddressLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddress";
            this.Load += new System.EventHandler(this.frmAddress_Load);
            this.panelCompany.ResumeLayout(false);
            this.panelCompany.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IbisUtils.IbisComboBox ibiscbxState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress;
        private IbisUtils.IbisComboBox ibiscbxAddressLabel;
        private System.Windows.Forms.Label lblAddressLabel;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.TextBox txtAddress2;
        private IbisUtils.IbisComboBox ibiscbxCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCommitToDB;
        private System.Windows.Forms.Label lblCurrentModeLabel;
        private System.Windows.Forms.Panel panelCompany;
        private System.Windows.Forms.RadioButton radioMode_Search;
        private System.Windows.Forms.RadioButton radioMode_AddNew;
        private System.Windows.Forms.RadioButton radioMode_Edit;
    }
}