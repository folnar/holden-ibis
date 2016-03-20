using System;
using System.Windows.Forms;

namespace JobBroswer
{
    public partial class frmJobsReportViewer : Form
    {
        private string filter;
        private bool inclOldJobs;

        public frmJobsReportViewer()
        {
            InitializeComponent();
        }

        public frmJobsReportViewer(string f, bool i)
        {
            InitializeComponent();

            filter = f;
            inclOldJobs = i;
        }

        private void frmJobsReportViewer_Load(object sender, EventArgs e)
        {
            jobBindingSource.Filter = filter;
            if (inclOldJobs)
            {
                jobTableAdapter.FillIncludeOldJobs(holdenengrDataSet.job);
            }
            else
            {
                jobTableAdapter.Fill(holdenengrDataSet.job);
            }

            System.Drawing.Printing.PageSettings ps = new System.Drawing.Printing.PageSettings();
            ps.Landscape = true;
            ps.Margins.Bottom = 50;
            ps.Margins.Top = 50;
            ps.Margins.Left = 50;
            ps.Margins.Right = 50;
            reportViewer1.SetPageSettings(ps);
            reportViewer1.RefreshReport();
        }
    }
}
