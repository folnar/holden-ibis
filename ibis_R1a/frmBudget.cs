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
            budget_lineitemTableAdapter.Fill(holdenengrDataSet.budget_lineitem);
            using (holdenengrDataSet.jobDataTable jobtbl = jobTableAdapter1.GetData())
            {
                cbxJobNums.DataSource = jobtbl.DefaultView;
                cbxJobNums.DisplayMember = "job_job_key";
                cbxJobNums.ValueMember = "job_id";
                cbxJobNums.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxJobNums.AutoCompleteSource = AutoCompleteSource.ListItems;
            }

            //using (holdenengrDataSet.ibis_activitycodeDataTable acttbl = ibis_activitycodeTableAdapter1.GetData())
            //{
            //    cbxActivityCode.DataSource = acttbl.DefaultView;
            //    cbxActivityCode.DisplayMember = "ibis_activitycode_code";
            //    cbxActivityCode.ValueMember = "ibis_activitycode_id";
            //    cbxActivityCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    cbxActivityCode.AutoCompleteSource = AutoCompleteSource.ListItems;
            //}

            //using (holdenengrDataSet.ibis_taskcodeDataTable tsktbl = ibis_taskcodeTableAdapter1.GetData())
            //{
            //    cbxTaskCode.DataSource = tsktbl.DefaultView;
            //    cbxTaskCode.DisplayMember = "ibis_taskcode_code";
            //    cbxTaskCode.ValueMember = "ibis_taskcode_id";
            //    cbxTaskCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    cbxTaskCode.AutoCompleteSource = AutoCompleteSource.ListItems;
            //}

            //using (holdenengrDataSet.ibis_workcodeDataTable wrktbl = ibis_workcodeTableAdapter1.GetData())
            //{
            //    cbxWorkCode.DataSource = wrktbl.DefaultView;
            //    cbxWorkCode.DisplayMember = "ibis_workcode_code";
            //    cbxWorkCode.ValueMember = "ibis_workcode_id";
            //    cbxWorkCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    cbxWorkCode.AutoCompleteSource = AutoCompleteSource.ListItems;
            //}
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
                budget_lineitemTableAdapter.FillByJobNumber(holdenengrDataSet.budget_lineitem, cbxJobNums.SelectedValue.ToString());
                //budget_lineitemTableAdapter.FillByJobNumber(Convert.ToInt32(cbxJobNums.SelectedValue));
            }
            catch (InvalidCastException ice)
            {
                MessageBox.Show("Invalid Cast Exception.: \n" + ice.Message + "\nContact dcasale@umd.edu");
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            budget_lineitemTableAdapter.Adapter.Update(holdenengrDataSet.budget_lineitem);
            budget_lineitemTableAdapter.Fill(holdenengrDataSet.budget_lineitem);
        }
    }
}
