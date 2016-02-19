﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ibis_R1a;

namespace JobBroswer
{
    public partial class frmJobBroswer : Form
    {
        public frmJobBroswer()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> filters { get; set; }

        private void frmJobBroswer_Load(object sender, EventArgs e)
        {
            this.jobTableAdapter.Fill(this.holdenengrDataSet.job);

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
        }

        private void cmdFilterByProjectAddress_Click(object sender, EventArgs e)
        {
            filters["byaddr"] = string.Format("(job_addr1 LIKE '%{0}%' OR job_addr3 LIKE '%{0}%')", txtByProjectAddress.Text.Trim());
            jobBindingSource.Filter = string.Join(" AND ", filters.Values.Where(s => !String.IsNullOrEmpty(s)));
            lblCurrFilterByAddress.Text = txtByProjectAddress.Text.Trim();
        }

        private void cmdFilterByClientName_Click(object sender, EventArgs e)
        {
            filters["byclnt"] = string.Format("client_name LIKE '%{0}%'", txtByClientName.Text.Trim());
            jobBindingSource.Filter = string.Join(" AND ", filters.Values.Where(s => !String.IsNullOrEmpty(s)));
            lblCurrFilterByClientName.Text = txtByClientName.Text.Trim();
        }

        private void cmdFilterByProjectTown_Click(object sender, EventArgs e)
        {
            filters["bytown"] = string.Format("job_city LIKE '%{0}%'", txtByProjectTown.Text.Trim());
            jobBindingSource.Filter = string.Join(" AND ", filters.Values.Where(s => !String.IsNullOrEmpty(s)));
            lblCurrFilterByTown.Text = txtByProjectTown.Text.Trim();
        }

        private void cmdFilterByProjectState_Click(object sender, EventArgs e)
        {
            filters["bystat"] = string.Format("job_state LIKE '%{0}%'", txtByProjectState.Text.Trim());
            jobBindingSource.Filter = string.Join(" AND ", filters.Values.Where(s => !String.IsNullOrEmpty(s)));
            lblCurrFilterByState.Text = txtByProjectState.Text.Trim();
        }

        private void cmdFilterByProjectContact_Click(object sender, EventArgs e)
        {
            filters["bycont"] = string.Format("job_pcontact LIKE '%{0}%'", txtByProjectContact.Text.Trim());
            jobBindingSource.Filter = string.Join(" AND ", filters.Values.Where(s => !String.IsNullOrEmpty(s)));
            lblCurrFilterByContact.Text = txtByProjectContact.Text.Trim();
        }

        private void cmdRemFilterByProjectAddress_Click(object sender, EventArgs e)
        {
            filters["byaddr"] = "";
            jobBindingSource.Filter = string.Join(" AND ", filters.Values.Where(s => !String.IsNullOrEmpty(s)));
            txtByProjectAddress.Text = "";
            lblCurrFilterByAddress.Text = "";
        }

        private void cmdRemFilterByClientName_Click(object sender, EventArgs e)
        {
            filters["byclnt"] = "";
            jobBindingSource.Filter = string.Join(" AND ", filters.Values.Where(s => !String.IsNullOrEmpty(s)));
            txtByClientName.Text = "";
            lblCurrFilterByClientName.Text = "";
        }

        private void cmdRemFilterByProjectTown_Click(object sender, EventArgs e)
        {
            filters["bytown"] = "";
            jobBindingSource.Filter = string.Join(" AND ", filters.Values.Where(s => !String.IsNullOrEmpty(s)));
            txtByProjectTown.Text = "";
            lblCurrFilterByTown.Text = "";
        }

        private void cmdRemFilterByProjectState_Click(object sender, EventArgs e)
        {
            filters["bystat"] = "";
            jobBindingSource.Filter = string.Join(" AND ", filters.Values.Where(s => !String.IsNullOrEmpty(s)));
            txtByProjectState.Text = "";
            lblCurrFilterByState.Text = "";
        }

        private void cmdRemFilterByProjectContact_Click(object sender, EventArgs e)
        {
            filters["bycont"] = "";
            jobBindingSource.Filter = string.Join(" AND ", filters.Values.Where(s => !String.IsNullOrEmpty(s)));
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmJobsReportViewer frmRV = new frmJobsReportViewer(jobBindingSource.Filter);
            frmRV.Show();
        }
    }
}