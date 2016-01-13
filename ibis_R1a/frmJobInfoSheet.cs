using System;
using System.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
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

            // initialize job numbers combobox.
            using (holdenengrDataSet.jobDataTable jobtbl = jobTableAdapter1.GetData())
            {
                cbxExistingJobNum.DataSource = jobtbl.DefaultView;
                cbxExistingJobNum.DisplayMember = "job_job_key";
                cbxExistingJobNum.ValueMember = "job_id";

                DataView dvCR1 = new DataView(jobtbl);
                cbxCrossRef1.DataSource = dvCR1;
                cbxCrossRef1.DisplayMember = "job_job_key";
                cbxCrossRef1.ValueMember = "job_id";

                DataView dvCR2 = new DataView(jobtbl);
                cbxCrossRef2.DataSource = dvCR2;
                cbxCrossRef2.DisplayMember = "job_job_key";
                cbxCrossRef2.ValueMember = "job_id";

                DataView dvCR3 = new DataView(jobtbl);
                cbxCrossRef3.DataSource = dvCR3;
                cbxCrossRef3.DisplayMember = "job_job_key";
                cbxCrossRef3.ValueMember = "job_id";

                DataView dvCR4 = new DataView(jobtbl);
                cbxCrossRef4.DataSource = dvCR4;
                cbxCrossRef4.DisplayMember = "job_job_key";
                cbxCrossRef4.ValueMember = "job_id";
            }

            // initialize form submitted by combobox.
            using (holdenengrDataSet.employeeDataTable emptbl = employeeTableAdapter1.GetDataForComboBox())
            {
                cbxFilledOutBy.DataSource = emptbl.DefaultView;
                cbxFilledOutBy.DisplayMember = "employee_un";
                cbxFilledOutBy.ValueMember = "employee_id";

                DataView dvPM1 = new DataView(emptbl);
                ddProjMgr1.DataSource = dvPM1;
                ddProjMgr1.DisplayMember = "employee_un";
                ddProjMgr1.ValueMember = "employee_id";

                DataView dvPM2 = new DataView(emptbl);
                ddProjMgr2.DataSource = dvPM2;
                ddProjMgr2.DisplayMember = "employee_un";
                ddProjMgr2.ValueMember = "employee_id";
            }
            string defsel = hu.empnum + " -- " + hu.un;
            cbxFilledOutBy.SelectedIndex = cbxFilledOutBy.FindString(defsel);
            if (!hu.isSU) cbxFilledOutBy.Enabled = false;

            // initialize company radio button group to pre-select HES.
            radioCompany_HES.Checked = true;

            // initialize is amendment radio button group to pre-select No.
            radioIsAmendment_No.Checked = true;

            // initialize overtime allowed radio button group to pre-select No.
            radioOTAllowed_No.Checked = true;

            // initialize today's date textbox.
            txtTodaysDate.Text = DateTime.Today.ToString("d MMM yyyy");
            if (!hu.isSU) txtTodaysDate.Enabled = false;

            // initialize ibis combox box - invoice type.
            using (holdenengrDataSet.ibis_invoicetypeDataTable invtyptbl = ibis_invoicetypeTableAdapter1.GetDataForDropDown())
            {
                cbxInvoiceType.DataSource = invtyptbl.DefaultView;
                cbxInvoiceType.DisplayMember = "ibis_invoicetype_entry";
                cbxInvoiceType.ValueMember = "ibis_invoicetype_id";
            }

            // initialize project type drop-down.
            using (holdenengrDataSet.ibis_projecttypeDataTable prjtyptbl = ibis_projecttypeTableAdapter1.GetDataForDropDown())
            {
                cbxProjectType.DataSource = prjtyptbl.DefaultView;
                cbxProjectType.DisplayMember = "ibis_projecttype_entry";
                cbxProjectType.ValueMember = "ibis_projecttype_id";
            }

            // initialize client type drop-down.
            using (holdenengrDataSet.ibis_clienttypeDataTable clttyptbl = ibis_clienttypeTableAdapter1.GetDataForDropDown())
            {
                cbxClientType.DataSource = clttyptbl.DefaultView;
                cbxClientType.DisplayMember = "ibis_clienttype_entry";
                cbxClientType.ValueMember = "ibis_clienttype_id";
            }

            // initialize client state drop-down.
            using (holdenengrDataSet.ibis_stateDataTable statetbl = ibis_stateTableAdapter1.GetData())
            {
                cbxClientState.DataSource = statetbl.DefaultView;
                cbxClientState.DisplayMember = "state_abbr";
                cbxClientState.ValueMember = "state_id";
            }
        }

        private void radioIsAmendment_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIsAmendment_Yes.Checked) cbxExistingJobNum.Enabled = true;
        }

        private void radioIsAmendment_No_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIsAmendment_No.Checked) cbxExistingJobNum.Enabled = false;
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
            cbxClientState.SelectedValue = Convert.ToInt32(hc.ha.props["address_state"].Value);
            txtClientZip.Text = (string)hc.ha.props["address_zip"].Value;
        }
    }
}
