using System;
using System.Data;
using System.Windows.Forms;

namespace ibis_R1a
{
    public partial class frmBudget : Form
    {
        public frmBudget()
        {
            InitializeComponent();
        }

        private void frmBudget_Load(object sender, EventArgs e)
        {
            using (holdenengrDataSet.jobDataTable jobtbl = jobTableAdapter1.GetData())
            {
                cbxJobNums.DataSource = jobtbl.DefaultView;
                cbxJobNums.DisplayMember = "job_job_key";
                cbxJobNums.ValueMember = "job_id";
                cbxJobNums.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxJobNums.AutoCompleteSource = AutoCompleteSource.ListItems;
            }

            using (holdenengrDataSet.ibis_activitycodeDataTable acttbl = ibis_activitycodeTableAdapter1.GetData())
            {
                cbxActivityCode.DataSource = acttbl.DefaultView;
                cbxActivityCode.DisplayMember = "ibis_activitycode_code";
                cbxActivityCode.ValueMember = "ibis_activitycode_id";
                cbxActivityCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxActivityCode.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            jobTableAdapter1.Dispose();
            this.Dispose();
            this.Close();
        }

        private void cbxJobNums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxJobNums.SelectedIndex == 0 || cbxJobNums.SelectedValue == null) return;
            try
            {
                using (DataTable dt = jobTableAdapter1.GetDataByID(Convert.ToInt32(cbxJobNums.SelectedValue)))
                {
                    if (cbxJobNums.SelectedIndex >= 0)
                        txtPName.Text = dt.Rows[0].Field<string>("job_pname");
                    else
                        txtPName.Text = "";
                }
            }
            catch (InvalidCastException ice)
            {
                MessageBox.Show("Invalid Cast Exception.: \n" + ice.Message + "\nContact dcasale@umd.edu");
            }
        }
    }
}
