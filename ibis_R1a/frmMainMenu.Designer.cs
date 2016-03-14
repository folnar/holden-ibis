namespace ibis_R1a
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.cmdAdmin_UpdatePerms = new System.Windows.Forms.Button();
            this.cmdExitfromMM = new System.Windows.Forms.Button();
            this.cmdJobInfoSheet = new System.Windows.Forms.Button();
            this.btnAddressForm = new System.Windows.Forms.Button();
            this.btnContactForm = new System.Windows.Forms.Button();
            this.btnBudgetForm = new System.Windows.Forms.Button();
            this.btnManageEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAdmin_UpdatePerms
            // 
            resources.ApplyResources(this.cmdAdmin_UpdatePerms, "cmdAdmin_UpdatePerms");
            this.cmdAdmin_UpdatePerms.Name = "cmdAdmin_UpdatePerms";
            this.cmdAdmin_UpdatePerms.UseVisualStyleBackColor = true;
            this.cmdAdmin_UpdatePerms.Click += new System.EventHandler(this.cmdAdmin_UpdatePerms_Click);
            // 
            // cmdExitfromMM
            // 
            resources.ApplyResources(this.cmdExitfromMM, "cmdExitfromMM");
            this.cmdExitfromMM.Name = "cmdExitfromMM";
            this.cmdExitfromMM.UseVisualStyleBackColor = true;
            this.cmdExitfromMM.Click += new System.EventHandler(this.cmdExitfromMM_Click);
            // 
            // cmdJobInfoSheet
            // 
            resources.ApplyResources(this.cmdJobInfoSheet, "cmdJobInfoSheet");
            this.cmdJobInfoSheet.Name = "cmdJobInfoSheet";
            this.cmdJobInfoSheet.UseVisualStyleBackColor = true;
            this.cmdJobInfoSheet.Click += new System.EventHandler(this.cmdJobInfoSheet_Click);
            // 
            // btnAddressForm
            // 
            resources.ApplyResources(this.btnAddressForm, "btnAddressForm");
            this.btnAddressForm.Name = "btnAddressForm";
            this.btnAddressForm.UseVisualStyleBackColor = true;
            this.btnAddressForm.Click += new System.EventHandler(this.btnAddressForm_Click);
            // 
            // btnContactForm
            // 
            resources.ApplyResources(this.btnContactForm, "btnContactForm");
            this.btnContactForm.Name = "btnContactForm";
            this.btnContactForm.UseVisualStyleBackColor = true;
            this.btnContactForm.Click += new System.EventHandler(this.btnContactForm_Click);
            // 
            // btnBudgetForm
            // 
            resources.ApplyResources(this.btnBudgetForm, "btnBudgetForm");
            this.btnBudgetForm.Name = "btnBudgetForm";
            this.btnBudgetForm.UseVisualStyleBackColor = true;
            this.btnBudgetForm.Click += new System.EventHandler(this.btnTestForms_Click);
            // 
            // btnManageEmployees
            // 
            resources.ApplyResources(this.btnManageEmployees, "btnManageEmployees");
            this.btnManageEmployees.Name = "btnManageEmployees";
            this.btnManageEmployees.UseVisualStyleBackColor = true;
            this.btnManageEmployees.Click += new System.EventHandler(this.btnManageEmployees_Click);
            // 
            // frmMainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnManageEmployees);
            this.Controls.Add(this.btnBudgetForm);
            this.Controls.Add(this.btnContactForm);
            this.Controls.Add(this.btnAddressForm);
            this.Controls.Add(this.cmdJobInfoSheet);
            this.Controls.Add(this.cmdExitfromMM);
            this.Controls.Add(this.cmdAdmin_UpdatePerms);
            this.Name = "frmMainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAdmin_UpdatePerms;
        private System.Windows.Forms.Button cmdExitfromMM;
        private System.Windows.Forms.Button cmdJobInfoSheet;
        private System.Windows.Forms.Button btnAddressForm;
        private System.Windows.Forms.Button btnContactForm;
        private System.Windows.Forms.Button btnBudgetForm;
        private System.Windows.Forms.Button btnManageEmployees;
    }
}