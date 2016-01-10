using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HoldenClasses;

namespace ibis_R1a
{
    public partial class frmJobInfoSheet : Form
    {
        public frmJobInfoSheet()
        {
            InitializeComponent();
        }

        private void frmJobInfoSheet_Load(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Resource1.SESSION_FN, FileMode.Open, FileAccess.Read, FileShare.Read);
            HoldenUser hu = (HoldenUser)formatter.Deserialize(stream);
            stream.Close();

            using (MySqlConnection dbh = new MySqlConnection(Resource1.DB_CONNSTR_HES))
            {
                // initialize job numbers combobox.
                string sql = "SELECT job_job_key, job_id FROM job ORDER BY job_job_key ASC";
                ibiscbxExistingJobNum.Initialize(dbh, sql, "job_job_key", "job_id");

                // initialize company radio button group to pre-select HES.
                radioCompany_HES.Checked = true;

                // initialize is amendment radio button group to pre-select No.
                radioIsAmendment_No.Checked = true;

                // initialize overtime allowed radio button group to pre-select No.
                radioOTAllowed_No.Checked = true;

                // initialize form submitted by combobox.
                sql = "SELECT CONCAT(employee_e_num, ' -- ', employee_e_uname) AS employee_un, employee_id FROM employee WHERE employee_active = 1 ORDER BY employee_e_num ASC";
                ibiscbxFilledOutBy.Initialize(dbh, sql, "employee_un", "employee_id");
                string defsel = hu.empnum + " -- " + hu.un;
                ibiscbxFilledOutBy.SelectedIndex = ibiscbxFilledOutBy.FindString(defsel);
                if (!hu.isSU) ibiscbxFilledOutBy.Enabled = false;

                // initialize today's date textbox.
                txtTodaysDate.Text = DateTime.Today.ToString("d MMM yyyy");
                if (!hu.isSU) txtTodaysDate.Enabled = false;

                // initialize ibis combox box - invoice type.
                sql = "SELECT CONCAT(ibis_invoicetype_code, ' -- ', ibis_invoicetype_label) AS ibis_invoicetype_entry, ibis_invoicetype_id FROM ibis_invoicetype";
                ibiscbxInvoiceType.Initialize(dbh, sql, "ibis_invoicetype_entry", "ibis_invoicetype_id");

                // initialize project type drop-down.
                sql = "SELECT CONCAT(ibis_projecttype_code, ' -- ', ibis_projecttype_label) AS ibis_projecttype_entry, ibis_projecttype_id FROM ibis_projecttype";
                ibiscbxProjectType.Initialize(dbh, sql, "ibis_projecttype_entry", "ibis_projecttype_id");

                // initialize client type drop-down.
                sql = "SELECT CONCAT(ibis_clienttype_code, ' -- ', ibis_clienttype_label) AS ibis_clienttype_entry, ibis_clienttype_id FROM ibis_clienttype";
                ibiscbxClientType.Initialize(dbh, sql, "ibis_clienttype_entry", "ibis_clienttype_id");

                // initialize client state drop-down.
                sql = "SELECT state_id, state_abbr FROM ibis_state";
                ibiscbxClientState.Initialize(dbh, sql, "state_abbr", "state_id");

                // initialize client name drop-down.
                sql = "SELECT client_name, client_id FROM client";
                ibiscbxClientName.Initialize(dbh, sql, "client_name", "client_id");
            }
        }

        private void radioIsAmendment_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIsAmendment_Yes.Checked) ibiscbxExistingJobNum.Enabled = true;
        }

        private void radioIsAmendment_No_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIsAmendment_No.Checked) ibiscbxExistingJobNum.Enabled = false;
        }
        
        private void ibiscbxClientName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int cid;
            bool parseOK = Int32.TryParse(ibiscbxClientName.SelectedValue.ToString(), out cid);

            HoldenClient hc = new HoldenClient(cid);
            //txtClientContactPerson.Text = (string)hc.props["client_contact"].Value;
            txtClientAddress.Text = (string)hc.ha.props["address_street1"].Value;
            txtClientCode.Text = (string)hc.props["client_code"].Value;
            txtClientCity.Text = (string)hc.ha.props["address_city"].Value;
            ibiscbxClientState.SelectedValue = Convert.ToInt32(hc.ha.props["address_state"].Value);
            txtClientZip.Text = (string)hc.ha.props["address_zip"].Value;
        }
    }
}
