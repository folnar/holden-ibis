namespace ibis_R1a
{
    partial class frmUpdatePerms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdatePerms));
            this.tvPermUpdForm = new System.Windows.Forms.TreeView();
            this.lblPermUpdNumTables = new System.Windows.Forms.Label();
            this.cmbPermProfileSel = new System.Windows.Forms.ComboBox();
            this.lblPermProfileSel = new System.Windows.Forms.Label();
            this.cmdAddEditPermProfiles = new System.Windows.Forms.Button();
            this.tvToAdd = new System.Windows.Forms.TreeView();
            this.btnAddPermToDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvPermUpdForm
            // 
            this.tvPermUpdForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvPermUpdForm.Location = new System.Drawing.Point(12, 94);
            this.tvPermUpdForm.Name = "tvPermUpdForm";
            this.tvPermUpdForm.Size = new System.Drawing.Size(460, 465);
            this.tvPermUpdForm.TabIndex = 3;
            this.tvPermUpdForm.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvPermUpdForm_NodeMouseClick);
            // 
            // lblPermUpdNumTables
            // 
            this.lblPermUpdNumTables.AutoSize = true;
            this.lblPermUpdNumTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermUpdNumTables.Location = new System.Drawing.Point(12, 577);
            this.lblPermUpdNumTables.Name = "lblPermUpdNumTables";
            this.lblPermUpdNumTables.Size = new System.Drawing.Size(162, 16);
            this.lblPermUpdNumTables.TabIndex = 3;
            this.lblPermUpdNumTables.Text = "0 tables retrieved from db.";
            // 
            // cmbPermProfileSel
            // 
            this.cmbPermProfileSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPermProfileSel.FormattingEnabled = true;
            this.cmbPermProfileSel.Location = new System.Drawing.Point(120, 41);
            this.cmbPermProfileSel.Name = "cmbPermProfileSel";
            this.cmbPermProfileSel.Size = new System.Drawing.Size(351, 24);
            this.cmbPermProfileSel.TabIndex = 1;
            this.cmbPermProfileSel.SelectedIndexChanged += new System.EventHandler(this.cmbPermProfileSel_SelectedIndexChanged);
            this.cmbPermProfileSel.TextChanged += new System.EventHandler(this.cmbPermProfileSel_TextChanged);
            // 
            // lblPermProfileSel
            // 
            this.lblPermProfileSel.AutoSize = true;
            this.lblPermProfileSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermProfileSel.Location = new System.Drawing.Point(25, 44);
            this.lblPermProfileSel.Name = "lblPermProfileSel";
            this.lblPermProfileSel.Size = new System.Drawing.Size(89, 16);
            this.lblPermProfileSel.TabIndex = 6;
            this.lblPermProfileSel.Text = "Profile Name:";
            this.lblPermProfileSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdAddEditPermProfiles
            // 
            this.cmdAddEditPermProfiles.Location = new System.Drawing.Point(477, 39);
            this.cmdAddEditPermProfiles.Name = "cmdAddEditPermProfiles";
            this.cmdAddEditPermProfiles.Size = new System.Drawing.Size(223, 27);
            this.cmdAddEditPermProfiles.TabIndex = 2;
            this.cmdAddEditPermProfiles.Text = "Add New Profile";
            this.cmdAddEditPermProfiles.UseVisualStyleBackColor = true;
            this.cmdAddEditPermProfiles.Click += new System.EventHandler(this.cmdAddEditPermProfiles_Click);
            // 
            // tvToAdd
            // 
            this.tvToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tvToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvToAdd.Location = new System.Drawing.Point(532, 94);
            this.tvToAdd.Name = "tvToAdd";
            this.tvToAdd.Size = new System.Drawing.Size(460, 465);
            this.tvToAdd.TabIndex = 4;
            // 
            // btnAddPermToDB
            // 
            this.btnAddPermToDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPermToDB.Location = new System.Drawing.Point(824, 572);
            this.btnAddPermToDB.Name = "btnAddPermToDB";
            this.btnAddPermToDB.Size = new System.Drawing.Size(168, 27);
            this.btnAddPermToDB.TabIndex = 5;
            this.btnAddPermToDB.UseVisualStyleBackColor = true;
            this.btnAddPermToDB.Visible = false;
            this.btnAddPermToDB.Click += new System.EventHandler(this.btnAddPermToDB_Click);
            // 
            // frmUpdatePerms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 610);
            this.Controls.Add(this.btnAddPermToDB);
            this.Controls.Add(this.tvToAdd);
            this.Controls.Add(this.cmdAddEditPermProfiles);
            this.Controls.Add(this.lblPermProfileSel);
            this.Controls.Add(this.cmbPermProfileSel);
            this.Controls.Add(this.tvPermUpdForm);
            this.Controls.Add(this.lblPermUpdNumTables);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdatePerms";
            this.Text = "Update Permissions";
            this.Load += new System.EventHandler(this.frmUpdatePerms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvPermUpdForm;
        private System.Windows.Forms.Label lblPermUpdNumTables;
        private System.Windows.Forms.ComboBox cmbPermProfileSel;
        private System.Windows.Forms.Label lblPermProfileSel;
        private System.Windows.Forms.Button cmdAddEditPermProfiles;
        private System.Windows.Forms.TreeView tvToAdd;
        private System.Windows.Forms.Button btnAddPermToDB;
    }
}