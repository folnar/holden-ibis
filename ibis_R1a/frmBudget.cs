using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using HoldenClasses;

namespace ibis_R1a
{
    public partial class frmBudget : Form
    {
        private HoldenUser hu;

        public frmBudget()
        {
            InitializeComponent();
        }

        private void makeExistingRowsReadOnly()
        {
            foreach (DataGridViewRow dgvr in dgvBudgetLineItems.Rows)
            {
                dgvr.ReadOnly = true;
            }
        }

        private void frmBudget_Load(object sender, EventArgs e)
        {
            hesemployee1TableAdapter.Fill(holdenengrDataSet.hesemployee1);
            ibis_activitycodeTableAdapter1.Fill(holdenengrDataSet.ibis_activitycode);
            ibis_taskcodeTableAdapter1.Fill(holdenengrDataSet.ibis_taskcode);
            ibis_workcodeTableAdapter1.Fill(holdenengrDataSet.ibis_workcode);

            lblBudgetTotalDisp.Text = "";

            using (holdenengrDataSet.jobDataTable jobtbl = jobTableAdapter1.GetData_JobNumberPName())
            {
                cbxJobNums.DataSource = jobtbl.DefaultView;
                cbxJobNums.DisplayMember = "job_job_key";
                cbxJobNums.ValueMember = "job_id";
                cbxJobNums.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxJobNums.AutoCompleteSource = AutoCompleteSource.ListItems;
            }

            dgvBudgetLineItems.CellValueChanged += dgvBudgetLineItems_CellValueChanged;

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Resource1.SESSION_FN, FileMode.Open, FileAccess.Read, FileShare.Read);
            hu = (HoldenUser)formatter.Deserialize(stream);
            stream.Close();
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

            makeExistingRowsReadOnly();

            lblBudgetTotalDisp.Text = sumBudget();
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

            makeExistingRowsReadOnly();
        }

        private void dgvBudgetLineItems_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["budget_lineitem_jobnumber"].Value = ((DataRowView)cbxJobNums.SelectedItem)[0].ToString();
            e.Row.Cells["budget_lineitem_enteredby"].Value = hu.un;
            e.Row.ReadOnly = false;
        }

        private void dgvBudgetLineItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == dgvBudgetLineItems.Columns["budget_lineitem_empid"].Index ||
                e.ColumnIndex == dgvBudgetLineItems.Columns["budget_lineitem_numhrs"].Index) &&
                !(dgvBudgetLineItems.CurrentRow.Cells["budget_lineitem_empid"].Value == null ||
                dgvBudgetLineItems.CurrentRow.Cells["budget_lineitem_empid"].Value == DBNull.Value ||
                String.IsNullOrWhiteSpace(dgvBudgetLineItems.CurrentRow.Cells["budget_lineitem_empid"].Value.ToString()) ||
                dgvBudgetLineItems.CurrentRow.Cells["budget_lineitem_numhrs"].Value == null ||
                dgvBudgetLineItems.CurrentRow.Cells["budget_lineitem_numhrs"].Value == DBNull.Value ||
                String.IsNullOrWhiteSpace(dgvBudgetLineItems.CurrentRow.Cells["budget_lineitem_numhrs"].Value.ToString())))
            {
                decimal tmppayrate = Convert.ToDecimal(holdenengrDataSet.hesemployee1.AsEnumerable().
                    SingleOrDefault(
                        r => r.Field<int>("hesemployee_id") ==
                        (int)dgvBudgetLineItems.CurrentRow.Cells["budget_lineitem_empid"].Value
                        )["hesemployee_payrate"]);
                decimal tmpnumhrs = (decimal)dgvBudgetLineItems.CurrentRow.Cells["budget_lineitem_numhrs"].Value;
                dgvBudgetLineItems.CurrentRow.Cells["budget_lineitem_value"].Value = tmppayrate * tmpnumhrs;

                lblBudgetTotalDisp.Text = sumBudget();
            }
        }

        private string sumBudget()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvBudgetLineItems.Rows)
            {
                if (row.Cells["budget_lineitem_value"].Value != null)
                    total += (decimal)row.Cells["budget_lineitem_value"].Value;
            }
            return total.ToString();
        }

        private void dgvBudgetLineItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("(0xea11)Data Error Event: \n" + e.Exception.Message + "\nContact dcasale@umd.edu");
            e.Cancel = true;
        }

        private void dgvBudgetLineItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                (e.Control as ComboBox).DropDownStyle = ComboBoxStyle.DropDown;
                (e.Control as ComboBox).AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                (e.Control as ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        // This overridden function allows us to skip all validations
        // whenever the form's X button is clicked or upon pressing Alt+F4.
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x10) // 0x10 is WM_CLOSE message.
            {
                AutoValidate = AutoValidate.Disable;
            }
            base.WndProc(ref m);
        }
    }
}
