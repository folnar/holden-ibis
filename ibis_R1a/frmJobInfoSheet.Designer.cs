namespace ibis_R1a
{
    partial class frmJobInfoSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobInfoSheet));
            this.chkbxNewJob = new System.Windows.Forms.CheckBox();
            this.chkbxRevisedInfo = new System.Windows.Forms.CheckBox();
            this.lblJobInfoSheetTitle = new System.Windows.Forms.Label();
            this.lblCompanyRadioGrp = new System.Windows.Forms.Label();
            this.lblPersonFillingOutForm = new System.Windows.Forms.Label();
            this.lblIsAmendment = new System.Windows.Forms.Label();
            this.lblIfYesExistingJobNo = new System.Windows.Forms.Label();
            this.lblIfAnAmendment = new System.Windows.Forms.Label();
            this.lblNextAvailSuffix = new System.Windows.Forms.Label();
            this.lblNewSuffPref = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.txtNewSuffixPref = new System.Windows.Forms.TextBox();
            this.lbl2orMore = new System.Windows.Forms.Label();
            this.lvlJobNumsInvoicedTogether = new System.Windows.Forms.Label();
            this.lblIfSo = new System.Windows.Forms.Label();
            this.txtJobNumsInvoicedTogether = new System.Windows.Forms.TextBox();
            this.lblHorDivider1A = new System.Windows.Forms.Label();
            this.lblHorDivider1B = new System.Windows.Forms.Label();
            this.lblTodaysDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTodaysDate = new System.Windows.Forms.TextBox();
            this.lblJobNum = new System.Windows.Forms.Label();
            this.txtJobNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInvoiceType = new System.Windows.Forms.Label();
            this.lblClientType = new System.Windows.Forms.Label();
            this.lblProjectDueDate = new System.Windows.Forms.Label();
            this.txtProjectDueDate = new System.Windows.Forms.TextBox();
            this.lblOTAllowed = new System.Windows.Forms.Label();
            this.lblProjMgr1 = new System.Windows.Forms.Label();
            this.ddProjMgr1 = new System.Windows.Forms.ComboBox();
            this.ddProjMgr2 = new System.Windows.Forms.ComboBox();
            this.lblProjMgr2 = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.panelCompany = new System.Windows.Forms.Panel();
            this.radioCompany_HES = new System.Windows.Forms.RadioButton();
            this.radioCompany_NEEA = new System.Windows.Forms.RadioButton();
            this.radioCompany_HGPS = new System.Windows.Forms.RadioButton();
            this.radioCompany_ECM = new System.Windows.Forms.RadioButton();
            this.panelIsAmendment = new System.Windows.Forms.Panel();
            this.radioIsAmendment_Yes = new System.Windows.Forms.RadioButton();
            this.radioIsAmendment_No = new System.Windows.Forms.RadioButton();
            this.panelNextSuffix = new System.Windows.Forms.Panel();
            this.radioNextAvailableSuffix_No = new System.Windows.Forms.RadioButton();
            this.radioNextAvailableSuffix_Yes = new System.Windows.Forms.RadioButton();
            this.panelSameClientInvoice = new System.Windows.Forms.Panel();
            this.radioSameClientInvoice_No = new System.Windows.Forms.RadioButton();
            this.radioSameClientInvoice_Yes = new System.Windows.Forms.RadioButton();
            this.panelOTAllowed = new System.Windows.Forms.Panel();
            this.radioOTAllowed_No = new System.Windows.Forms.RadioButton();
            this.radioOTAllowed_Yes = new System.Windows.Forms.RadioButton();
            this.txtClientContactPerson = new System.Windows.Forms.TextBox();
            this.lblClientContactPerson = new System.Windows.Forms.Label();
            this.txtClientAddress = new System.Windows.Forms.TextBox();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.txtClientCity = new System.Windows.Forms.TextBox();
            this.lblClientCity = new System.Windows.Forms.Label();
            this.txtClientZip = new System.Windows.Forms.TextBox();
            this.lblClientZip = new System.Windows.Forms.Label();
            this.ibiscbxClientName = new IbisUtils.IbisComboBox();
            this.ibiscbxExistingJobNum = new IbisUtils.IbisComboBox();
            this.ibiscbxFilledOutBy = new IbisUtils.IbisComboBox();
            this.ibiscbxClientType = new IbisUtils.IbisComboBox();
            this.ibiscbxProjectType = new IbisUtils.IbisComboBox();
            this.ibiscbxInvoiceType = new IbisUtils.IbisComboBox();
            this.ibiscbxClientState = new IbisUtils.IbisComboBox();
            this.lblClientState = new System.Windows.Forms.Label();
            this.lblClientCode = new System.Windows.Forms.Label();
            this.txtClientCode = new System.Windows.Forms.TextBox();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.lblClientEmail = new System.Windows.Forms.Label();
            this.lblExt = new System.Windows.Forms.Label();
            this.txtClientFax = new System.Windows.Forms.TextBox();
            this.lblClientFax = new System.Windows.Forms.Label();
            this.txtClientBusinessNum = new System.Windows.Forms.TextBox();
            this.lblClientBusinessNum = new System.Windows.Forms.Label();
            this.txtClientBusinessNumExt = new System.Windows.Forms.TextBox();
            this.panelCompany.SuspendLayout();
            this.panelIsAmendment.SuspendLayout();
            this.panelNextSuffix.SuspendLayout();
            this.panelSameClientInvoice.SuspendLayout();
            this.panelOTAllowed.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkbxNewJob
            // 
            this.chkbxNewJob.AutoSize = true;
            this.chkbxNewJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxNewJob.Location = new System.Drawing.Point(407, 13);
            this.chkbxNewJob.Name = "chkbxNewJob";
            this.chkbxNewJob.Size = new System.Drawing.Size(80, 20);
            this.chkbxNewJob.TabIndex = 1;
            this.chkbxNewJob.Text = "New Job";
            this.chkbxNewJob.UseVisualStyleBackColor = true;
            // 
            // chkbxRevisedInfo
            // 
            this.chkbxRevisedInfo.AutoSize = true;
            this.chkbxRevisedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxRevisedInfo.Location = new System.Drawing.Point(407, 36);
            this.chkbxRevisedInfo.Name = "chkbxRevisedInfo";
            this.chkbxRevisedInfo.Size = new System.Drawing.Size(195, 20);
            this.chkbxRevisedInfo.TabIndex = 2;
            this.chkbxRevisedInfo.Text = "Revised Info for Existing Job";
            this.chkbxRevisedInfo.UseVisualStyleBackColor = true;
            // 
            // lblJobInfoSheetTitle
            // 
            this.lblJobInfoSheetTitle.AutoSize = true;
            this.lblJobInfoSheetTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobInfoSheetTitle.Location = new System.Drawing.Point(14, 9);
            this.lblJobInfoSheetTitle.Name = "lblJobInfoSheetTitle";
            this.lblJobInfoSheetTitle.Size = new System.Drawing.Size(242, 25);
            this.lblJobInfoSheetTitle.TabIndex = 2;
            this.lblJobInfoSheetTitle.Text = "Job Information Sheet";
            // 
            // lblCompanyRadioGrp
            // 
            this.lblCompanyRadioGrp.AutoSize = true;
            this.lblCompanyRadioGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyRadioGrp.Location = new System.Drawing.Point(16, 79);
            this.lblCompanyRadioGrp.Name = "lblCompanyRadioGrp";
            this.lblCompanyRadioGrp.Size = new System.Drawing.Size(77, 16);
            this.lblCompanyRadioGrp.TabIndex = 4;
            this.lblCompanyRadioGrp.Text = "Company:";
            // 
            // lblPersonFillingOutForm
            // 
            this.lblPersonFillingOutForm.AutoSize = true;
            this.lblPersonFillingOutForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonFillingOutForm.Location = new System.Drawing.Point(16, 108);
            this.lblPersonFillingOutForm.Name = "lblPersonFillingOutForm";
            this.lblPersonFillingOutForm.Size = new System.Drawing.Size(173, 16);
            this.lblPersonFillingOutForm.TabIndex = 8;
            this.lblPersonFillingOutForm.Text = "This Form Filled Out By:";
            // 
            // lblIsAmendment
            // 
            this.lblIsAmendment.AutoSize = true;
            this.lblIsAmendment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsAmendment.Location = new System.Drawing.Point(16, 139);
            this.lblIsAmendment.Name = "lblIsAmendment";
            this.lblIsAmendment.Size = new System.Drawing.Size(349, 16);
            this.lblIsAmendment.TabIndex = 10;
            this.lblIsAmendment.Text = "Is This an Amendment to an Existing Project No.?:";
            // 
            // lblIfYesExistingJobNo
            // 
            this.lblIfYesExistingJobNo.AutoSize = true;
            this.lblIfYesExistingJobNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIfYesExistingJobNo.Location = new System.Drawing.Point(477, 139);
            this.lblIfYesExistingJobNo.Name = "lblIfYesExistingJobNo";
            this.lblIfYesExistingJobNo.Size = new System.Drawing.Size(122, 16);
            this.lblIfYesExistingJobNo.TabIndex = 13;
            this.lblIfYesExistingJobNo.Text = "If yes, existing job #";
            // 
            // lblIfAnAmendment
            // 
            this.lblIfAnAmendment.AutoSize = true;
            this.lblIfAnAmendment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIfAnAmendment.Location = new System.Drawing.Point(112, 164);
            this.lblIfAnAmendment.Name = "lblIfAnAmendment";
            this.lblIfAnAmendment.Size = new System.Drawing.Size(126, 16);
            this.lblIfAnAmendment.TabIndex = 15;
            this.lblIfAnAmendment.Text = "If an Amendment:";
            // 
            // lblNextAvailSuffix
            // 
            this.lblNextAvailSuffix.AutoSize = true;
            this.lblNextAvailSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextAvailSuffix.Location = new System.Drawing.Point(244, 164);
            this.lblNextAvailSuffix.Name = "lblNextAvailSuffix";
            this.lblNextAvailSuffix.Size = new System.Drawing.Size(136, 16);
            this.lblNextAvailSuffix.TabIndex = 16;
            this.lblNextAvailSuffix.Text = "Next Available Suffix?";
            // 
            // lblNewSuffPref
            // 
            this.lblNewSuffPref.AutoSize = true;
            this.lblNewSuffPref.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewSuffPref.Location = new System.Drawing.Point(501, 164);
            this.lblNewSuffPref.Name = "lblNewSuffPref";
            this.lblNewSuffPref.Size = new System.Drawing.Size(138, 16);
            this.lblNewSuffPref.TabIndex = 19;
            this.lblNewSuffPref.Text = "New suffix preference:";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOr.Location = new System.Drawing.Point(485, 164);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(20, 16);
            this.lblOr.TabIndex = 20;
            this.lblOr.Text = "or";
            // 
            // txtNewSuffixPref
            // 
            this.txtNewSuffixPref.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewSuffixPref.Location = new System.Drawing.Point(645, 162);
            this.txtNewSuffixPref.Name = "txtNewSuffixPref";
            this.txtNewSuffixPref.Size = new System.Drawing.Size(100, 22);
            this.txtNewSuffixPref.TabIndex = 13;
            // 
            // lbl2orMore
            // 
            this.lbl2orMore.AutoSize = true;
            this.lbl2orMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2orMore.Location = new System.Drawing.Point(112, 190);
            this.lbl2orMore.Name = "lbl2orMore";
            this.lbl2orMore.Size = new System.Drawing.Size(383, 16);
            this.lbl2orMore.TabIndex = 22;
            this.lbl2orMore.Text = "Will two or more job #s for the same client be invoiced together?";
            // 
            // lvlJobNumsInvoicedTogether
            // 
            this.lvlJobNumsInvoicedTogether.AutoSize = true;
            this.lvlJobNumsInvoicedTogether.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlJobNumsInvoicedTogether.Location = new System.Drawing.Point(112, 215);
            this.lvlJobNumsInvoicedTogether.Name = "lvlJobNumsInvoicedTogether";
            this.lvlJobNumsInvoicedTogether.Size = new System.Drawing.Size(321, 16);
            this.lvlJobNumsInvoicedTogether.TabIndex = 25;
            this.lvlJobNumsInvoicedTogether.Text = "list job #s and suffixes which will be invoiced together.";
            // 
            // lblIfSo
            // 
            this.lblIfSo.AutoSize = true;
            this.lblIfSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIfSo.Location = new System.Drawing.Point(609, 190);
            this.lblIfSo.Name = "lblIfSo";
            this.lblIfSo.Size = new System.Drawing.Size(35, 16);
            this.lblIfSo.TabIndex = 26;
            this.lblIfSo.Text = "If so,";
            // 
            // txtJobNumsInvoicedTogether
            // 
            this.txtJobNumsInvoicedTogether.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobNumsInvoicedTogether.Location = new System.Drawing.Point(439, 212);
            this.txtJobNumsInvoicedTogether.Name = "txtJobNumsInvoicedTogether";
            this.txtJobNumsInvoicedTogether.Size = new System.Drawing.Size(306, 22);
            this.txtJobNumsInvoicedTogether.TabIndex = 16;
            // 
            // lblHorDivider1A
            // 
            this.lblHorDivider1A.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHorDivider1A.Location = new System.Drawing.Point(10, 242);
            this.lblHorDivider1A.Name = "lblHorDivider1A";
            this.lblHorDivider1A.Size = new System.Drawing.Size(947, 2);
            this.lblHorDivider1A.TabIndex = 28;
            // 
            // lblHorDivider1B
            // 
            this.lblHorDivider1B.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHorDivider1B.Location = new System.Drawing.Point(10, 246);
            this.lblHorDivider1B.Name = "lblHorDivider1B";
            this.lblHorDivider1B.Size = new System.Drawing.Size(947, 2);
            this.lblHorDivider1B.TabIndex = 30;
            // 
            // lblTodaysDate
            // 
            this.lblTodaysDate.AutoSize = true;
            this.lblTodaysDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysDate.Location = new System.Drawing.Point(16, 258);
            this.lblTodaysDate.Name = "lblTodaysDate";
            this.lblTodaysDate.Size = new System.Drawing.Size(106, 16);
            this.lblTodaysDate.TabIndex = 31;
            this.lblTodaysDate.Text = "Today\'s Date:";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(11, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(947, 2);
            this.label1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(11, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(947, 2);
            this.label2.TabIndex = 32;
            // 
            // txtTodaysDate
            // 
            this.txtTodaysDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTodaysDate.Location = new System.Drawing.Point(128, 255);
            this.txtTodaysDate.Name = "txtTodaysDate";
            this.txtTodaysDate.Size = new System.Drawing.Size(110, 22);
            this.txtTodaysDate.TabIndex = 17;
            this.txtTodaysDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblJobNum
            // 
            this.lblJobNum.AutoSize = true;
            this.lblJobNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobNum.Location = new System.Drawing.Point(258, 258);
            this.lblJobNum.Name = "lblJobNum";
            this.lblJobNum.Size = new System.Drawing.Size(50, 16);
            this.lblJobNum.TabIndex = 35;
            this.lblJobNum.Text = "Job #:";
            // 
            // txtJobNum
            // 
            this.txtJobNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobNum.Location = new System.Drawing.Point(314, 255);
            this.txtJobNum.Name = "txtJobNum";
            this.txtJobNum.Size = new System.Drawing.Size(172, 22);
            this.txtJobNum.TabIndex = 18;
            this.txtJobNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Project Type:";
            // 
            // lblInvoiceType
            // 
            this.lblInvoiceType.AutoSize = true;
            this.lblInvoiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceType.Location = new System.Drawing.Point(504, 258);
            this.lblInvoiceType.Name = "lblInvoiceType";
            this.lblInvoiceType.Size = new System.Drawing.Size(102, 16);
            this.lblInvoiceType.TabIndex = 39;
            this.lblInvoiceType.Text = "Invoice Type:";
            // 
            // lblClientType
            // 
            this.lblClientType.AutoSize = true;
            this.lblClientType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientType.Location = new System.Drawing.Point(548, 285);
            this.lblClientType.Name = "lblClientType";
            this.lblClientType.Size = new System.Drawing.Size(91, 16);
            this.lblClientType.TabIndex = 41;
            this.lblClientType.Text = "Client Type:";
            // 
            // lblProjectDueDate
            // 
            this.lblProjectDueDate.AutoSize = true;
            this.lblProjectDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectDueDate.Location = new System.Drawing.Point(16, 315);
            this.lblProjectDueDate.Name = "lblProjectDueDate";
            this.lblProjectDueDate.Size = new System.Drawing.Size(256, 16);
            this.lblProjectDueDate.TabIndex = 43;
            this.lblProjectDueDate.Text = "Project Due Date or Milestone Date:";
            // 
            // txtProjectDueDate
            // 
            this.txtProjectDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectDueDate.Location = new System.Drawing.Point(278, 312);
            this.txtProjectDueDate.Name = "txtProjectDueDate";
            this.txtProjectDueDate.Size = new System.Drawing.Size(110, 22);
            this.txtProjectDueDate.TabIndex = 22;
            this.txtProjectDueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOTAllowed
            // 
            this.lblOTAllowed.AutoSize = true;
            this.lblOTAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTAllowed.Location = new System.Drawing.Point(404, 315);
            this.lblOTAllowed.Name = "lblOTAllowed";
            this.lblOTAllowed.Size = new System.Drawing.Size(137, 16);
            this.lblOTAllowed.TabIndex = 45;
            this.lblOTAllowed.Text = "Overtime Allowed?";
            // 
            // lblProjMgr1
            // 
            this.lblProjMgr1.AutoSize = true;
            this.lblProjMgr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjMgr1.Location = new System.Drawing.Point(16, 343);
            this.lblProjMgr1.Name = "lblProjMgr1";
            this.lblProjMgr1.Size = new System.Drawing.Size(103, 16);
            this.lblProjMgr1.TabIndex = 48;
            this.lblProjMgr1.Text = "Project Mgr. 1";
            // 
            // ddProjMgr1
            // 
            this.ddProjMgr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddProjMgr1.FormattingEnabled = true;
            this.ddProjMgr1.Location = new System.Drawing.Point(123, 340);
            this.ddProjMgr1.Name = "ddProjMgr1";
            this.ddProjMgr1.Size = new System.Drawing.Size(227, 24);
            this.ddProjMgr1.TabIndex = 25;
            // 
            // ddProjMgr2
            // 
            this.ddProjMgr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddProjMgr2.FormattingEnabled = true;
            this.ddProjMgr2.Location = new System.Drawing.Point(480, 340);
            this.ddProjMgr2.Name = "ddProjMgr2";
            this.ddProjMgr2.Size = new System.Drawing.Size(227, 24);
            this.ddProjMgr2.TabIndex = 26;
            // 
            // lblProjMgr2
            // 
            this.lblProjMgr2.AutoSize = true;
            this.lblProjMgr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjMgr2.Location = new System.Drawing.Point(373, 343);
            this.lblProjMgr2.Name = "lblProjMgr2";
            this.lblProjMgr2.Size = new System.Drawing.Size(103, 16);
            this.lblProjMgr2.TabIndex = 50;
            this.lblProjMgr2.Text = "Project Mgr. 2";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(16, 391);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(96, 16);
            this.lblClientName.TabIndex = 53;
            this.lblClientName.Text = "Client Name:";
            // 
            // panelCompany
            // 
            this.panelCompany.Controls.Add(this.radioCompany_HES);
            this.panelCompany.Controls.Add(this.radioCompany_NEEA);
            this.panelCompany.Controls.Add(this.radioCompany_HGPS);
            this.panelCompany.Controls.Add(this.radioCompany_ECM);
            this.panelCompany.Location = new System.Drawing.Point(98, 77);
            this.panelCompany.Name = "panelCompany";
            this.panelCompany.Size = new System.Drawing.Size(267, 20);
            this.panelCompany.TabIndex = 63;
            // 
            // radioCompany_HES
            // 
            this.radioCompany_HES.AutoSize = true;
            this.radioCompany_HES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCompany_HES.Location = new System.Drawing.Point(3, 0);
            this.radioCompany_HES.Name = "radioCompany_HES";
            this.radioCompany_HES.Size = new System.Drawing.Size(54, 20);
            this.radioCompany_HES.TabIndex = 3;
            this.radioCompany_HES.TabStop = true;
            this.radioCompany_HES.Text = "HES";
            this.radioCompany_HES.UseVisualStyleBackColor = true;
            // 
            // radioCompany_NEEA
            // 
            this.radioCompany_NEEA.AutoSize = true;
            this.radioCompany_NEEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCompany_NEEA.Location = new System.Drawing.Point(194, 0);
            this.radioCompany_NEEA.Name = "radioCompany_NEEA";
            this.radioCompany_NEEA.Size = new System.Drawing.Size(63, 20);
            this.radioCompany_NEEA.TabIndex = 6;
            this.radioCompany_NEEA.TabStop = true;
            this.radioCompany_NEEA.Text = "NEEA";
            this.radioCompany_NEEA.UseVisualStyleBackColor = true;
            // 
            // radioCompany_HGPS
            // 
            this.radioCompany_HGPS.AutoSize = true;
            this.radioCompany_HGPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCompany_HGPS.Location = new System.Drawing.Point(124, 0);
            this.radioCompany_HGPS.Name = "radioCompany_HGPS";
            this.radioCompany_HGPS.Size = new System.Drawing.Size(64, 20);
            this.radioCompany_HGPS.TabIndex = 5;
            this.radioCompany_HGPS.TabStop = true;
            this.radioCompany_HGPS.Text = "HGPS";
            this.radioCompany_HGPS.UseVisualStyleBackColor = true;
            // 
            // radioCompany_ECM
            // 
            this.radioCompany_ECM.AutoSize = true;
            this.radioCompany_ECM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCompany_ECM.Location = new System.Drawing.Point(63, 0);
            this.radioCompany_ECM.Name = "radioCompany_ECM";
            this.radioCompany_ECM.Size = new System.Drawing.Size(55, 20);
            this.radioCompany_ECM.TabIndex = 4;
            this.radioCompany_ECM.TabStop = true;
            this.radioCompany_ECM.Text = "ECM";
            this.radioCompany_ECM.UseVisualStyleBackColor = true;
            // 
            // panelIsAmendment
            // 
            this.panelIsAmendment.Controls.Add(this.radioIsAmendment_Yes);
            this.panelIsAmendment.Controls.Add(this.radioIsAmendment_No);
            this.panelIsAmendment.Location = new System.Drawing.Point(361, 131);
            this.panelIsAmendment.Name = "panelIsAmendment";
            this.panelIsAmendment.Size = new System.Drawing.Size(115, 29);
            this.panelIsAmendment.TabIndex = 64;
            // 
            // radioIsAmendment_Yes
            // 
            this.radioIsAmendment_Yes.AutoSize = true;
            this.radioIsAmendment_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIsAmendment_Yes.Location = new System.Drawing.Point(10, 6);
            this.radioIsAmendment_Yes.Name = "radioIsAmendment_Yes";
            this.radioIsAmendment_Yes.Size = new System.Drawing.Size(50, 20);
            this.radioIsAmendment_Yes.TabIndex = 8;
            this.radioIsAmendment_Yes.TabStop = true;
            this.radioIsAmendment_Yes.Text = "Yes";
            this.radioIsAmendment_Yes.UseVisualStyleBackColor = true;
            this.radioIsAmendment_Yes.CheckedChanged += new System.EventHandler(this.radioIsAmendment_Yes_CheckedChanged);
            // 
            // radioIsAmendment_No
            // 
            this.radioIsAmendment_No.AutoSize = true;
            this.radioIsAmendment_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIsAmendment_No.Location = new System.Drawing.Point(66, 6);
            this.radioIsAmendment_No.Name = "radioIsAmendment_No";
            this.radioIsAmendment_No.Size = new System.Drawing.Size(44, 20);
            this.radioIsAmendment_No.TabIndex = 9;
            this.radioIsAmendment_No.TabStop = true;
            this.radioIsAmendment_No.Text = "No";
            this.radioIsAmendment_No.UseVisualStyleBackColor = true;
            this.radioIsAmendment_No.CheckedChanged += new System.EventHandler(this.radioIsAmendment_No_CheckedChanged);
            // 
            // panelNextSuffix
            // 
            this.panelNextSuffix.Controls.Add(this.radioNextAvailableSuffix_No);
            this.panelNextSuffix.Controls.Add(this.radioNextAvailableSuffix_Yes);
            this.panelNextSuffix.Location = new System.Drawing.Point(376, 158);
            this.panelNextSuffix.Name = "panelNextSuffix";
            this.panelNextSuffix.Size = new System.Drawing.Size(115, 29);
            this.panelNextSuffix.TabIndex = 65;
            // 
            // radioNextAvailableSuffix_No
            // 
            this.radioNextAvailableSuffix_No.AutoSize = true;
            this.radioNextAvailableSuffix_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNextAvailableSuffix_No.Location = new System.Drawing.Point(63, 4);
            this.radioNextAvailableSuffix_No.Name = "radioNextAvailableSuffix_No";
            this.radioNextAvailableSuffix_No.Size = new System.Drawing.Size(44, 20);
            this.radioNextAvailableSuffix_No.TabIndex = 12;
            this.radioNextAvailableSuffix_No.TabStop = true;
            this.radioNextAvailableSuffix_No.Text = "No";
            this.radioNextAvailableSuffix_No.UseVisualStyleBackColor = true;
            // 
            // radioNextAvailableSuffix_Yes
            // 
            this.radioNextAvailableSuffix_Yes.AutoSize = true;
            this.radioNextAvailableSuffix_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNextAvailableSuffix_Yes.Location = new System.Drawing.Point(7, 4);
            this.radioNextAvailableSuffix_Yes.Name = "radioNextAvailableSuffix_Yes";
            this.radioNextAvailableSuffix_Yes.Size = new System.Drawing.Size(50, 20);
            this.radioNextAvailableSuffix_Yes.TabIndex = 11;
            this.radioNextAvailableSuffix_Yes.TabStop = true;
            this.radioNextAvailableSuffix_Yes.Text = "Yes";
            this.radioNextAvailableSuffix_Yes.UseVisualStyleBackColor = true;
            // 
            // panelSameClientInvoice
            // 
            this.panelSameClientInvoice.Controls.Add(this.radioSameClientInvoice_No);
            this.panelSameClientInvoice.Controls.Add(this.radioSameClientInvoice_Yes);
            this.panelSameClientInvoice.Location = new System.Drawing.Point(491, 183);
            this.panelSameClientInvoice.Name = "panelSameClientInvoice";
            this.panelSameClientInvoice.Size = new System.Drawing.Size(115, 29);
            this.panelSameClientInvoice.TabIndex = 66;
            // 
            // radioSameClientInvoice_No
            // 
            this.radioSameClientInvoice_No.AutoSize = true;
            this.radioSameClientInvoice_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSameClientInvoice_No.Location = new System.Drawing.Point(66, 5);
            this.radioSameClientInvoice_No.Name = "radioSameClientInvoice_No";
            this.radioSameClientInvoice_No.Size = new System.Drawing.Size(44, 20);
            this.radioSameClientInvoice_No.TabIndex = 15;
            this.radioSameClientInvoice_No.TabStop = true;
            this.radioSameClientInvoice_No.Text = "No";
            this.radioSameClientInvoice_No.UseVisualStyleBackColor = true;
            // 
            // radioSameClientInvoice_Yes
            // 
            this.radioSameClientInvoice_Yes.AutoSize = true;
            this.radioSameClientInvoice_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSameClientInvoice_Yes.Location = new System.Drawing.Point(10, 5);
            this.radioSameClientInvoice_Yes.Name = "radioSameClientInvoice_Yes";
            this.radioSameClientInvoice_Yes.Size = new System.Drawing.Size(50, 20);
            this.radioSameClientInvoice_Yes.TabIndex = 14;
            this.radioSameClientInvoice_Yes.TabStop = true;
            this.radioSameClientInvoice_Yes.Text = "Yes";
            this.radioSameClientInvoice_Yes.UseVisualStyleBackColor = true;
            // 
            // panelOTAllowed
            // 
            this.panelOTAllowed.Controls.Add(this.radioOTAllowed_No);
            this.panelOTAllowed.Controls.Add(this.radioOTAllowed_Yes);
            this.panelOTAllowed.Location = new System.Drawing.Point(547, 305);
            this.panelOTAllowed.Name = "panelOTAllowed";
            this.panelOTAllowed.Size = new System.Drawing.Size(115, 29);
            this.panelOTAllowed.TabIndex = 67;
            // 
            // radioOTAllowed_No
            // 
            this.radioOTAllowed_No.AutoSize = true;
            this.radioOTAllowed_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOTAllowed_No.Location = new System.Drawing.Point(56, 8);
            this.radioOTAllowed_No.Name = "radioOTAllowed_No";
            this.radioOTAllowed_No.Size = new System.Drawing.Size(44, 20);
            this.radioOTAllowed_No.TabIndex = 24;
            this.radioOTAllowed_No.TabStop = true;
            this.radioOTAllowed_No.Text = "No";
            this.radioOTAllowed_No.UseVisualStyleBackColor = true;
            // 
            // radioOTAllowed_Yes
            // 
            this.radioOTAllowed_Yes.AutoSize = true;
            this.radioOTAllowed_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOTAllowed_Yes.Location = new System.Drawing.Point(0, 8);
            this.radioOTAllowed_Yes.Name = "radioOTAllowed_Yes";
            this.radioOTAllowed_Yes.Size = new System.Drawing.Size(50, 20);
            this.radioOTAllowed_Yes.TabIndex = 23;
            this.radioOTAllowed_Yes.TabStop = true;
            this.radioOTAllowed_Yes.Text = "Yes";
            this.radioOTAllowed_Yes.UseVisualStyleBackColor = true;
            // 
            // txtClientContactPerson
            // 
            this.txtClientContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientContactPerson.Location = new System.Drawing.Point(602, 388);
            this.txtClientContactPerson.Name = "txtClientContactPerson";
            this.txtClientContactPerson.Size = new System.Drawing.Size(268, 22);
            this.txtClientContactPerson.TabIndex = 28;
            this.txtClientContactPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClientContactPerson
            // 
            this.lblClientContactPerson.AutoSize = true;
            this.lblClientContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientContactPerson.Location = new System.Drawing.Point(436, 391);
            this.lblClientContactPerson.Name = "lblClientContactPerson";
            this.lblClientContactPerson.Size = new System.Drawing.Size(160, 16);
            this.lblClientContactPerson.TabIndex = 71;
            this.lblClientContactPerson.Text = "Client Contact Person:";
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientAddress.Location = new System.Drawing.Point(92, 418);
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.Size = new System.Drawing.Size(325, 22);
            this.txtClientAddress.TabIndex = 72;
            this.txtClientAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAddress.Location = new System.Drawing.Point(16, 421);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(70, 16);
            this.lblClientAddress.TabIndex = 73;
            this.lblClientAddress.Text = "Address:";
            // 
            // txtClientCity
            // 
            this.txtClientCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCity.Location = new System.Drawing.Point(60, 446);
            this.txtClientCity.Name = "txtClientCity";
            this.txtClientCity.Size = new System.Drawing.Size(196, 22);
            this.txtClientCity.TabIndex = 74;
            this.txtClientCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClientCity
            // 
            this.lblClientCity.AutoSize = true;
            this.lblClientCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCity.Location = new System.Drawing.Point(16, 449);
            this.lblClientCity.Name = "lblClientCity";
            this.lblClientCity.Size = new System.Drawing.Size(38, 16);
            this.lblClientCity.TabIndex = 75;
            this.lblClientCity.Text = "City:";
            // 
            // txtClientZip
            // 
            this.txtClientZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientZip.Location = new System.Drawing.Point(482, 446);
            this.txtClientZip.Name = "txtClientZip";
            this.txtClientZip.Size = new System.Drawing.Size(93, 22);
            this.txtClientZip.TabIndex = 76;
            this.txtClientZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClientZip
            // 
            this.lblClientZip.AutoSize = true;
            this.lblClientZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientZip.Location = new System.Drawing.Point(442, 449);
            this.lblClientZip.Name = "lblClientZip";
            this.lblClientZip.Size = new System.Drawing.Size(34, 16);
            this.lblClientZip.TabIndex = 77;
            this.lblClientZip.Text = "Zip:";
            // 
            // ibiscbxClientName
            // 
            this.ibiscbxClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxClientName.FormattingEnabled = true;
            this.ibiscbxClientName.Location = new System.Drawing.Point(115, 388);
            this.ibiscbxClientName.Name = "ibiscbxClientName";
            this.ibiscbxClientName.Size = new System.Drawing.Size(302, 24);
            this.ibiscbxClientName.srchdtxt = null;
            this.ibiscbxClientName.TabIndex = 27;
            this.ibiscbxClientName.SelectionChangeCommitted += new System.EventHandler(this.ibiscbxClientName_SelectionChangeCommitted);
            // 
            // ibiscbxExistingJobNum
            // 
            this.ibiscbxExistingJobNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxExistingJobNum.FormattingEnabled = true;
            this.ibiscbxExistingJobNum.Location = new System.Drawing.Point(605, 136);
            this.ibiscbxExistingJobNum.Name = "ibiscbxExistingJobNum";
            this.ibiscbxExistingJobNum.Size = new System.Drawing.Size(140, 24);
            this.ibiscbxExistingJobNum.srchdtxt = null;
            this.ibiscbxExistingJobNum.TabIndex = 69;
            // 
            // ibiscbxFilledOutBy
            // 
            this.ibiscbxFilledOutBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxFilledOutBy.FormattingEnabled = true;
            this.ibiscbxFilledOutBy.Location = new System.Drawing.Point(195, 105);
            this.ibiscbxFilledOutBy.Name = "ibiscbxFilledOutBy";
            this.ibiscbxFilledOutBy.Size = new System.Drawing.Size(302, 24);
            this.ibiscbxFilledOutBy.srchdtxt = null;
            this.ibiscbxFilledOutBy.TabIndex = 68;
            // 
            // ibiscbxClientType
            // 
            this.ibiscbxClientType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxClientType.FormattingEnabled = true;
            this.ibiscbxClientType.Location = new System.Drawing.Point(645, 282);
            this.ibiscbxClientType.Name = "ibiscbxClientType";
            this.ibiscbxClientType.Size = new System.Drawing.Size(302, 24);
            this.ibiscbxClientType.srchdtxt = null;
            this.ibiscbxClientType.TabIndex = 21;
            // 
            // ibiscbxProjectType
            // 
            this.ibiscbxProjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxProjectType.FormattingEnabled = true;
            this.ibiscbxProjectType.Location = new System.Drawing.Point(123, 282);
            this.ibiscbxProjectType.Name = "ibiscbxProjectType";
            this.ibiscbxProjectType.Size = new System.Drawing.Size(408, 24);
            this.ibiscbxProjectType.srchdtxt = null;
            this.ibiscbxProjectType.TabIndex = 20;
            // 
            // ibiscbxInvoiceType
            // 
            this.ibiscbxInvoiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxInvoiceType.FormattingEnabled = true;
            this.ibiscbxInvoiceType.Location = new System.Drawing.Point(612, 255);
            this.ibiscbxInvoiceType.Name = "ibiscbxInvoiceType";
            this.ibiscbxInvoiceType.Size = new System.Drawing.Size(335, 24);
            this.ibiscbxInvoiceType.srchdtxt = null;
            this.ibiscbxInvoiceType.TabIndex = 19;
            // 
            // ibiscbxClientState
            // 
            this.ibiscbxClientState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiscbxClientState.FormattingEnabled = true;
            this.ibiscbxClientState.Location = new System.Drawing.Point(348, 446);
            this.ibiscbxClientState.Name = "ibiscbxClientState";
            this.ibiscbxClientState.Size = new System.Drawing.Size(69, 24);
            this.ibiscbxClientState.srchdtxt = null;
            this.ibiscbxClientState.TabIndex = 78;
            // 
            // lblClientState
            // 
            this.lblClientState.AutoSize = true;
            this.lblClientState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientState.Location = new System.Drawing.Point(294, 449);
            this.lblClientState.Name = "lblClientState";
            this.lblClientState.Size = new System.Drawing.Size(48, 16);
            this.lblClientState.TabIndex = 79;
            this.lblClientState.Text = "State:";
            // 
            // lblClientCode
            // 
            this.lblClientCode.AutoSize = true;
            this.lblClientCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCode.Location = new System.Drawing.Point(436, 421);
            this.lblClientCode.Name = "lblClientCode";
            this.lblClientCode.Size = new System.Drawing.Size(92, 16);
            this.lblClientCode.TabIndex = 81;
            this.lblClientCode.Text = "Client Code:";
            // 
            // txtClientCode
            // 
            this.txtClientCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCode.Location = new System.Drawing.Point(534, 418);
            this.txtClientCode.Name = "txtClientCode";
            this.txtClientCode.Size = new System.Drawing.Size(250, 22);
            this.txtClientCode.TabIndex = 82;
            this.txtClientCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientEmail.Location = new System.Drawing.Point(658, 446);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(212, 22);
            this.txtClientEmail.TabIndex = 83;
            this.txtClientEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClientEmail
            // 
            this.lblClientEmail.AutoSize = true;
            this.lblClientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientEmail.Location = new System.Drawing.Point(601, 449);
            this.lblClientEmail.Name = "lblClientEmail";
            this.lblClientEmail.Size = new System.Drawing.Size(51, 16);
            this.lblClientEmail.TabIndex = 84;
            this.lblClientEmail.Text = "Email:";
            // 
            // lblExt
            // 
            this.lblExt.AutoSize = true;
            this.lblExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExt.Location = new System.Drawing.Point(313, 478);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(37, 16);
            this.lblExt.TabIndex = 90;
            this.lblExt.Text = "Ext.:";
            // 
            // txtClientFax
            // 
            this.txtClientFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientFax.Location = new System.Drawing.Point(566, 475);
            this.txtClientFax.Name = "txtClientFax";
            this.txtClientFax.Size = new System.Drawing.Size(203, 22);
            this.txtClientFax.TabIndex = 87;
            this.txtClientFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClientFax
            // 
            this.lblClientFax.AutoSize = true;
            this.lblClientFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientFax.Location = new System.Drawing.Point(511, 478);
            this.lblClientFax.Name = "lblClientFax";
            this.lblClientFax.Size = new System.Drawing.Size(49, 16);
            this.lblClientFax.TabIndex = 88;
            this.lblClientFax.Text = "Fax #:";
            // 
            // txtClientBusinessNum
            // 
            this.txtClientBusinessNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientBusinessNum.Location = new System.Drawing.Point(108, 475);
            this.txtClientBusinessNum.Name = "txtClientBusinessNum";
            this.txtClientBusinessNum.Size = new System.Drawing.Size(196, 22);
            this.txtClientBusinessNum.TabIndex = 85;
            this.txtClientBusinessNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClientBusinessNum
            // 
            this.lblClientBusinessNum.AutoSize = true;
            this.lblClientBusinessNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientBusinessNum.Location = new System.Drawing.Point(15, 478);
            this.lblClientBusinessNum.Name = "lblClientBusinessNum";
            this.lblClientBusinessNum.Size = new System.Drawing.Size(87, 16);
            this.lblClientBusinessNum.TabIndex = 86;
            this.lblClientBusinessNum.Text = "Business #:";
            // 
            // txtClientBusinessNumExt
            // 
            this.txtClientBusinessNumExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientBusinessNumExt.Location = new System.Drawing.Point(356, 475);
            this.txtClientBusinessNumExt.Name = "txtClientBusinessNumExt";
            this.txtClientBusinessNumExt.Size = new System.Drawing.Size(93, 22);
            this.txtClientBusinessNumExt.TabIndex = 91;
            this.txtClientBusinessNumExt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmJobInfoSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 833);
            this.Controls.Add(this.txtClientBusinessNumExt);
            this.Controls.Add(this.lblExt);
            this.Controls.Add(this.txtClientFax);
            this.Controls.Add(this.lblClientFax);
            this.Controls.Add(this.txtClientBusinessNum);
            this.Controls.Add(this.lblClientBusinessNum);
            this.Controls.Add(this.txtClientEmail);
            this.Controls.Add(this.lblClientEmail);
            this.Controls.Add(this.txtClientCode);
            this.Controls.Add(this.lblClientCode);
            this.Controls.Add(this.ibiscbxClientState);
            this.Controls.Add(this.lblClientState);
            this.Controls.Add(this.txtClientZip);
            this.Controls.Add(this.lblClientZip);
            this.Controls.Add(this.txtClientCity);
            this.Controls.Add(this.lblClientCity);
            this.Controls.Add(this.txtClientAddress);
            this.Controls.Add(this.lblClientAddress);
            this.Controls.Add(this.txtClientContactPerson);
            this.Controls.Add(this.lblClientContactPerson);
            this.Controls.Add(this.ibiscbxClientName);
            this.Controls.Add(this.ibiscbxExistingJobNum);
            this.Controls.Add(this.ibiscbxFilledOutBy);
            this.Controls.Add(this.ibiscbxClientType);
            this.Controls.Add(this.ibiscbxProjectType);
            this.Controls.Add(this.ibiscbxInvoiceType);
            this.Controls.Add(this.panelIsAmendment);
            this.Controls.Add(this.panelCompany);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.ddProjMgr2);
            this.Controls.Add(this.lblProjMgr2);
            this.Controls.Add(this.ddProjMgr1);
            this.Controls.Add(this.lblProjMgr1);
            this.Controls.Add(this.lblOTAllowed);
            this.Controls.Add(this.txtProjectDueDate);
            this.Controls.Add(this.lblProjectDueDate);
            this.Controls.Add(this.lblClientType);
            this.Controls.Add(this.lblInvoiceType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJobNum);
            this.Controls.Add(this.lblJobNum);
            this.Controls.Add(this.txtTodaysDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTodaysDate);
            this.Controls.Add(this.lblHorDivider1B);
            this.Controls.Add(this.lblHorDivider1A);
            this.Controls.Add(this.txtJobNumsInvoicedTogether);
            this.Controls.Add(this.lblIfSo);
            this.Controls.Add(this.lvlJobNumsInvoicedTogether);
            this.Controls.Add(this.lbl2orMore);
            this.Controls.Add(this.txtNewSuffixPref);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.lblNewSuffPref);
            this.Controls.Add(this.lblNextAvailSuffix);
            this.Controls.Add(this.lblIfAnAmendment);
            this.Controls.Add(this.lblIfYesExistingJobNo);
            this.Controls.Add(this.lblIsAmendment);
            this.Controls.Add(this.lblPersonFillingOutForm);
            this.Controls.Add(this.lblCompanyRadioGrp);
            this.Controls.Add(this.lblJobInfoSheetTitle);
            this.Controls.Add(this.chkbxRevisedInfo);
            this.Controls.Add(this.chkbxNewJob);
            this.Controls.Add(this.panelNextSuffix);
            this.Controls.Add(this.panelSameClientInvoice);
            this.Controls.Add(this.panelOTAllowed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmJobInfoSheet";
            this.Text = "Job Information Sheet";
            this.Load += new System.EventHandler(this.frmJobInfoSheet_Load);
            this.panelCompany.ResumeLayout(false);
            this.panelCompany.PerformLayout();
            this.panelIsAmendment.ResumeLayout(false);
            this.panelIsAmendment.PerformLayout();
            this.panelNextSuffix.ResumeLayout(false);
            this.panelNextSuffix.PerformLayout();
            this.panelSameClientInvoice.ResumeLayout(false);
            this.panelSameClientInvoice.PerformLayout();
            this.panelOTAllowed.ResumeLayout(false);
            this.panelOTAllowed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbxNewJob;
        private System.Windows.Forms.CheckBox chkbxRevisedInfo;
        private System.Windows.Forms.Label lblJobInfoSheetTitle;
        private System.Windows.Forms.Label lblCompanyRadioGrp;
        private System.Windows.Forms.Label lblPersonFillingOutForm;
        private System.Windows.Forms.Label lblIsAmendment;
        private System.Windows.Forms.Label lblIfYesExistingJobNo;
        private System.Windows.Forms.Label lblIfAnAmendment;
        private System.Windows.Forms.Label lblNextAvailSuffix;
        private System.Windows.Forms.Label lblNewSuffPref;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.TextBox txtNewSuffixPref;
        private System.Windows.Forms.Label lbl2orMore;
        private System.Windows.Forms.Label lvlJobNumsInvoicedTogether;
        private System.Windows.Forms.Label lblIfSo;
        private System.Windows.Forms.TextBox txtJobNumsInvoicedTogether;
        private System.Windows.Forms.Label lblHorDivider1A;
        private System.Windows.Forms.Label lblHorDivider1B;
        private System.Windows.Forms.Label lblTodaysDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTodaysDate;
        private System.Windows.Forms.Label lblJobNum;
        private System.Windows.Forms.TextBox txtJobNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInvoiceType;
        private System.Windows.Forms.Label lblClientType;
        private System.Windows.Forms.Label lblProjectDueDate;
        private System.Windows.Forms.TextBox txtProjectDueDate;
        private System.Windows.Forms.Label lblOTAllowed;
        private System.Windows.Forms.Label lblProjMgr1;
        private System.Windows.Forms.ComboBox ddProjMgr1;
        private System.Windows.Forms.ComboBox ddProjMgr2;
        private System.Windows.Forms.Label lblProjMgr2;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Panel panelCompany;
        private System.Windows.Forms.RadioButton radioCompany_HES;
        private System.Windows.Forms.RadioButton radioCompany_NEEA;
        private System.Windows.Forms.RadioButton radioCompany_HGPS;
        private System.Windows.Forms.RadioButton radioCompany_ECM;
        private System.Windows.Forms.Panel panelIsAmendment;
        private System.Windows.Forms.RadioButton radioIsAmendment_Yes;
        private System.Windows.Forms.RadioButton radioIsAmendment_No;
        private System.Windows.Forms.Panel panelNextSuffix;
        private System.Windows.Forms.RadioButton radioNextAvailableSuffix_No;
        private System.Windows.Forms.RadioButton radioNextAvailableSuffix_Yes;
        private System.Windows.Forms.Panel panelSameClientInvoice;
        private System.Windows.Forms.RadioButton radioSameClientInvoice_No;
        private System.Windows.Forms.RadioButton radioSameClientInvoice_Yes;
        private System.Windows.Forms.Panel panelOTAllowed;
        private System.Windows.Forms.RadioButton radioOTAllowed_No;
        private System.Windows.Forms.RadioButton radioOTAllowed_Yes;
        private IbisUtils.IbisComboBox ibiscbxInvoiceType;
        private IbisUtils.IbisComboBox ibiscbxProjectType;
        private IbisUtils.IbisComboBox ibiscbxClientType;
        private IbisUtils.IbisComboBox ibiscbxFilledOutBy;
        private IbisUtils.IbisComboBox ibiscbxExistingJobNum;
        private IbisUtils.IbisComboBox ibiscbxClientName;
        private System.Windows.Forms.TextBox txtClientContactPerson;
        private System.Windows.Forms.Label lblClientContactPerson;
        private System.Windows.Forms.TextBox txtClientAddress;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.TextBox txtClientCity;
        private System.Windows.Forms.Label lblClientCity;
        private System.Windows.Forms.TextBox txtClientZip;
        private System.Windows.Forms.Label lblClientZip;
        private IbisUtils.IbisComboBox ibiscbxClientState;
        private System.Windows.Forms.Label lblClientState;
        private System.Windows.Forms.Label lblClientCode;
        private System.Windows.Forms.TextBox txtClientCode;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.Label lblClientEmail;
        private System.Windows.Forms.Label lblExt;
        private System.Windows.Forms.TextBox txtClientFax;
        private System.Windows.Forms.Label lblClientFax;
        private System.Windows.Forms.TextBox txtClientBusinessNum;
        private System.Windows.Forms.Label lblClientBusinessNum;
        private System.Windows.Forms.TextBox txtClientBusinessNumExt;
    }
}