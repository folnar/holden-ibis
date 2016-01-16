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
            this.SuspendLayout();
            // 
            // cbxJobNums
            // 
            this.cbxJobNums.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJobNums.FormattingEnabled = true;
            this.cbxJobNums.Location = new System.Drawing.Point(331, 98);
            this.cbxJobNums.Name = "cbxJobNums";
            this.cbxJobNums.Size = new System.Drawing.Size(192, 21);
            this.cbxJobNums.TabIndex = 0;
            this.cbxJobNums.SelectedIndexChanged += new System.EventHandler(this.cbxJobNums_SelectedIndexChanged);
            // 
            // cmdExit
            // 
            this.cmdExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdExit.Location = new System.Drawing.Point(331, 300);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(170, 43);
            this.cmdExit.TabIndex = 4;
            this.cmdExit.Text = "E&xit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(331, 172);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(192, 20);
            this.txtPName.TabIndex = 5;
            // 
            // jobTableAdapter1
            // 
            this.jobTableAdapter1.ClearBeforeFill = true;
            // 
            // frmBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 607);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cbxJobNums);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBudget";
            this.Text = "Job Entry Form";
            this.Load += new System.EventHandler(this.frmBudget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxJobNums;
        private holdenengrDataSetTableAdapters.jobTableAdapter jobTableAdapter1;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.TextBox txtPName;
    }
}