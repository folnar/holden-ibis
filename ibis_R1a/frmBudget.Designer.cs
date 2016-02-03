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
            this.holdenengrDataSet = new ibis_R1a.holdenengrDataSet();
            this.lblWorkCode = new System.Windows.Forms.Label();
            this.cbxWorkCode = new System.Windows.Forms.ComboBox();
            this.lblActivityCode = new System.Windows.Forms.Label();
            this.cbxActivityCode = new System.Windows.Forms.ComboBox();
            this.lblTaskCode = new System.Windows.Forms.Label();
            this.cbxTaskCode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.holdenengrDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxJobNums
            // 
            this.cbxJobNums.FormattingEnabled = true;
            this.cbxJobNums.Location = new System.Drawing.Point(119, 21);
            this.cbxJobNums.Margin = new System.Windows.Forms.Padding(4);
            this.cbxJobNums.Name = "cbxJobNums";
            this.cbxJobNums.Size = new System.Drawing.Size(286, 26);
            this.cbxJobNums.TabIndex = 0;
            this.cbxJobNums.SelectedIndexChanged += new System.EventHandler(this.cbxJobNums_SelectedIndexChanged);
            // 
            // cmdExit
            // 
            this.cmdExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdExit.Location = new System.Drawing.Point(840, 13);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtPName.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblJobNumber.Location = new System.Drawing.Point(23, 24);
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
            // holdenengrDataSet
            // 
            this.holdenengrDataSet.DataSetName = "holdenengrDataSet";
            this.holdenengrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblWorkCode
            // 
            this.lblWorkCode.AutoSize = true;
            this.lblWorkCode.Location = new System.Drawing.Point(28, 58);
            this.lblWorkCode.Name = "lblWorkCode";
            this.lblWorkCode.Size = new System.Drawing.Size(84, 18);
            this.lblWorkCode.TabIndex = 9;
            this.lblWorkCode.Text = "Work Code:";
            // 
            // cbxWorkCode
            // 
            this.cbxWorkCode.FormattingEnabled = true;
            this.cbxWorkCode.Location = new System.Drawing.Point(119, 55);
            this.cbxWorkCode.Margin = new System.Windows.Forms.Padding(4);
            this.cbxWorkCode.Name = "cbxWorkCode";
            this.cbxWorkCode.Size = new System.Drawing.Size(286, 26);
            this.cbxWorkCode.TabIndex = 8;
            // 
            // lblActivityCode
            // 
            this.lblActivityCode.AutoSize = true;
            this.lblActivityCode.Location = new System.Drawing.Point(12, 126);
            this.lblActivityCode.Name = "lblActivityCode";
            this.lblActivityCode.Size = new System.Drawing.Size(100, 18);
            this.lblActivityCode.TabIndex = 11;
            this.lblActivityCode.Text = "Activity Code:";
            // 
            // cbxActivityCode
            // 
            this.cbxActivityCode.FormattingEnabled = true;
            this.cbxActivityCode.Location = new System.Drawing.Point(119, 123);
            this.cbxActivityCode.Margin = new System.Windows.Forms.Padding(4);
            this.cbxActivityCode.Name = "cbxActivityCode";
            this.cbxActivityCode.Size = new System.Drawing.Size(286, 26);
            this.cbxActivityCode.TabIndex = 10;
            // 
            // lblTaskCode
            // 
            this.lblTaskCode.AutoSize = true;
            this.lblTaskCode.Location = new System.Drawing.Point(32, 92);
            this.lblTaskCode.Name = "lblTaskCode";
            this.lblTaskCode.Size = new System.Drawing.Size(80, 18);
            this.lblTaskCode.TabIndex = 13;
            this.lblTaskCode.Text = "Task Code:";
            // 
            // cbxTaskCode
            // 
            this.cbxTaskCode.FormattingEnabled = true;
            this.cbxTaskCode.Location = new System.Drawing.Point(119, 89);
            this.cbxTaskCode.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTaskCode.Name = "cbxTaskCode";
            this.cbxTaskCode.Size = new System.Drawing.Size(286, 26);
            this.cbxTaskCode.TabIndex = 12;
            // 
            // frmBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 534);
            this.Controls.Add(this.lblTaskCode);
            this.Controls.Add(this.cbxTaskCode);
            this.Controls.Add(this.lblActivityCode);
            this.Controls.Add(this.cbxActivityCode);
            this.Controls.Add(this.lblWorkCode);
            this.Controls.Add(this.cbxWorkCode);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.lblJobNumber);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cbxJobNums);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBudget";
            this.Text = "Budget Form";
            this.Load += new System.EventHandler(this.frmBudget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.holdenengrDataSet)).EndInit();
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
        private holdenengrDataSet holdenengrDataSet;
        private System.Windows.Forms.Label lblWorkCode;
        private System.Windows.Forms.ComboBox cbxWorkCode;
        private System.Windows.Forms.Label lblActivityCode;
        private System.Windows.Forms.ComboBox cbxActivityCode;
        private System.Windows.Forms.Label lblTaskCode;
        private System.Windows.Forms.ComboBox cbxTaskCode;
    }
}