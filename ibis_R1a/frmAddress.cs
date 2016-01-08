using System;
using System.Windows.Forms;
using HoldenClasses;
using MySql.Data.MySqlClient;

namespace ibis_R1a
{
    public partial class frmAddress : Form
    {
        HoldenAddress ha = new HoldenAddress();

        public frmAddress()
        {
            InitializeComponent();
        }

        private void ibiscbxAddressLabel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int cid;
            if (!Int32.TryParse(ibiscbxAddressLabel.SelectedValue.ToString(), out cid)) cid = 0;

            ha.PopulateFromDB(cid);
            txtAddress1.Text = (string)ha.props["address_street1"].Value;
            txtAddress2.Text = (string)ha.props["address_street2"].Value;
            txtAddress3.Text = (string)ha.props["address_street3"].Value;
            txtCity.Text = (string)ha.props["address_city"].Value;
            ibiscbxState.SelectedValue = ha.props["address_state"].Value;
            txtZip.Text = (string)ha.props["address_zip"].Value;
            ibiscbxCountry.SelectedValue = ha.props["address_country"].Value;

            btnCommitToDB.Image = Resource1.SAVE_BTN_ADD2;
            ibiscbxAddressLabel.IsInExistingEditMode = true;
        }

        private void frmAddress_Load(object sender, EventArgs e)
        {
            // initialize address label drop-down.
            ibiscbxAddressLabel.Initialize(ha.dt, "address_label", "address_id", "address_label");

            using (MySqlConnection dbh = new MySqlConnection(Resource1.DB_CONNSTR_HES))
            {
                // initialize state drop-down.
                string sql = "SELECT state_id, state_abbr FROM ibis_state";
                ibiscbxState.Initialize(dbh, sql, "state_abbr", "state_id");

                // initialize country drop-down.
                sql = "SELECT country_id, country_name FROM ibis_country";
                ibiscbxCountry.Initialize(dbh, sql, "country_name", "country_id");

                btnCommitToDB.Image = Resource1.SAVE_BTN_ADD2;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ((sender as Button).Parent as Form).Close();
        }

        private void _clearFormAndObject()
        {
            ha.props["address_label"].Value = "";
            ha.props["address_street1"].Value = "";
            ha.props["address_street2"].Value = "";
            ha.props["address_street3"].Value = "";
            ha.props["address_city"].Value = "";
            ha.props["address_state"].Value = 0;
            ha.props["address_zip"].Value = "";
            ha.props["address_country"].Value = 0;
            ha.DBID = null; 
            ibiscbxAddressLabel.SelectedIndex = -1;
            ibiscbxAddressLabel.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtAddress3.Text = "";
            txtCity.Text = "";
            ibiscbxState.SelectedIndex = -1;
            txtZip.Text = "";
            ibiscbxCountry.SelectedIndex = -1;
        }

        private void btnCommitToDB_Click(object sender, EventArgs e)
        {
            ha.props["address_label"].Value = ibiscbxAddressLabel.Text;
            ha.props["address_street1"].Value = txtAddress1.Text;
            ha.props["address_street2"].Value = txtAddress2.Text;
            ha.props["address_street3"].Value = txtAddress3.Text;
            ha.props["address_city"].Value = txtCity.Text;
            ha.props["address_state"].Value = Convert.ToInt32(ibiscbxState.SelectedValue);
            ha.props["address_zip"].Value = txtZip.Text;
            ha.props["address_country"].Value = Convert.ToInt32(ibiscbxCountry.SelectedValue);

            ha.CommitToDB();
            btnCommitToDB.Image = Resource1.SAVE_BTN_ADD2;
            MessageBox.Show("Address changes have been committed to database.");
            radioMode_AddNew.Checked = false;
            radioMode_Edit.Checked = true;
            radioMode_Search.Checked = false;

            ibiscbxAddressLabel.Initialize(ha.dt, "address_label", "address_id", "address_label");
            ibiscbxAddressLabel.IsInExistingEditMode = true;
            ibiscbxAddressLabel.Text = (string)ha.props["address_label"].Value;
        }

        private bool isDirty()
        {
            if (!ibiscbxAddressLabel.Text.Equals((string)ha.props["address_label"].Value) ||
                !txtAddress1.Text.Equals((string)ha.props["address_street1"].Value) ||
                !txtAddress2.Text.Equals((string)ha.props["address_street2"].Value) ||
                !txtAddress3.Text.Equals((string)ha.props["address_street3"].Value) ||
                !txtCity.Text.Equals((string)ha.props["address_city"].Value) ||
                Convert.ToInt32(ibiscbxState.SelectedValue) != Convert.ToInt32(ha.props["address_state"].Value) ||
                !txtZip.Text.Equals((string)ha.props["address_zip"].Value) ||
                Convert.ToInt32(ibiscbxCountry.SelectedValue) != Convert.ToInt32(ha.props["address_country"].Value))
                return true;
            else
                return false;
        }

        private void checkFormState()
        {
            if (this.isDirty()) btnCommitToDB.Image = Resource1.SAVE_BTN_ERROR;
            else btnCommitToDB.Image = Resource1.SAVE_BTN_ADD2;
        }

        private void txtAddress1_TextChanged(object sender, EventArgs e)
        {
            checkFormState();
        }

        private void txtAddress2_TextChanged(object sender, EventArgs e)
        {
            checkFormState();
        }

        private void txtAddress3_TextChanged(object sender, EventArgs e)
        {
            checkFormState();
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            checkFormState();
        }

        private void ibiscbxState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            checkFormState();
        }

        private void txtZip_TextChanged(object sender, EventArgs e)
        {
            checkFormState();
        }

        private void ibiscbxCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            checkFormState();
        }

        private void ibiscbxAddressLabel_TextChanged(object sender, EventArgs e)
        {
            checkFormState();
        }

        private void ibiscbxAddressLabel_TextUpdate(object sender, EventArgs e)
        {
            checkFormState();
        }

        private void radioMode_Search_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMode_Search.Checked)
            {
                ibiscbxAddressLabel.IsInSearchMode = true;
                ibiscbxAddressLabel.Focus();
                btnCommitToDB.Enabled = false;
            }
        }

        private void radioMode_Edit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMode_Edit.Checked)
            {
                ibiscbxAddressLabel.IsInExistingEditMode = true;
                ibiscbxAddressLabel.Focus();
                btnCommitToDB.Enabled = true;
            }
        }

        private void radioMode_AddNew_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMode_AddNew.Checked)
            {
                ibiscbxAddressLabel.IsInNewStringMode = true;
                ibiscbxAddressLabel.Focus();
                btnCommitToDB.Enabled = true;
                _clearFormAndObject();
            }
        }
    }
}
