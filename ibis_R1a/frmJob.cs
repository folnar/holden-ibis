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
            //using (DataTable jobtbl = jobTableAdapter1.GetData())
            //{
            //    foreach (holdenengrDataSet.jobRow jr in jobtbl.Rows)
            //    {
            //        cbxJobNums.Items.Add(jr["job_job_key"]);
            //    }
            //}
        }

        private void cmdExit_Click(object sender, System.EventArgs e)
        {
            jobTableAdapter1.Dispose();
            this.Dispose();
            this.Close();
        }
    }
}
