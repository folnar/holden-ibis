using System;
using System.Data;
using System.Windows.Forms;

namespace ibis_R1a
{
    public partial class frmJob : Form
    {
        public frmJob()
        {
            InitializeComponent();
        }

        private void frmJob_Load(object sender, System.EventArgs e)
        {
            using (holdenengrDataSet.jobDataTable jobtbl = jobTableAdapter1.GetData())
            {
                cbxJobNums.DataSource = jobtbl.DefaultView;
                cbxJobNums.DisplayMember = "job_job_key";
                cbxJobNums.ValueMember = "job_id";
            }
        }

        private void cmdExit_Click(object sender, System.EventArgs e)
        {
            jobTableAdapter1.Dispose();
            this.Dispose();
            this.Close();
        }

        private void cbxJobNums_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbxJobNums.SelectedIndex == 0 || cbxJobNums.SelectedValue == null) return;
            try
            {
                using (DataTable dt = jobTableAdapter1.GetDataByID(Convert.ToInt32(cbxJobNums.SelectedValue)))
                {
                    txtPName.Text = dt.Rows[0].Field<string>("job_pname");
                }
            }
            catch (InvalidCastException ice)
            {
                MessageBox.Show("Invalid Cast Exception.: \n" + ice.Message + "\nContact dcasale@umd.edu");
            }
        }
    }
}
