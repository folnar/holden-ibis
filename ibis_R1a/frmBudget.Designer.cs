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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBudget));
            this.cbxJobNums = new System.Windows.Forms.ComboBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.lblJobNumber = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.dgvBudgetLineItems = new System.Windows.Forms.DataGridView();
            this.budget_lineitem_jobnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budget_lineitem_workid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ibisworkcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.holdenengrDataSet = new ibis_R1a.holdenengrDataSet();
            this.budget_lineitem_activityid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ibisactivitycodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budget_lineitem_taskid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ibistaskcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budget_lineitem_empid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hesemployee1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budget_lineitem_numhrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budget_lineitem_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budget_lineitem_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budget_lineitem_datestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budget_lineitem_enteredby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetlineitemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdSave = new System.Windows.Forms.Button();
            this.lblTotalBudgetValue = new System.Windows.Forms.Label();
            this.lblBudgetTotalDisp = new System.Windows.Forms.Label();
            this.jobTableAdapter1 = new ibis_R1a.holdenengrDataSetTableAdapters.jobTableAdapter();
            this.ibis_workcodeTableAdapter1 = new ibis_R1a.holdenengrDataSetTableAdapters.ibis_workcodeTableAdapter();
            this.ibis_activitycodeTableAdapter1 = new ibis_R1a.holdenengrDataSetTableAdapters.ibis_activitycodeTableAdapter();
            this.ibis_taskcodeTableAdapter1 = new ibis_R1a.holdenengrDataSetTableAdapters.ibis_taskcodeTableAdapter();
            this.budget_lineitemTableAdapter = new ibis_R1a.holdenengrDataSetTableAdapters.budget_lineitemTableAdapter();
            this.hesemployee1TableAdapter = new ibis_R1a.holdenengrDataSetTableAdapters.hesemployee1TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBudgetExpenseItems = new System.Windows.Forms.Label();
            this.lblBudgetLaborLineItems = new System.Windows.Forms.Label();
            this.panelMainControls = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetLineItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibisworkcodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdenengrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibisactivitycodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibistaskcodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesemployee1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetlineitemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMainControls.SuspendLayout();
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
            this.cmdExit.CausesValidation = false;
            this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdExit.Location = new System.Drawing.Point(763, 13);
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
            this.txtPName.ReadOnly = true;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBudgetLineItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBudgetLineItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBudgetLineItems.AutoGenerateColumns = false;
            this.dgvBudgetLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBudgetLineItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.budget_lineitem_jobnumber,
            this.budget_lineitem_workid,
            this.budget_lineitem_activityid,
            this.budget_lineitem_taskid,
            this.budget_lineitem_empid,
            this.budget_lineitem_numhrs,
            this.budget_lineitem_value,
            this.budget_lineitem_note,
            this.budget_lineitem_datestamp,
            this.budget_lineitem_enteredby});
            this.dgvBudgetLineItems.DataSource = this.budgetlineitemBindingSource;
            this.dgvBudgetLineItems.Location = new System.Drawing.Point(6, 30);
            this.dgvBudgetLineItems.Name = "dgvBudgetLineItems";
            this.dgvBudgetLineItems.Size = new System.Drawing.Size(1139, 349);
            this.dgvBudgetLineItems.TabIndex = 8;
            this.dgvBudgetLineItems.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvBudgetLineItems_DataError);
            this.dgvBudgetLineItems.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvBudgetLineItems_DefaultValuesNeeded);
            this.dgvBudgetLineItems.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvBudgetLineItems_EditingControlShowing);
            // 
            // budget_lineitem_jobnumber
            // 
            this.budget_lineitem_jobnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.budget_lineitem_jobnumber.DataPropertyName = "budget_lineitem_jobnumber";
            this.budget_lineitem_jobnumber.HeaderText = "Job Number";
            this.budget_lineitem_jobnumber.Name = "budget_lineitem_jobnumber";
            this.budget_lineitem_jobnumber.Width = 101;
            // 
            // budget_lineitem_workid
            // 
            this.budget_lineitem_workid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.budget_lineitem_workid.DataPropertyName = "budget_lineitem_workid";
            this.budget_lineitem_workid.DataSource = this.ibisworkcodeBindingSource;
            this.budget_lineitem_workid.DisplayMember = "ibis_workcode_label";
            this.budget_lineitem_workid.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.budget_lineitem_workid.HeaderText = "Work Code";
            this.budget_lineitem_workid.Name = "budget_lineitem_workid";
            this.budget_lineitem_workid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.budget_lineitem_workid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.budget_lineitem_workid.ValueMember = "ibis_workcode_id";
            this.budget_lineitem_workid.Width = 96;
            // 
            // ibisworkcodeBindingSource
            // 
            this.ibisworkcodeBindingSource.DataMember = "ibis_workcode";
            this.ibisworkcodeBindingSource.DataSource = this.holdenengrDataSet;
            // 
            // holdenengrDataSet
            // 
            this.holdenengrDataSet.DataSetName = "holdenengrDataSet";
            this.holdenengrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budget_lineitem_activityid
            // 
            this.budget_lineitem_activityid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.budget_lineitem_activityid.DataPropertyName = "budget_lineitem_activityid";
            this.budget_lineitem_activityid.DataSource = this.ibisactivitycodeBindingSource;
            this.budget_lineitem_activityid.DisplayMember = "ibis_activitycode_label";
            this.budget_lineitem_activityid.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.budget_lineitem_activityid.HeaderText = "Activity Code";
            this.budget_lineitem_activityid.Name = "budget_lineitem_activityid";
            this.budget_lineitem_activityid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.budget_lineitem_activityid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.budget_lineitem_activityid.ValueMember = "ibis_activitycode_id";
            this.budget_lineitem_activityid.Width = 111;
            // 
            // ibisactivitycodeBindingSource
            // 
            this.ibisactivitycodeBindingSource.DataMember = "ibis_activitycode";
            this.ibisactivitycodeBindingSource.DataSource = this.holdenengrDataSet;
            // 
            // budget_lineitem_taskid
            // 
            this.budget_lineitem_taskid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.budget_lineitem_taskid.DataPropertyName = "budget_lineitem_taskid";
            this.budget_lineitem_taskid.DataSource = this.ibistaskcodeBindingSource;
            this.budget_lineitem_taskid.DisplayMember = "ibis_taskcode_label";
            this.budget_lineitem_taskid.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.budget_lineitem_taskid.HeaderText = "Task Code";
            this.budget_lineitem_taskid.Name = "budget_lineitem_taskid";
            this.budget_lineitem_taskid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.budget_lineitem_taskid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.budget_lineitem_taskid.ValueMember = "ibis_taskcode_id";
            this.budget_lineitem_taskid.Width = 93;
            // 
            // ibistaskcodeBindingSource
            // 
            this.ibistaskcodeBindingSource.DataMember = "ibis_taskcode";
            this.ibistaskcodeBindingSource.DataSource = this.holdenengrDataSet;
            // 
            // budget_lineitem_empid
            // 
            this.budget_lineitem_empid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.budget_lineitem_empid.DataPropertyName = "budget_lineitem_empid";
            this.budget_lineitem_empid.DataSource = this.hesemployee1BindingSource;
            this.budget_lineitem_empid.DisplayMember = "hesemployee_name";
            this.budget_lineitem_empid.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.budget_lineitem_empid.HeaderText = "Assigned Employee";
            this.budget_lineitem_empid.Name = "budget_lineitem_empid";
            this.budget_lineitem_empid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.budget_lineitem_empid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.budget_lineitem_empid.ValueMember = "hesemployee_id";
            this.budget_lineitem_empid.Width = 144;
            // 
            // hesemployee1BindingSource
            // 
            this.hesemployee1BindingSource.DataMember = "hesemployee1";
            this.hesemployee1BindingSource.DataSource = this.holdenengrDataSet;
            // 
            // budget_lineitem_numhrs
            // 
            this.budget_lineitem_numhrs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.budget_lineitem_numhrs.DataPropertyName = "budget_lineitem_numhrs";
            this.budget_lineitem_numhrs.HeaderText = "Hours";
            this.budget_lineitem_numhrs.Name = "budget_lineitem_numhrs";
            this.budget_lineitem_numhrs.Width = 72;
            // 
            // budget_lineitem_value
            // 
            this.budget_lineitem_value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.budget_lineitem_value.DataPropertyName = "budget_lineitem_value";
            this.budget_lineitem_value.HeaderText = "Value";
            this.budget_lineitem_value.Name = "budget_lineitem_value";
            this.budget_lineitem_value.ReadOnly = true;
            this.budget_lineitem_value.Width = 70;
            // 
            // budget_lineitem_note
            // 
            this.budget_lineitem_note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.budget_lineitem_note.DataPropertyName = "budget_lineitem_note";
            this.budget_lineitem_note.HeaderText = "Notes";
            this.budget_lineitem_note.Name = "budget_lineitem_note";
            this.budget_lineitem_note.Width = 71;
            // 
            // budget_lineitem_datestamp
            // 
            this.budget_lineitem_datestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.budget_lineitem_datestamp.DataPropertyName = "budget_lineitem_datestamp";
            this.budget_lineitem_datestamp.HeaderText = "Date Entered";
            this.budget_lineitem_datestamp.Name = "budget_lineitem_datestamp";
            this.budget_lineitem_datestamp.ReadOnly = true;
            this.budget_lineitem_datestamp.Width = 109;
            // 
            // budget_lineitem_enteredby
            // 
            this.budget_lineitem_enteredby.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.budget_lineitem_enteredby.DataPropertyName = "budget_lineitem_enteredby";
            this.budget_lineitem_enteredby.HeaderText = "Entered By";
            this.budget_lineitem_enteredby.Name = "budget_lineitem_enteredby";
            this.budget_lineitem_enteredby.ReadOnly = true;
            this.budget_lineitem_enteredby.Width = 96;
            // 
            // budgetlineitemBindingSource
            // 
            this.budgetlineitemBindingSource.DataMember = "budget_lineitem";
            this.budgetlineitemBindingSource.DataSource = this.holdenengrDataSet;
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
            // lblTotalBudgetValue
            // 
            this.lblTotalBudgetValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalBudgetValue.AutoSize = true;
            this.lblTotalBudgetValue.Location = new System.Drawing.Point(17, 620);
            this.lblTotalBudgetValue.Name = "lblTotalBudgetValue";
            this.lblTotalBudgetValue.Size = new System.Drawing.Size(136, 18);
            this.lblTotalBudgetValue.TabIndex = 10;
            this.lblTotalBudgetValue.Text = "Total Budget Value:";
            // 
            // lblBudgetTotalDisp
            // 
            this.lblBudgetTotalDisp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBudgetTotalDisp.AutoSize = true;
            this.lblBudgetTotalDisp.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetTotalDisp.Location = new System.Drawing.Point(159, 620);
            this.lblBudgetTotalDisp.Name = "lblBudgetTotalDisp";
            this.lblBudgetTotalDisp.Size = new System.Drawing.Size(89, 18);
            this.lblBudgetTotalDisp.TabIndex = 11;
            this.lblBudgetTotalDisp.Text = "placeholder";
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
            // hesemployee1TableAdapter
            // 
            this.hesemployee1TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 421);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1139, 170);
            this.dataGridView1.TabIndex = 12;
            // 
            // lblBudgetExpenseItems
            // 
            this.lblBudgetExpenseItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBudgetExpenseItems.AutoSize = true;
            this.lblBudgetExpenseItems.Location = new System.Drawing.Point(6, 400);
            this.lblBudgetExpenseItems.Name = "lblBudgetExpenseItems";
            this.lblBudgetExpenseItems.Size = new System.Drawing.Size(154, 18);
            this.lblBudgetExpenseItems.TabIndex = 13;
            this.lblBudgetExpenseItems.Text = "Budget Expense Items:";
            // 
            // lblBudgetLaborLineItems
            // 
            this.lblBudgetLaborLineItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBudgetLaborLineItems.AutoSize = true;
            this.lblBudgetLaborLineItems.Location = new System.Drawing.Point(6, 9);
            this.lblBudgetLaborLineItems.Name = "lblBudgetLaborLineItems";
            this.lblBudgetLaborLineItems.Size = new System.Drawing.Size(169, 18);
            this.lblBudgetLaborLineItems.TabIndex = 14;
            this.lblBudgetLaborLineItems.Text = "Budget Labor Line Items:";
            // 
            // panelMainControls
            // 
            this.panelMainControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainControls.Controls.Add(this.lblBudgetLaborLineItems);
            this.panelMainControls.Controls.Add(this.lblBudgetExpenseItems);
            this.panelMainControls.Controls.Add(this.dataGridView1);
            this.panelMainControls.Controls.Add(this.lblBudgetTotalDisp);
            this.panelMainControls.Controls.Add(this.lblTotalBudgetValue);
            this.panelMainControls.Controls.Add(this.dgvBudgetLineItems);
            this.panelMainControls.Location = new System.Drawing.Point(6, 69);
            this.panelMainControls.Name = "panelMainControls";
            this.panelMainControls.Size = new System.Drawing.Size(1148, 652);
            this.panelMainControls.TabIndex = 15;
            // 
            // frmBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 733);
            this.Controls.Add(this.panelMainControls);
            this.Controls.Add(this.cmdSave);
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
            ((System.ComponentModel.ISupportInitialize)(this.ibisworkcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdenengrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibisactivitycodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibistaskcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesemployee1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetlineitemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMainControls.ResumeLayout(false);
            this.panelMainControls.PerformLayout();
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
        private System.Windows.Forms.BindingSource ibisworkcodeBindingSource;
        private System.Windows.Forms.BindingSource ibisactivitycodeBindingSource;
        private System.Windows.Forms.BindingSource ibistaskcodeBindingSource;
        private System.Windows.Forms.Label lblTotalBudgetValue;
        private System.Windows.Forms.Label lblBudgetTotalDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn budget_lineitem_jobnumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn budget_lineitem_workid;
        private System.Windows.Forms.DataGridViewComboBoxColumn budget_lineitem_activityid;
        private System.Windows.Forms.DataGridViewComboBoxColumn budget_lineitem_taskid;
        private System.Windows.Forms.DataGridViewComboBoxColumn budget_lineitem_empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn budget_lineitem_numhrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn budget_lineitem_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn budget_lineitem_note;
        private System.Windows.Forms.DataGridViewTextBoxColumn budget_lineitem_datestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn budget_lineitem_enteredby;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBudgetExpenseItems;
        private System.Windows.Forms.Label lblBudgetLaborLineItems;
        private System.Windows.Forms.Panel panelMainControls;
    }
}