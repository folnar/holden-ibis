using System;
using System.Windows.Forms;

namespace JobBroswer
{
    public partial class frmJobsReportViewer : Form
    {
        private string filter;

        public frmJobsReportViewer()
        {
            InitializeComponent();
        }

        public frmJobsReportViewer(string f)
        {
            InitializeComponent();

            filter = f;
        }

        // NOW WE NEED TO ADD OLD JOBS INTO THIS
        // SEPARATE FORM W SEP DGV W SEP REPORT??
        // MAYBE


        private void frmJobsReportViewer_Load(object sender, EventArgs e)
        {
            jobBindingSource.Filter = filter;
            jobTableAdapter.Fill(holdenengrDataSet.job);
            reportViewer1.RefreshReport();
        }
    }
}
