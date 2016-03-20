namespace JobBroswer
{
    partial class frmJobBroswer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobBroswer));
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.jobjobkeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobccodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobdescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobaddr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobaddr3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobcityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobpcontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobdescr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.holdenengrDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.holdenengrDataSet = new JobBroswer.holdenengrDataSet();
            this.lblFilterLabel = new System.Windows.Forms.Label();
            this.lblByClientName = new System.Windows.Forms.Label();
            this.lblByProjectAddress = new System.Windows.Forms.Label();
            this.txtByProjectAddress = new System.Windows.Forms.TextBox();
            this.txtByClientName = new System.Windows.Forms.TextBox();
            this.cmdFilterByClientName = new System.Windows.Forms.Button();
            this.cmdFilterByProjectAddress = new System.Windows.Forms.Button();
            this.cmdRemFilterByClientName = new System.Windows.Forms.Button();
            this.cmdRemFilterByProjectAddress = new System.Windows.Forms.Button();
            this.cmdRemFilterByProjectTown = new System.Windows.Forms.Button();
            this.cmdFilterByProjectTown = new System.Windows.Forms.Button();
            this.txtByProjectTown = new System.Windows.Forms.TextBox();
            this.lblByProjectTown = new System.Windows.Forms.Label();
            this.cmdRemFilterByProjectState = new System.Windows.Forms.Button();
            this.cmdFilterByProjectState = new System.Windows.Forms.Button();
            this.txtByProjectState = new System.Windows.Forms.TextBox();
            this.lblByProjectState = new System.Windows.Forms.Label();
            this.cmdRemFilterByProjectContact = new System.Windows.Forms.Button();
            this.cmdFilterByProjectContact = new System.Windows.Forms.Button();
            this.txtByProjectContact = new System.Windows.Forms.TextBox();
            this.lblByProjectContact = new System.Windows.Forms.Label();
            this.lblCurrByContact = new System.Windows.Forms.Label();
            this.lblCurrByState = new System.Windows.Forms.Label();
            this.lblCurrByTown = new System.Windows.Forms.Label();
            this.lblCurrByAddress = new System.Windows.Forms.Label();
            this.lblCurrByClient = new System.Windows.Forms.Label();
            this.lblCurrFilters = new System.Windows.Forms.Label();
            this.lblCurrFilterByClientName = new System.Windows.Forms.Label();
            this.lblCurrFilterByAddress = new System.Windows.Forms.Label();
            this.lblCurrFilterByTown = new System.Windows.Forms.Label();
            this.lblCurrFilterByState = new System.Windows.Forms.Label();
            this.lblCurrFilterByContact = new System.Windows.Forms.Label();
            this.lblResultsCount = new System.Windows.Forms.Label();
            this.lblNumRecsLabel = new System.Windows.Forms.Label();
            this.jobTableAdapter = new JobBroswer.holdenengrDataSetTableAdapters.jobTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.includeArchiveRecordsPreJCTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPrintReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdenengrDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdenengrDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvJobs
            // 
            this.dgvJobs.AllowUserToOrderColumns = true;
            this.dgvJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJobs.AutoGenerateColumns = false;
            this.dgvJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobjobkeyDataGridViewTextBoxColumn,
            this.jobccodeDataGridViewTextBoxColumn,
            this.jobdescrDataGridViewTextBoxColumn,
            this.jobaddr1DataGridViewTextBoxColumn,
            this.jobaddr3DataGridViewTextBoxColumn,
            this.jobcityDataGridViewTextBoxColumn,
            this.jobstateDataGridViewTextBoxColumn,
            this.jobpcontactDataGridViewTextBoxColumn,
            this.jobdescr2DataGridViewTextBoxColumn});
            this.dgvJobs.DataSource = this.jobBindingSource;
            this.dgvJobs.Location = new System.Drawing.Point(13, 234);
            this.dgvJobs.Margin = new System.Windows.Forms.Padding(4);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.RowHeadersVisible = false;
            this.dgvJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobs.Size = new System.Drawing.Size(980, 316);
            this.dgvJobs.TabIndex = 0;
            // 
            // jobjobkeyDataGridViewTextBoxColumn
            // 
            this.jobjobkeyDataGridViewTextBoxColumn.DataPropertyName = "job_job_key";
            this.jobjobkeyDataGridViewTextBoxColumn.HeaderText = "Job Number";
            this.jobjobkeyDataGridViewTextBoxColumn.Name = "jobjobkeyDataGridViewTextBoxColumn";
            this.jobjobkeyDataGridViewTextBoxColumn.Width = 99;
            // 
            // jobccodeDataGridViewTextBoxColumn
            // 
            this.jobccodeDataGridViewTextBoxColumn.DataPropertyName = "client_name";
            this.jobccodeDataGridViewTextBoxColumn.HeaderText = "Client Name";
            this.jobccodeDataGridViewTextBoxColumn.Name = "jobccodeDataGridViewTextBoxColumn";
            this.jobccodeDataGridViewTextBoxColumn.Width = 97;
            // 
            // jobdescrDataGridViewTextBoxColumn
            // 
            this.jobdescrDataGridViewTextBoxColumn.DataPropertyName = "job_descr";
            this.jobdescrDataGridViewTextBoxColumn.HeaderText = "Description";
            this.jobdescrDataGridViewTextBoxColumn.Name = "jobdescrDataGridViewTextBoxColumn";
            // 
            // jobaddr1DataGridViewTextBoxColumn
            // 
            this.jobaddr1DataGridViewTextBoxColumn.DataPropertyName = "job_addr1";
            this.jobaddr1DataGridViewTextBoxColumn.HeaderText = "Project Address";
            this.jobaddr1DataGridViewTextBoxColumn.Name = "jobaddr1DataGridViewTextBoxColumn";
            this.jobaddr1DataGridViewTextBoxColumn.Width = 114;
            // 
            // jobaddr3DataGridViewTextBoxColumn
            // 
            this.jobaddr3DataGridViewTextBoxColumn.DataPropertyName = "job_addr3";
            this.jobaddr3DataGridViewTextBoxColumn.HeaderText = "Project Address 2";
            this.jobaddr3DataGridViewTextBoxColumn.Name = "jobaddr3DataGridViewTextBoxColumn";
            this.jobaddr3DataGridViewTextBoxColumn.Width = 123;
            // 
            // jobcityDataGridViewTextBoxColumn
            // 
            this.jobcityDataGridViewTextBoxColumn.DataPropertyName = "job_city";
            this.jobcityDataGridViewTextBoxColumn.HeaderText = "Project Town";
            this.jobcityDataGridViewTextBoxColumn.Name = "jobcityDataGridViewTextBoxColumn";
            this.jobcityDataGridViewTextBoxColumn.Width = 103;
            // 
            // jobstateDataGridViewTextBoxColumn
            // 
            this.jobstateDataGridViewTextBoxColumn.DataPropertyName = "job_state";
            this.jobstateDataGridViewTextBoxColumn.HeaderText = "State";
            this.jobstateDataGridViewTextBoxColumn.Name = "jobstateDataGridViewTextBoxColumn";
            this.jobstateDataGridViewTextBoxColumn.Width = 60;
            // 
            // jobpcontactDataGridViewTextBoxColumn
            // 
            this.jobpcontactDataGridViewTextBoxColumn.DataPropertyName = "job_pcontact";
            this.jobpcontactDataGridViewTextBoxColumn.HeaderText = "Client Contact";
            this.jobpcontactDataGridViewTextBoxColumn.Name = "jobpcontactDataGridViewTextBoxColumn";
            this.jobpcontactDataGridViewTextBoxColumn.Width = 105;
            // 
            // jobdescr2DataGridViewTextBoxColumn
            // 
            this.jobdescr2DataGridViewTextBoxColumn.DataPropertyName = "job_descr2";
            this.jobdescr2DataGridViewTextBoxColumn.HeaderText = "Description";
            this.jobdescr2DataGridViewTextBoxColumn.Name = "jobdescr2DataGridViewTextBoxColumn";
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "job";
            this.jobBindingSource.DataSource = this.holdenengrDataSetBindingSource;
            // 
            // holdenengrDataSetBindingSource
            // 
            this.holdenengrDataSetBindingSource.DataSource = this.holdenengrDataSet;
            this.holdenengrDataSetBindingSource.Position = 0;
            // 
            // holdenengrDataSet
            // 
            this.holdenengrDataSet.DataSetName = "holdenengrDataSet";
            this.holdenengrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblFilterLabel
            // 
            this.lblFilterLabel.AutoSize = true;
            this.lblFilterLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterLabel.Location = new System.Drawing.Point(40, 4);
            this.lblFilterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterLabel.Name = "lblFilterLabel";
            this.lblFilterLabel.Size = new System.Drawing.Size(81, 18);
            this.lblFilterLabel.TabIndex = 1;
            this.lblFilterLabel.Text = "Filter Data:";
            // 
            // lblByClientName
            // 
            this.lblByClientName.AutoSize = true;
            this.lblByClientName.Location = new System.Drawing.Point(19, 32);
            this.lblByClientName.Name = "lblByClientName";
            this.lblByClientName.Size = new System.Drawing.Size(102, 17);
            this.lblByClientName.TabIndex = 2;
            this.lblByClientName.Text = "by Client Name:";
            // 
            // lblByProjectAddress
            // 
            this.lblByProjectAddress.AutoSize = true;
            this.lblByProjectAddress.Location = new System.Drawing.Point(3, 62);
            this.lblByProjectAddress.Name = "lblByProjectAddress";
            this.lblByProjectAddress.Size = new System.Drawing.Size(120, 17);
            this.lblByProjectAddress.TabIndex = 3;
            this.lblByProjectAddress.Text = "by Project Address:";
            // 
            // txtByProjectAddress
            // 
            this.txtByProjectAddress.Location = new System.Drawing.Point(123, 59);
            this.txtByProjectAddress.Name = "txtByProjectAddress";
            this.txtByProjectAddress.Size = new System.Drawing.Size(243, 24);
            this.txtByProjectAddress.TabIndex = 4;
            this.txtByProjectAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtByProjectAddress_KeyPress);
            // 
            // txtByClientName
            // 
            this.txtByClientName.Location = new System.Drawing.Point(123, 29);
            this.txtByClientName.Name = "txtByClientName";
            this.txtByClientName.Size = new System.Drawing.Size(243, 24);
            this.txtByClientName.TabIndex = 1;
            this.txtByClientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtByClientName_KeyPress);
            // 
            // cmdFilterByClientName
            // 
            this.cmdFilterByClientName.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFilterByClientName.Location = new System.Drawing.Point(372, 29);
            this.cmdFilterByClientName.Name = "cmdFilterByClientName";
            this.cmdFilterByClientName.Size = new System.Drawing.Size(75, 23);
            this.cmdFilterByClientName.TabIndex = 2;
            this.cmdFilterByClientName.Text = "Filter";
            this.cmdFilterByClientName.UseVisualStyleBackColor = true;
            this.cmdFilterByClientName.Click += new System.EventHandler(this.cmdFilterByClientName_Click);
            // 
            // cmdFilterByProjectAddress
            // 
            this.cmdFilterByProjectAddress.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFilterByProjectAddress.Location = new System.Drawing.Point(372, 59);
            this.cmdFilterByProjectAddress.Name = "cmdFilterByProjectAddress";
            this.cmdFilterByProjectAddress.Size = new System.Drawing.Size(75, 23);
            this.cmdFilterByProjectAddress.TabIndex = 5;
            this.cmdFilterByProjectAddress.Text = "Filter";
            this.cmdFilterByProjectAddress.UseVisualStyleBackColor = true;
            this.cmdFilterByProjectAddress.Click += new System.EventHandler(this.cmdFilterByProjectAddress_Click);
            // 
            // cmdRemFilterByClientName
            // 
            this.cmdRemFilterByClientName.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemFilterByClientName.Location = new System.Drawing.Point(453, 29);
            this.cmdRemFilterByClientName.Name = "cmdRemFilterByClientName";
            this.cmdRemFilterByClientName.Size = new System.Drawing.Size(111, 23);
            this.cmdRemFilterByClientName.TabIndex = 3;
            this.cmdRemFilterByClientName.Text = "Remove Filter";
            this.cmdRemFilterByClientName.UseVisualStyleBackColor = true;
            this.cmdRemFilterByClientName.Click += new System.EventHandler(this.cmdRemFilterByClientName_Click);
            // 
            // cmdRemFilterByProjectAddress
            // 
            this.cmdRemFilterByProjectAddress.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemFilterByProjectAddress.Location = new System.Drawing.Point(453, 59);
            this.cmdRemFilterByProjectAddress.Name = "cmdRemFilterByProjectAddress";
            this.cmdRemFilterByProjectAddress.Size = new System.Drawing.Size(111, 23);
            this.cmdRemFilterByProjectAddress.TabIndex = 6;
            this.cmdRemFilterByProjectAddress.Text = "Remove Filter";
            this.cmdRemFilterByProjectAddress.UseVisualStyleBackColor = true;
            this.cmdRemFilterByProjectAddress.Click += new System.EventHandler(this.cmdRemFilterByProjectAddress_Click);
            // 
            // cmdRemFilterByProjectTown
            // 
            this.cmdRemFilterByProjectTown.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemFilterByProjectTown.Location = new System.Drawing.Point(453, 89);
            this.cmdRemFilterByProjectTown.Name = "cmdRemFilterByProjectTown";
            this.cmdRemFilterByProjectTown.Size = new System.Drawing.Size(111, 23);
            this.cmdRemFilterByProjectTown.TabIndex = 10;
            this.cmdRemFilterByProjectTown.Text = "Remove Filter";
            this.cmdRemFilterByProjectTown.UseVisualStyleBackColor = true;
            this.cmdRemFilterByProjectTown.Click += new System.EventHandler(this.cmdRemFilterByProjectTown_Click);
            // 
            // cmdFilterByProjectTown
            // 
            this.cmdFilterByProjectTown.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFilterByProjectTown.Location = new System.Drawing.Point(372, 89);
            this.cmdFilterByProjectTown.Name = "cmdFilterByProjectTown";
            this.cmdFilterByProjectTown.Size = new System.Drawing.Size(75, 23);
            this.cmdFilterByProjectTown.TabIndex = 9;
            this.cmdFilterByProjectTown.Text = "Filter";
            this.cmdFilterByProjectTown.UseVisualStyleBackColor = true;
            this.cmdFilterByProjectTown.Click += new System.EventHandler(this.cmdFilterByProjectTown_Click);
            // 
            // txtByProjectTown
            // 
            this.txtByProjectTown.Location = new System.Drawing.Point(123, 89);
            this.txtByProjectTown.Name = "txtByProjectTown";
            this.txtByProjectTown.Size = new System.Drawing.Size(243, 24);
            this.txtByProjectTown.TabIndex = 8;
            this.txtByProjectTown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtByProjectTown_KeyPress);
            // 
            // lblByProjectTown
            // 
            this.lblByProjectTown.AutoSize = true;
            this.lblByProjectTown.Location = new System.Drawing.Point(13, 92);
            this.lblByProjectTown.Name = "lblByProjectTown";
            this.lblByProjectTown.Size = new System.Drawing.Size(108, 17);
            this.lblByProjectTown.TabIndex = 7;
            this.lblByProjectTown.Text = "by Project Town:";
            // 
            // cmdRemFilterByProjectState
            // 
            this.cmdRemFilterByProjectState.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemFilterByProjectState.Location = new System.Drawing.Point(453, 119);
            this.cmdRemFilterByProjectState.Name = "cmdRemFilterByProjectState";
            this.cmdRemFilterByProjectState.Size = new System.Drawing.Size(111, 23);
            this.cmdRemFilterByProjectState.TabIndex = 14;
            this.cmdRemFilterByProjectState.Text = "Remove Filter";
            this.cmdRemFilterByProjectState.UseVisualStyleBackColor = true;
            this.cmdRemFilterByProjectState.Click += new System.EventHandler(this.cmdRemFilterByProjectState_Click);
            // 
            // cmdFilterByProjectState
            // 
            this.cmdFilterByProjectState.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFilterByProjectState.Location = new System.Drawing.Point(372, 119);
            this.cmdFilterByProjectState.Name = "cmdFilterByProjectState";
            this.cmdFilterByProjectState.Size = new System.Drawing.Size(75, 23);
            this.cmdFilterByProjectState.TabIndex = 13;
            this.cmdFilterByProjectState.Text = "Filter";
            this.cmdFilterByProjectState.UseVisualStyleBackColor = true;
            this.cmdFilterByProjectState.Click += new System.EventHandler(this.cmdFilterByProjectState_Click);
            // 
            // txtByProjectState
            // 
            this.txtByProjectState.Location = new System.Drawing.Point(123, 119);
            this.txtByProjectState.Name = "txtByProjectState";
            this.txtByProjectState.Size = new System.Drawing.Size(243, 24);
            this.txtByProjectState.TabIndex = 12;
            this.txtByProjectState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtByProjectState_KeyPress);
            // 
            // lblByProjectState
            // 
            this.lblByProjectState.AutoSize = true;
            this.lblByProjectState.Location = new System.Drawing.Point(21, 122);
            this.lblByProjectState.Name = "lblByProjectState";
            this.lblByProjectState.Size = new System.Drawing.Size(100, 17);
            this.lblByProjectState.TabIndex = 11;
            this.lblByProjectState.Text = "by Project State:";
            // 
            // cmdRemFilterByProjectContact
            // 
            this.cmdRemFilterByProjectContact.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemFilterByProjectContact.Location = new System.Drawing.Point(453, 149);
            this.cmdRemFilterByProjectContact.Name = "cmdRemFilterByProjectContact";
            this.cmdRemFilterByProjectContact.Size = new System.Drawing.Size(111, 23);
            this.cmdRemFilterByProjectContact.TabIndex = 18;
            this.cmdRemFilterByProjectContact.Text = "Remove Filter";
            this.cmdRemFilterByProjectContact.UseVisualStyleBackColor = true;
            this.cmdRemFilterByProjectContact.Click += new System.EventHandler(this.cmdRemFilterByProjectContact_Click);
            // 
            // cmdFilterByProjectContact
            // 
            this.cmdFilterByProjectContact.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFilterByProjectContact.Location = new System.Drawing.Point(372, 149);
            this.cmdFilterByProjectContact.Name = "cmdFilterByProjectContact";
            this.cmdFilterByProjectContact.Size = new System.Drawing.Size(75, 23);
            this.cmdFilterByProjectContact.TabIndex = 17;
            this.cmdFilterByProjectContact.Text = "Filter";
            this.cmdFilterByProjectContact.UseVisualStyleBackColor = true;
            this.cmdFilterByProjectContact.Click += new System.EventHandler(this.cmdFilterByProjectContact_Click);
            // 
            // txtByProjectContact
            // 
            this.txtByProjectContact.Location = new System.Drawing.Point(123, 149);
            this.txtByProjectContact.Name = "txtByProjectContact";
            this.txtByProjectContact.Size = new System.Drawing.Size(243, 24);
            this.txtByProjectContact.TabIndex = 16;
            this.txtByProjectContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtByProjectContact_KeyPress);
            // 
            // lblByProjectContact
            // 
            this.lblByProjectContact.AutoSize = true;
            this.lblByProjectContact.Location = new System.Drawing.Point(3, 152);
            this.lblByProjectContact.Name = "lblByProjectContact";
            this.lblByProjectContact.Size = new System.Drawing.Size(118, 17);
            this.lblByProjectContact.TabIndex = 15;
            this.lblByProjectContact.Text = "by Project Contact:";
            // 
            // lblCurrByContact
            // 
            this.lblCurrByContact.AutoSize = true;
            this.lblCurrByContact.Location = new System.Drawing.Point(59, 152);
            this.lblCurrByContact.Name = "lblCurrByContact";
            this.lblCurrByContact.Size = new System.Drawing.Size(118, 17);
            this.lblCurrByContact.TabIndex = 24;
            this.lblCurrByContact.Text = "by Project Contact:";
            // 
            // lblCurrByState
            // 
            this.lblCurrByState.AutoSize = true;
            this.lblCurrByState.Location = new System.Drawing.Point(77, 122);
            this.lblCurrByState.Name = "lblCurrByState";
            this.lblCurrByState.Size = new System.Drawing.Size(100, 17);
            this.lblCurrByState.TabIndex = 23;
            this.lblCurrByState.Text = "by Project State:";
            // 
            // lblCurrByTown
            // 
            this.lblCurrByTown.AutoSize = true;
            this.lblCurrByTown.Location = new System.Drawing.Point(69, 92);
            this.lblCurrByTown.Name = "lblCurrByTown";
            this.lblCurrByTown.Size = new System.Drawing.Size(108, 17);
            this.lblCurrByTown.TabIndex = 22;
            this.lblCurrByTown.Text = "by Project Town:";
            // 
            // lblCurrByAddress
            // 
            this.lblCurrByAddress.AutoSize = true;
            this.lblCurrByAddress.Location = new System.Drawing.Point(57, 62);
            this.lblCurrByAddress.Name = "lblCurrByAddress";
            this.lblCurrByAddress.Size = new System.Drawing.Size(120, 17);
            this.lblCurrByAddress.TabIndex = 21;
            this.lblCurrByAddress.Text = "by Project Address:";
            // 
            // lblCurrByClient
            // 
            this.lblCurrByClient.AutoSize = true;
            this.lblCurrByClient.Location = new System.Drawing.Point(75, 32);
            this.lblCurrByClient.Name = "lblCurrByClient";
            this.lblCurrByClient.Size = new System.Drawing.Size(102, 17);
            this.lblCurrByClient.TabIndex = 20;
            this.lblCurrByClient.Text = "by Client Name:";
            // 
            // lblCurrFilters
            // 
            this.lblCurrFilters.AutoSize = true;
            this.lblCurrFilters.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrFilters.Location = new System.Drawing.Point(8, 4);
            this.lblCurrFilters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrFilters.Name = "lblCurrFilters";
            this.lblCurrFilters.Size = new System.Drawing.Size(169, 18);
            this.lblCurrFilters.TabIndex = 19;
            this.lblCurrFilters.Text = "Currently Applied Filters:";
            // 
            // lblCurrFilterByClientName
            // 
            this.lblCurrFilterByClientName.AutoSize = true;
            this.lblCurrFilterByClientName.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrFilterByClientName.Location = new System.Drawing.Point(183, 32);
            this.lblCurrFilterByClientName.Name = "lblCurrFilterByClientName";
            this.lblCurrFilterByClientName.Size = new System.Drawing.Size(81, 17);
            this.lblCurrFilterByClientName.TabIndex = 25;
            this.lblCurrFilterByClientName.Text = "placeholder";
            // 
            // lblCurrFilterByAddress
            // 
            this.lblCurrFilterByAddress.AutoSize = true;
            this.lblCurrFilterByAddress.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrFilterByAddress.Location = new System.Drawing.Point(183, 62);
            this.lblCurrFilterByAddress.Name = "lblCurrFilterByAddress";
            this.lblCurrFilterByAddress.Size = new System.Drawing.Size(81, 17);
            this.lblCurrFilterByAddress.TabIndex = 26;
            this.lblCurrFilterByAddress.Text = "placeholder";
            // 
            // lblCurrFilterByTown
            // 
            this.lblCurrFilterByTown.AutoSize = true;
            this.lblCurrFilterByTown.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrFilterByTown.Location = new System.Drawing.Point(183, 92);
            this.lblCurrFilterByTown.Name = "lblCurrFilterByTown";
            this.lblCurrFilterByTown.Size = new System.Drawing.Size(81, 17);
            this.lblCurrFilterByTown.TabIndex = 27;
            this.lblCurrFilterByTown.Text = "placeholder";
            // 
            // lblCurrFilterByState
            // 
            this.lblCurrFilterByState.AutoSize = true;
            this.lblCurrFilterByState.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrFilterByState.Location = new System.Drawing.Point(183, 122);
            this.lblCurrFilterByState.Name = "lblCurrFilterByState";
            this.lblCurrFilterByState.Size = new System.Drawing.Size(81, 17);
            this.lblCurrFilterByState.TabIndex = 28;
            this.lblCurrFilterByState.Text = "placeholder";
            // 
            // lblCurrFilterByContact
            // 
            this.lblCurrFilterByContact.AutoSize = true;
            this.lblCurrFilterByContact.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrFilterByContact.Location = new System.Drawing.Point(183, 152);
            this.lblCurrFilterByContact.Name = "lblCurrFilterByContact";
            this.lblCurrFilterByContact.Size = new System.Drawing.Size(81, 17);
            this.lblCurrFilterByContact.TabIndex = 29;
            this.lblCurrFilterByContact.Text = "placeholder";
            // 
            // lblResultsCount
            // 
            this.lblResultsCount.AutoSize = true;
            this.lblResultsCount.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultsCount.Location = new System.Drawing.Point(108, 213);
            this.lblResultsCount.Name = "lblResultsCount";
            this.lblResultsCount.Size = new System.Drawing.Size(81, 17);
            this.lblResultsCount.TabIndex = 33;
            this.lblResultsCount.Text = "placeholder";
            // 
            // lblNumRecsLabel
            // 
            this.lblNumRecsLabel.AutoSize = true;
            this.lblNumRecsLabel.Location = new System.Drawing.Point(15, 213);
            this.lblNumRecsLabel.Name = "lblNumRecsLabel";
            this.lblNumRecsLabel.Size = new System.Drawing.Size(90, 17);
            this.lblNumRecsLabel.TabIndex = 32;
            this.lblNumRecsLabel.Text = "Results Count:";
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdRemFilterByProjectContact);
            this.panel2.Controls.Add(this.cmdFilterByProjectContact);
            this.panel2.Controls.Add(this.txtByProjectContact);
            this.panel2.Controls.Add(this.cmdRemFilterByProjectState);
            this.panel2.Controls.Add(this.lblByProjectContact);
            this.panel2.Controls.Add(this.cmdFilterByProjectState);
            this.panel2.Controls.Add(this.lblByProjectAddress);
            this.panel2.Controls.Add(this.txtByProjectState);
            this.panel2.Controls.Add(this.lblByProjectState);
            this.panel2.Controls.Add(this.cmdRemFilterByProjectTown);
            this.panel2.Controls.Add(this.cmdFilterByProjectTown);
            this.panel2.Controls.Add(this.txtByProjectTown);
            this.panel2.Controls.Add(this.lblByProjectTown);
            this.panel2.Controls.Add(this.cmdRemFilterByProjectAddress);
            this.panel2.Controls.Add(this.cmdRemFilterByClientName);
            this.panel2.Controls.Add(this.cmdFilterByProjectAddress);
            this.panel2.Controls.Add(this.cmdFilterByClientName);
            this.panel2.Controls.Add(this.txtByClientName);
            this.panel2.Controls.Add(this.txtByProjectAddress);
            this.panel2.Controls.Add(this.lblByClientName);
            this.panel2.Controls.Add(this.lblFilterLabel);
            this.panel2.Location = new System.Drawing.Point(12, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 179);
            this.panel2.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCurrFilterByContact);
            this.panel3.Controls.Add(this.lblCurrFilterByState);
            this.panel3.Controls.Add(this.lblCurrFilterByTown);
            this.panel3.Controls.Add(this.lblCurrFilterByAddress);
            this.panel3.Controls.Add(this.lblCurrFilterByClientName);
            this.panel3.Controls.Add(this.lblCurrByContact);
            this.panel3.Controls.Add(this.lblCurrByState);
            this.panel3.Controls.Add(this.lblCurrByTown);
            this.panel3.Controls.Add(this.lblCurrByAddress);
            this.panel3.Controls.Add(this.lblCurrByClient);
            this.panel3.Controls.Add(this.lblCurrFilters);
            this.panel3.Location = new System.Drawing.Point(596, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 179);
            this.panel3.TabIndex = 37;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.recordsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.includeArchiveRecordsPreJCTSToolStripMenuItem});
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.recordsToolStripMenuItem.Text = "Re&cords";
            // 
            // includeArchiveRecordsPreJCTSToolStripMenuItem
            // 
            this.includeArchiveRecordsPreJCTSToolStripMenuItem.CheckOnClick = true;
            this.includeArchiveRecordsPreJCTSToolStripMenuItem.Name = "includeArchiveRecordsPreJCTSToolStripMenuItem";
            this.includeArchiveRecordsPreJCTSToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.includeArchiveRecordsPreJCTSToolStripMenuItem.Text = "Include &Archive Records (Pre-JCTS)";
            this.includeArchiveRecordsPreJCTSToolStripMenuItem.Click += new System.EventHandler(this.includeArchiveRecordsPreJCTSToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPrintReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Re&ports";
            // 
            // showPrintReportToolStripMenuItem
            // 
            this.showPrintReportToolStripMenuItem.Name = "showPrintReportToolStripMenuItem";
            this.showPrintReportToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.showPrintReportToolStripMenuItem.Text = "Show Print Report";
            this.showPrintReportToolStripMenuItem.Click += new System.EventHandler(this.showPrintReportToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.versionToolStripMenuItem.Text = "&Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmJobBroswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 563);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblResultsCount);
            this.Controls.Add(this.lblNumRecsLabel);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmJobBroswer";
            this.Text = "Job Broswer";
            this.Load += new System.EventHandler(this.frmJobBroswer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdenengrDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdenengrDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.BindingSource holdenengrDataSetBindingSource;
        private holdenengrDataSet holdenengrDataSet;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private holdenengrDataSetTableAdapters.jobTableAdapter jobTableAdapter;
        private System.Windows.Forms.Label lblFilterLabel;
        private System.Windows.Forms.Label lblByClientName;
        private System.Windows.Forms.Label lblByProjectAddress;
        private System.Windows.Forms.TextBox txtByProjectAddress;
        private System.Windows.Forms.TextBox txtByClientName;
        private System.Windows.Forms.Button cmdFilterByClientName;
        private System.Windows.Forms.Button cmdFilterByProjectAddress;
        private System.Windows.Forms.Button cmdRemFilterByClientName;
        private System.Windows.Forms.Button cmdRemFilterByProjectAddress;
        private System.Windows.Forms.Button cmdRemFilterByProjectTown;
        private System.Windows.Forms.Button cmdFilterByProjectTown;
        private System.Windows.Forms.TextBox txtByProjectTown;
        private System.Windows.Forms.Label lblByProjectTown;
        private System.Windows.Forms.Button cmdRemFilterByProjectState;
        private System.Windows.Forms.Button cmdFilterByProjectState;
        private System.Windows.Forms.TextBox txtByProjectState;
        private System.Windows.Forms.Label lblByProjectState;
        private System.Windows.Forms.Button cmdRemFilterByProjectContact;
        private System.Windows.Forms.Button cmdFilterByProjectContact;
        private System.Windows.Forms.TextBox txtByProjectContact;
        private System.Windows.Forms.Label lblByProjectContact;
        private System.Windows.Forms.Label lblCurrByContact;
        private System.Windows.Forms.Label lblCurrByState;
        private System.Windows.Forms.Label lblCurrByTown;
        private System.Windows.Forms.Label lblCurrByAddress;
        private System.Windows.Forms.Label lblCurrByClient;
        private System.Windows.Forms.Label lblCurrFilters;
        private System.Windows.Forms.Label lblCurrFilterByClientName;
        private System.Windows.Forms.Label lblCurrFilterByAddress;
        private System.Windows.Forms.Label lblCurrFilterByTown;
        private System.Windows.Forms.Label lblCurrFilterByState;
        private System.Windows.Forms.Label lblCurrFilterByContact;
        private System.Windows.Forms.Label lblResultsCount;
        private System.Windows.Forms.Label lblNumRecsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobjobkeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobccodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobdescrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobaddr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobaddr3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobcityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobpcontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobdescr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem includeArchiveRecordsPreJCTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPrintReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

