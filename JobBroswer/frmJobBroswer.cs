using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace JobBroswer
{
    public partial class frmJobBroswer : Form
    {
        private bool inclOldJobs = false;

        public frmJobBroswer()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> filters { get; set; }

        private void frmJobBroswer_Load(object sender, EventArgs e)
        {
            jobTableAdapter.Fill(holdenengrDataSet.job);
            initForm();
        }

        private void initForm()
        {
            filters = new Dictionary<string, string>();
            filters.Add("byaddr", "");
            filters.Add("byclnt", "");
            filters.Add("bystat", "");
            filters.Add("bytown", "");
            filters.Add("bycont", "");

            lblCurrFilterByAddress.Text = "";
            lblCurrFilterByClientName.Text = "";
            lblCurrFilterByTown.Text = "";
            lblCurrFilterByState.Text = "";
            lblCurrFilterByContact.Text = "";

            lblResultsCount.Text = jobBindingSource.Count.ToString();
        }

        private void updateFilter()
        {
            jobBindingSource.Filter = string.Join(" AND ", filters.Values.Where(s => !String.IsNullOrEmpty(s)));
            lblResultsCount.Text = jobBindingSource.Count.ToString();
        }

        private void cmdFilterByProjectAddress_Click(object sender, EventArgs e)
        {
            filters["byaddr"] = string.Format("(job_addr1 LIKE '%{0}%' OR job_addr3 LIKE '%{0}%')", txtByProjectAddress.Text.Trim());
            updateFilter();
            lblCurrFilterByAddress.Text = txtByProjectAddress.Text.Trim();
        }

        private void cmdFilterByClientName_Click(object sender, EventArgs e)
        {
            filters["byclnt"] = string.Format("client_name LIKE '%{0}%'", txtByClientName.Text.Trim());
            updateFilter();
            lblCurrFilterByClientName.Text = txtByClientName.Text.Trim();
        }

        private void cmdFilterByProjectTown_Click(object sender, EventArgs e)
        {
            filters["bytown"] = string.Format("job_city LIKE '%{0}%'", txtByProjectTown.Text.Trim());
            updateFilter();
            lblCurrFilterByTown.Text = txtByProjectTown.Text.Trim();
        }

        private void cmdFilterByProjectState_Click(object sender, EventArgs e)
        {
            filters["bystat"] = string.Format("job_state LIKE '%{0}%'", txtByProjectState.Text.Trim());
            updateFilter();
            lblCurrFilterByState.Text = txtByProjectState.Text.Trim();
        }

        private void cmdFilterByProjectContact_Click(object sender, EventArgs e)
        {
            filters["bycont"] = string.Format("job_pcontact LIKE '%{0}%'", txtByProjectContact.Text.Trim());
            updateFilter();
            lblCurrFilterByContact.Text = txtByProjectContact.Text.Trim();
        }

        private void cmdRemFilterByProjectAddress_Click(object sender, EventArgs e)
        {
            filters["byaddr"] = "";
            updateFilter();
            txtByProjectAddress.Text = "";
            lblCurrFilterByAddress.Text = "";
        }

        private void cmdRemFilterByClientName_Click(object sender, EventArgs e)
        {
            filters["byclnt"] = "";
            updateFilter();
            txtByClientName.Text = "";
            lblCurrFilterByClientName.Text = "";
        }

        private void cmdRemFilterByProjectTown_Click(object sender, EventArgs e)
        {
            filters["bytown"] = "";
            updateFilter();
            txtByProjectTown.Text = "";
            lblCurrFilterByTown.Text = "";
        }

        private void cmdRemFilterByProjectState_Click(object sender, EventArgs e)
        {
            filters["bystat"] = "";
            updateFilter();
            txtByProjectState.Text = "";
            lblCurrFilterByState.Text = "";
        }

        private void cmdRemFilterByProjectContact_Click(object sender, EventArgs e)
        {
            filters["bycont"] = "";
            updateFilter();
            txtByProjectContact.Text = "";
            lblCurrFilterByContact.Text = "";
        }

        private void txtByProjectAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                cmdFilterByProjectAddress.PerformClick();
            }
        }

        private void txtByClientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                cmdFilterByClientName.PerformClick();
            }
        }

        private void txtByProjectTown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                cmdFilterByProjectTown.PerformClick();
            }
        }

        private void txtByProjectState_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                cmdFilterByProjectState.PerformClick();
            }
        }

        private void txtByProjectContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                cmdFilterByProjectContact.PerformClick();
            }
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            MessageBox.Show("Version: " + version.Major + "." + version.Minor + "." + version.Build + "." + version.Revision);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void includeArchiveRecordsPreJCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Checked)
            {
                jobTableAdapter.FillIncludeOldJobs(holdenengrDataSet.job);
                inclOldJobs = true;
            }
            else
            {
                jobTableAdapter.Fill(holdenengrDataSet.job);
                inclOldJobs = false;
            }
            updateFilter();
        }

        private void showPrintReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJobsReportViewer frmRV = new frmJobsReportViewer(jobBindingSource.Filter, inclOldJobs);
            frmRV.ShowDialog();
        }
    }
}
