namespace ibis_R1a
{
    partial class frmBudget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBudget));
            this.cbxJobNums = new System.Windows.Forms.ComboBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.jobTableAdapter1 = new ibis_R1a.holdenengrDataSetTableAdapters.jobTableAdapter();
            this.lblJobNumber = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxJobNums
            // 
            this.cbxJobNums.FormattingEnabled = true;
            this.cbxJobNums.Location = new System.Drawing.Point(108, 21);
            this.cbxJobNums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxJobNums.Name = "cbxJobNums";
            this.cbxJobNums.Size = new System.Drawing.Size(286, 26);
            this.cbxJobNums.TabIndex = 0;
            this.cbxJobNums.SelectedIndexChanged += new System.EventHandler(this.cbxJobNums_SelectedIndexChanged);
            // 
            // cmdExit
            // 
            this.cmdExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdExit.Location = new System.Drawing.Point(840, 13);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(67, 54);
            this.cmdExit.TabIndex = 4;
            this.cmdExit.Text = "E&xit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(505, 21);
            this.txtPName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(286, 25);
            this.txtPName.TabIndex = 5;
            // 
            // jobTableAdapter1
            // 
            this.jobTableAdapter1.ClearBeforeFill = true;
            // 
            // lblJobNumber
            // 
            this.lblJobNumber.AutoSize = true;
            this.lblJobNumber.Location = new System.Drawing.Point(12, 24);
            this.lblJobNumber.Name = "lblJobNumber";
            this.lblJobNumber.Size = new System.Drawing.Size(89, 18);
            this.lblJobNumber.TabIndex = 6;
            this.lblJobNumber.Text = "Job Number:";
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Location = new System.Drawing.Point(423, 24);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(75, 18);
            this.lblJobName.TabIndex = 7;
            this.lblJobName.Text = "Job Name:";
            // 
            // frmBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 534);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.lblJobNumber);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cbxJobNums);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBudget";
            this.Text = "Budget Form";
            this.Load += new System.EventHandler(this.frmBudget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxJobNums;
        private holdenengrDataSetTableAdapters.jobTableAdapter jobTableAdapter1;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label lblJobNumber;
        private System.Windows.Forms.Label lblJobName;
    }
}