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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBudget));
            this.cbxJobNums = new System.Windows.Forms.ComboBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.lblJobNumber = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.dgvBudgetLineItems = new System.Windows.Forms.DataGridView();
            this.cmdSave = new System.Windows.Forms.Button();
            this.budgetlineitemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.holdenengrDataSet = new ibis_R1a.holdenengrDataSet();
            this.jobTableAdapter1 = new ibis_R1a.holdenengrDataSetTableAdapters.jobTableAdapter();
            this.ibis_workcodeTableAdapter1 = new ibis_R1a.holdenengrDataSetTableAdapters.ibis_workcodeTableAdapter();
            this.ibis_activitycodeTableAdapter1 = new ibis_R1a.holdenengrDataSetTableAdapters.ibis_activitycodeTableAdapter();
            this.ibis_taskcodeTableAdapter1 = new ibis_R1a.holdenengrDataSetTableAdapters.ibis_taskcodeTableAdapter();
            this.budget_lineitemTableAdapter = new ibis_R1a.holdenengrDataSetTableAdapters.budget_lineitemTableAdapter();
            this.hesemployee1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hesemployee1TableAdapter = new ibis_R1a.holdenengrDataSetTableAdapters.hesemployee1TableAdapter();
            this.budgetlineitemjobnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetlineitemworkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetlineitemactivityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetlineitemtaskidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetlineitemempidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.budgetlineitemnumhrsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetlineitemvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetlineitemnoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetlineitemdatestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetLineItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetlineitemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdenengrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesemployee1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxJobNums
            // 
            this.cbxJobNums.FormattingEnabled = true;
            this.cbxJobNums.Location = new System.Drawing.Point(119, 21);
            this.cbxJobNums.Margin = new System.Windows.Forms.Padding(4);
            this.cbxJobNums.Name = "cbxJobNums";
            this.cbxJobNums.Size = new System.Drawing.Size(153, 26);
            this.cbxJobNums.TabIndex = 0;
            this.cbxJobNums.SelectedIndexChanged += new System.EventHandler(this.cbxJobNums_SelectedIndexChanged);
            // 
            // cmdExit
            // 
            this.cmdExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdExit.Location = new System.Drawing.Point(759, 13);
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
            this.txtPName.Location = new System.Drawing.Point(373, 21);
            this.txtPName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(369, 25);
            this.txtPName.TabIndex = 5;
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
            this.lblJobName.Location = new System.Drawing.Point(291, 24);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(75, 18);
            this.lblJobName.TabIndex = 7;
            this.lblJobName.Text = "Job Name:";
            // 
            // dgvBudgetLineItems
            // 
            this.dgvBudgetLineItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBudgetLineItems.AutoGenerateColumns = false;
            this.dgvBudgetLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBudgetLineItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.budgetlineitemjobnumberDataGridViewTextBoxColumn,
            this.budgetlineitemworkidDataGridViewTextBoxColumn,
            this.budgetlineitemactivityidDataGridViewTextBoxColumn,
            this.budgetlineitemtaskidDataGridViewTextBoxColumn,
            this.budgetlineitemempidDataGridViewTextBoxColumn,
            this.budgetlineitemnumhrsDataGridViewTextBoxColumn,
            this.budgetlineitemvalueDataGridViewTextBoxColumn,
            this.budgetlineitemnoteDataGridViewTextBoxColumn,
            this.budgetlineitemdatestampDataGridViewTextBoxColumn});
            this.dgvBudgetLineItems.DataSource = this.budgetlineitemBindingSource;
            this.dgvBudgetLineItems.Location = new System.Drawing.Point(12, 143);
            this.dgvBudgetLineItems.Name = "dgvBudgetLineItems";
            this.dgvBudgetLineItems.Size = new System.Drawing.Size(1142, 379);
            this.dgvBudgetLineItems.TabIndex = 8;
            this.dgvBudgetLineItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBudgetLineItems_CellValueChanged);
            this.dgvBudgetLineItems.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvBudgetLineItems_DefaultValuesNeeded);
            // 
            // cmdSave
            // 
            this.cmdSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdSave.Location = new System.Drawing.Point(851, 13);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(101, 54);
            this.cmdSave.TabIndex = 9;
            this.cmdSave.Text = "&Save Changes";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // budgetlineitemBindingSource
            // 
            this.budgetlineitemBindingSource.DataMember = "budget_lineitem";
            this.budgetlineitemBindingSource.DataSource = this.holdenengrDataSet;
            // 
            // holdenengrDataSet
            // 
            this.holdenengrDataSet.DataSetName = "holdenengrDataSet";
            this.holdenengrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobTableAdapter1
            // 
            this.jobTableAdapter1.ClearBeforeFill = true;
            // 
            // ibis_workcodeTableAdapter1
            // 
            this.ibis_workcodeTableAdapter1.ClearBeforeFill = true;
            // 
            // ibis_activitycodeTableAdapter1
            // 
            this.ibis_activitycodeTableAdapter1.ClearBeforeFill = true;
            // 
            // ibis_taskcodeTableAdapter1
            // 
            this.ibis_taskcodeTableAdapter1.ClearBeforeFill = true;
            // 
            // budget_lineitemTableAdapter
            // 
            this.budget_lineitemTableAdapter.ClearBeforeFill = true;
            // 
            // hesemployee1BindingSource
            // 
            this.hesemployee1BindingSource.DataMember = "hesemployee1";
            this.hesemployee1BindingSource.DataSource = this.holdenengrDataSet;
            // 
            // hesemployee1TableAdapter
            // 
            this.hesemployee1TableAdapter.ClearBeforeFill = true;
            // 
            // budgetlineitemjobnumberDataGridViewTextBoxColumn
            // 
            this.budgetlineitemjobnumberDataGridViewTextBoxColumn.DataPropertyName = "budget_lineitem_jobnumber";
            this.budgetlineitemjobnumberDataGridViewTextBoxColumn.HeaderText = "Job Number";
            this.budgetlineitemjobnumberDataGridViewTextBoxColumn.Name = "budgetlineitemjobnumberDataGridViewTextBoxColumn";
            this.budgetlineitemjobnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // budgetlineitemworkidDataGridViewTextBoxColumn
            // 
            this.budgetlineitemworkidDataGridViewTextBoxColumn.DataPropertyName = "budget_lineitem_workid";
            this.budgetlineitemworkidDataGridViewTextBoxColumn.HeaderText = "Work Code";
            this.budgetlineitemworkidDataGridViewTextBoxColumn.Name = "budgetlineitemworkidDataGridViewTextBoxColumn";
            // 
            // budgetlineitemactivityidDataGridViewTextBoxColumn
            // 
            this.budgetlineitemactivityidDataGridViewTextBoxColumn.DataPropertyName = "budget_lineitem_activityid";
            this.budgetlineitemactivityidDataGridViewTextBoxColumn.HeaderText = "Activity Code";
            this.budgetlineitemactivityidDataGridViewTextBoxColumn.Name = "budgetlineitemactivityidDataGridViewTextBoxColumn";
            // 
            // budgetlineitemtaskidDataGridViewTextBoxColumn
            // 
            this.budgetlineitemtaskidDataGridViewTextBoxColumn.DataPropertyName = "budget_lineitem_taskid";
            this.budgetlineitemtaskidDataGridViewTextBoxColumn.HeaderText = "Task Code";
            this.budgetlineitemtaskidDataGridViewTextBoxColumn.Name = "budgetlineitemtaskidDataGridViewTextBoxColumn";
            // 
            // budgetlineitemempidDataGridViewTextBoxColumn
            // 
            this.budgetlineitemempidDataGridViewTextBoxColumn.DataPropertyName = "budget_lineitem_empid";
            this.budgetlineitemempidDataGridViewTextBoxColumn.DataSource = this.hesemployee1BindingSource;
            this.budgetlineitemempidDataGridViewTextBoxColumn.DisplayMember = "hesemployee_name";
            this.budgetlineitemempidDataGridViewTextBoxColumn.HeaderText = "Assigned Employee";
            this.budgetlineitemempidDataGridViewTextBoxColumn.Name = "budgetlineitemempidDataGridViewTextBoxColumn";
            this.budgetlineitemempidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.budgetlineitemempidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.budgetlineitemempidDataGridViewTextBoxColumn.ValueMember = "hesemployee_id";
            this.budgetlineitemempidDataGridViewTextBoxColumn.Width = 180;
            // 
            // budgetlineitemnumhrsDataGridViewTextBoxColumn
            // 
            this.budgetlineitemnumhrsDataGridViewTextBoxColumn.DataPropertyName = "budget_lineitem_numhrs";
            this.budgetlineitemnumhrsDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.budgetlineitemnumhrsDataGridViewTextBoxColumn.Name = "budgetlineitemnumhrsDataGridViewTextBoxColumn";
            this.budgetlineitemnumhrsDataGridViewTextBoxColumn.Width = 70;
            // 
            // budgetlineitemvalueDataGridViewTextBoxColumn
            // 
            this.budgetlineitemvalueDataGridViewTextBoxColumn.DataPropertyName = "budget_lineitem_value";
            this.budgetlineitemvalueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.budgetlineitemvalueDataGridViewTextBoxColumn.Name = "budgetlineitemvalueDataGridViewTextBoxColumn";
            // 
            // budgetlineitemnoteDataGridViewTextBoxColumn
            // 
            this.budgetlineitemnoteDataGridViewTextBoxColumn.DataPropertyName = "budget_lineitem_note";
            this.budgetlineitemnoteDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.budgetlineitemnoteDataGridViewTextBoxColumn.Name = "budgetlineitemnoteDataGridViewTextBoxColumn";
            this.budgetlineitemnoteDataGridViewTextBoxColumn.Width = 180;
            // 
            // budgetlineitemdatestampDataGridViewTextBoxColumn
            // 
            this.budgetlineitemdatestampDataGridViewTextBoxColumn.DataPropertyName = "budget_lineitem_datestamp";
            this.budgetlineitemdatestampDataGridViewTextBoxColumn.HeaderText = "Last Updated";
            this.budgetlineitemdatestampDataGridViewTextBoxColumn.Name = "budgetlineitemdatestampDataGridViewTextBoxColumn";
            this.budgetlineitemdatestampDataGridViewTextBoxColumn.ReadOnly = true;
            this.budgetlineitemdatestampDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 534);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.dgvBudgetLineItems);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetLineItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetlineitemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdenengrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesemployee1BindingSource)).EndInit();
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
        private holdenengrDataSetTableAdapters.ibis_workcodeTableAdapter ibis_workcodeTableAdapter1;
        private holdenengrDataSetTableAdapters.ibis_activitycodeTableAdapter ibis_activitycodeTableAdapter1;
        private holdenengrDataSetTableAdapters.ibis_taskcodeTableAdapter ibis_taskcodeTableAdapter1;
        private System.Windows.Forms.DataGridView dgvBudgetLineItems;
        private System.Windows.Forms.BindingSource budgetlineitemBindingSource;
        private holdenengrDataSetTableAdapters.budget_lineitemTableAdapter budget_lineitemTableAdapter;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.BindingSource hesemployee1BindingSource;
        private holdenengrDataSetTableAdapters.hesemployee1TableAdapter hesemployee1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetlineitemjobnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetlineitemworkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetlineitemactivityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetlineitemtaskidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn budgetlineitemempidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetlineitemnumhrsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetlineitemvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetlineitemnoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetlineitemdatestampDataGridViewTextBoxColumn;
    }
}