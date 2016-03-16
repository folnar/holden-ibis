using System;
using System.Data;
using System.Linq;
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
            hesemployee1TableAdapter.Fill(holdenengrDataSet.hesemployee1);

            using (holdenengrDataSet.jobDataTable jobtbl = jobTableAdapter1.GetData_JobNumberPName())
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
            dgvBudgetLineItems.CellValueChanged += dgvBudgetLineItems_CellValueChanged;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            jobTableAdapter1.Dispose();
            Dispose();
            Close();
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
                budget_lineitemTableAdapter.FillByJobNumber(holdenengrDataSet.budget_lineitem, ((DataRowView)cbxJobNums.SelectedItem)[0].ToString());
            }
            catch (InvalidCastException ice)
            {
                MessageBox.Show("(0x01a3)Invalid Cast Exception.: \n" + ice.Message + "\nContact dcasale@umd.edu");
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                budget_lineitemTableAdapter.Adapter.Update(holdenengrDataSet.budget_lineitem);
                budget_lineitemTableAdapter.FillByJobNumber(holdenengrDataSet.budget_lineitem, ((DataRowView)cbxJobNums.SelectedItem)[0].ToString());
            }
            catch (DataException de)
            {
                MessageBox.Show("(0x011f)Data Exception: \n" + de.Message + "\nContact dcasale@umd.edu");
            }

            MessageBox.Show("Database updated.");
        }

        private void dgvBudgetLineItems_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = ((DataRowView)cbxJobNums.SelectedItem)[0].ToString();
        }

        private void dgvBudgetLineItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // MIGHT WANT TO SEE ABOUT CLEANING UP THE INDICES BELOW SO THAT,
            // INSTEAD OF INTEGERS, WE REFERENCE CELLS BY COLUMN NAME.

            if ((e.ColumnIndex == 5 || e.ColumnIndex == 4) &&
                !(dgvBudgetLineItems.CurrentRow.Cells[4].Value == null ||
                dgvBudgetLineItems.CurrentRow.Cells[4].Value == DBNull.Value ||
                String.IsNullOrWhiteSpace(dgvBudgetLineItems.CurrentRow.Cells[4].Value.ToString()) ||
                dgvBudgetLineItems.CurrentRow.Cells[5].Value == null ||
                dgvBudgetLineItems.CurrentRow.Cells[5].Value == DBNull.Value ||
                String.IsNullOrWhiteSpace(dgvBudgetLineItems.CurrentRow.Cells[5].Value.ToString())))
            {
                decimal tmppayrate = Convert.ToDecimal(holdenengrDataSet.hesemployee1.AsEnumerable().
                    SingleOrDefault(
                        r => r.Field<int>("hesemployee_id") ==
                        (int)dgvBudgetLineItems.CurrentRow.Cells[4].Value
                        )["hesemployee_payrate"]);
                decimal tmpnumhrs = (decimal)dgvBudgetLineItems.CurrentRow.Cells[5].Value;
                dgvBudgetLineItems.CurrentRow.Cells[6].Value = tmppayrate * tmpnumhrs;
            }
        }

        private void dgvBudgetLineItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("(0xea11)Data Error Event: \n" + e.Exception.Message + "\nContact dcasale@umd.edu");
        }
    }
}
