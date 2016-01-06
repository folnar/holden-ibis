using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HoldenClasses;
using MySql.Data.MySqlClient;

namespace ibis_R1a
{
    public partial class frmContact : Form
    {
        HoldenContact hc = new HoldenContact();
        HoldenAddress mailingaddr = new HoldenAddress();
        HoldenAddress streetaddr = new HoldenAddress();
        Dictionary<string, bool> isDirty2 = new Dictionary<string, bool>();

        public frmContact()
        {
            InitializeComponent();
        }

        private void ibiscbxContactLabel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int cid;
            if (!Int32.TryParse(ibiscbxContactLabel.SelectedValue.ToString(), out cid)) cid = 0;

            hc.PopulateFromDB(cid);
            ibiscbxAccountID.SelectedValue = hc.props["contact_accountid"].Value;
            txtLastName.Text = (string)hc.props["contact_lastname"].Value;
            txtMiddleName.Text = (string)hc.props["contact_middlename"].Value;
            txtFirstName.Text = (string)hc.props["contact_firstname"].Value;
            txtDepartment.Text = (string)hc.props["contact_department"].Value;
            txtEmailAddr.Text = (string)hc.props["contact_email"].Value;
            txtWorkPhone.Text = (string)hc.props["contact_phone"].Value;
            txtMobilePhone.Text = (string)hc.props["contact_mphone"].Value;
            
            if ((int)hc.props["contact_mailingaddr"].Value == 0) ibiscbxMailingAddressLabel.SelectedIndex = -1;
            else ibiscbxMailingAddressLabel.SelectedValue = hc.props["contact_mailingaddr"].Value;

            if ((int)hc.props["contact_streetaddr"].Value == 0) ibiscbxStreetAddressLabel.SelectedIndex = -1;
            else ibiscbxStreetAddressLabel.SelectedValue = hc.props["contact_streetaddr"].Value;

            btnCommitToDB.Image = Resource1.SAVE_BTN_ADD2;
            ibiscbxContactLabel.IsInExistingEditMode = true;

            if ((int)hc.props["contact_mailingaddr"].Value > 0) _HandleMA_SCC();
            else _Clear_MA();
            if ((int)hc.props["contact_streetaddr"].Value > 0) _HandleSA_SCC();
            else _Clear_SA();
        }

        private void _Clear_SA()
        {
            streetaddr.props["address_label"].Value = "";
            streetaddr.props["address_street1"].Value = "";
            streetaddr.props["address_street2"].Value = "";
            streetaddr.props["address_street3"].Value = "";
            streetaddr.props["address_city"].Value = "";
            streetaddr.props["address_state"].Value = 0;
            streetaddr.props["address_zip"].Value = "";
            streetaddr.props["address_country"].Value = 0;
            streetaddr.DBID = null;

            ibiscbxStreetAddressLabel.SelectedIndex = -1;
            txtStreetAddress1.Text = "";
            txtStreetAddress2.Text = "";
            txtStreetAddress3.Text = "";
            txtStreetCity.Text = "";
            ibiscbxStreetState.SelectedIndex = -1;
            txtStreetZip.Text = "";
            ibiscbxStreetCountry.SelectedIndex = -1;
        }

        private void _Clear_MA()
        {
            mailingaddr.props["address_label"].Value = "";
            mailingaddr.props["address_street1"].Value = "";
            mailingaddr.props["address_street2"].Value = "";
            mailingaddr.props["address_street3"].Value = "";
            mailingaddr.props["address_city"].Value = "";
            mailingaddr.props["address_state"].Value = 0;
            mailingaddr.props["address_zip"].Value = "";
            mailingaddr.props["address_country"].Value = 0;
            mailingaddr.DBID = null;
            
            ibiscbxMailingAddressLabel.SelectedIndex = -1;
            txtMailingAddress1.Text = "";
            txtMailingAddress2.Text = "";
            txtMailingAddress3.Text = "";
            txtMailingCity.Text = "";
            ibiscbxMailingState.SelectedIndex = -1;
            txtMailingZip.Text = "";
            ibiscbxMailingCountry.SelectedIndex = -1;
        }

        private void ibiscbxMailingAddressLabel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _HandleMA_SCC();
        }

        internal void _HandleMA_SCC()
        {
            int cid;
            if (!Int32.TryParse(ibiscbxMailingAddressLabel.SelectedValue.ToString(), out cid)) cid = 0;

            mailingaddr.PopulateFromDB(cid);
            txtMailingAddress1.Text = (string)mailingaddr.props["address_street1"].Value;
            txtMailingAddress2.Text = (string)mailingaddr.props["address_street2"].Value;
            txtMailingAddress3.Text = (string)mailingaddr.props["address_street3"].Value;
            txtMailingCity.Text = (string)mailingaddr.props["address_city"].Value;
            ibiscbxMailingState.SelectedValue = mailingaddr.props["address_state"].Value;
            txtMailingZip.Text = (string)mailingaddr.props["address_zip"].Value;
            ibiscbxMailingCountry.SelectedValue = mailingaddr.props["address_country"].Value;

            btnCommitToDB.Image = Resource1.SAVE_BTN_ADD2;
            ibiscbxMailingAddressLabel.IsInExistingEditMode = true;
        }

        private void ibiscbxStreetAddressLabel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _HandleSA_SCC();
        }

        internal void _HandleSA_SCC()
        {
            int cid;
            if (!Int32.TryParse(ibiscbxStreetAddressLabel.SelectedValue.ToString(), out cid)) cid = 0;

            streetaddr.PopulateFromDB(cid);
            txtStreetAddress1.Text = (string)streetaddr.props["address_street1"].Value;
            txtStreetAddress2.Text = (string)streetaddr.props["address_street2"].Value;
            txtStreetAddress3.Text = (string)streetaddr.props["address_street3"].Value;
            txtStreetCity.Text = (string)streetaddr.props["address_city"].Value;
            ibiscbxStreetState.SelectedValue = streetaddr.props["address_state"].Value;
            txtStreetZip.Text = (string)streetaddr.props["address_zip"].Value;
            ibiscbxStreetCountry.SelectedValue = streetaddr.props["address_country"].Value;

            btnCommitToDB.Image = Resource1.SAVE_BTN_ADD2;
            ibiscbxStreetAddressLabel.IsInExistingEditMode = true;
        }

        internal void _initIsDirtyList()
        {
            isDirty2.Clear();
            foreach (string s in hc.dbnames)
            {
                isDirty2.Add("hc_" + s, false);
            }
            foreach (string s in mailingaddr.dbnames)
            {
                isDirty2.Add("ma_" + s, false);
            }
            foreach (string s in streetaddr.dbnames)
            {
                isDirty2.Add("sa_" + s, false);
            }
        }

        internal void _resetIsDirtyList()
        {
            foreach (string k in isDirty2.Keys.ToList())
            {
                isDirty2[k] = false;
            }
        }

        private bool _isDirty2()
        {
            if (isDirty2.ContainsValue (true))
            {
                return true;
            }
            return false;
        }

        private void frmContact_Load(object sender, EventArgs e)
        {
            // initialize contact drop-down.
            ibiscbxContactLabel.Initialize(hc.dt, "contact_label", "contact_id", "contact_label");

            // initialize address label drop-downs.
            ibiscbxMailingAddressLabel.Initialize(mailingaddr.dt, "address_label", "address_id", "address_label");
            ibiscbxMailingAddressLabel.IsInSearchMode = true;
            ibiscbxStreetAddressLabel.Initialize(streetaddr.dt, "address_label", "address_id", "address_label");
            ibiscbxStreetAddressLabel.IsInSearchMode = true;

            using (MySqlConnection dbh = new MySqlConnection(Resource1.DB_CONNSTR_HES))
            {
                // initialize account drop-down.
                string sql = "SELECT client_id, client_name FROM client ORDER BY client_name";
                ibiscbxAccountID.Initialize(dbh, sql, "client_name", "client_id");
                ibiscbxAccountID.IsInSearchMode = true;

                // initialize state drop-downs.
                sql = "SELECT state_id, state_abbr FROM ibis_state";
                ibiscbxMailingState.Initialize(dbh, sql, "state_abbr", "state_id");
                ibiscbxStreetState.Initialize(dbh, sql, "state_abbr", "state_id");

                // initialize country drop-downs.
                sql = "SELECT country_id, country_name FROM ibis_country";
                ibiscbxMailingCountry.Initialize(dbh, sql, "country_name", "country_id");
                ibiscbxStreetCountry.Initialize(dbh, sql, "country_name", "country_id");

                btnCommitToDB.Image = Resource1.SAVE_BTN_ADD2;
            }

            // initialize the list of items which tracks which form fields are dirty or clean.
            _initIsDirtyList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ((sender as Button).Parent as Form).Close();
        }

        private void _clearFormAndObject()
        {
            hc.props["contact_accountid"].Value = 0;
            hc.props["contact_lastname"].Value = "";
            hc.props["contact_middlename"].Value = "";
            hc.props["contact_firstname"].Value = "";
            hc.props["contact_department"].Value = "";
            hc.props["contact_email"].Value = "";
            hc.props["contact_phone"].Value = "";
            hc.props["contact_mphone"].Value = "";
            hc.props["contact_mailingaddr"].Value = 0;
            hc.props["contact_streetaddr"].Value = 0;
            hc.DBID = null;

            _Clear_MA();
            _Clear_SA();

            ibiscbxContactLabel.SelectedIndex = -1;

            ibiscbxAccountID.SelectedIndex = -1;
            txtLastName.Text = "";
            txtMiddleName.Text = "";
            txtFirstName.Text = "";
            txtDepartment.Text = "";
            txtEmailAddr.Text = "";
            txtWorkPhone.Text = "";
            txtMobilePhone.Text = "";
        }

        private void btnCommitToDB_Click(object sender, EventArgs e)
        {
            hc.props["contact_label"].Value = ibiscbxContactLabel.Text;
            hc.props["contact_accountid"].Value = Convert.ToInt32(ibiscbxAccountID.SelectedValue);
            hc.props["contact_lastname"].Value = txtLastName.Text;
            hc.props["contact_middlename"].Value = txtMiddleName.Text;
            hc.props["contact_firstname"].Value = txtFirstName.Text;
            hc.props["contact_department"].Value = txtDepartment.Text;
            hc.props["contact_email"].Value = txtEmailAddr.Text;
            hc.props["contact_phone"].Value = txtWorkPhone.Text;
            hc.props["contact_mphone"].Value = txtMobilePhone.Text;

            if (ibiscbxMailingAddressLabel.Text.Equals(""))
            {
                ibiscbxMailingAddressLabel.SelectedIndex = 0;
                hc.props["contact_mailingaddr"].Value = 0;
            }
            else
            {
                hc.props["contact_mailingaddr"].Value = Convert.ToInt32(ibiscbxMailingAddressLabel.SelectedValue);
                mailingaddr.props["address_label"].Value = ibiscbxMailingAddressLabel.Text;
                mailingaddr.props["address_street1"].Value = txtMailingAddress1.Text;
                mailingaddr.props["address_street2"].Value = txtMailingAddress2.Text;
                mailingaddr.props["address_street3"].Value = txtMailingAddress3.Text;
                mailingaddr.props["address_city"].Value = txtMailingCity.Text;
                mailingaddr.props["address_state"].Value = Convert.ToInt32(ibiscbxMailingState.SelectedValue);
                mailingaddr.props["address_zip"].Value = txtMailingZip.Text;
                mailingaddr.props["address_country"].Value = Convert.ToInt32(ibiscbxMailingCountry.SelectedValue);
            }

            if (ibiscbxStreetAddressLabel.Text.Equals(""))
            {
                ibiscbxStreetAddressLabel.SelectedIndex = 0;
                hc.props["contact_streetaddr"].Value = 0;
            }
            else
            {
                hc.props["contact_streetaddr"].Value = Convert.ToInt32(ibiscbxStreetAddressLabel.SelectedValue);
                streetaddr.props["address_label"].Value = ibiscbxStreetAddressLabel.Text;
                streetaddr.props["address_street1"].Value = txtStreetAddress1.Text;
                streetaddr.props["address_street2"].Value = txtStreetAddress2.Text;
                streetaddr.props["address_street3"].Value = txtStreetAddress3.Text;
                streetaddr.props["address_city"].Value = txtStreetCity.Text;
                streetaddr.props["address_state"].Value = Convert.ToInt32(ibiscbxStreetState.SelectedValue);
                streetaddr.props["address_zip"].Value = txtStreetZip.Text;
                streetaddr.props["address_country"].Value = Convert.ToInt32(ibiscbxStreetCountry.SelectedValue);
            }

            hc.CommitToDB();
            if (ibiscbxMailingAddressLabel.SelectedIndex > 0)
            {
                mailingaddr.CommitToDB();
                _HandleMA_SCC();
            }
            if (ibiscbxStreetAddressLabel.SelectedIndex > 0)
            {
                streetaddr.CommitToDB();
                _HandleSA_SCC();
            }

            btnCommitToDB.Image = Resource1.SAVE_BTN_ADD2;
            radioMode_AddNew.Checked = false;
            radioMode_Edit.Checked = true;
            radioMode_Search.Checked = false;

            ibiscbxContactLabel.Initialize(hc.dt, "contact_label", "contact_id", "contact_label");
            ibiscbxContactLabel.IsInExistingEditMode = true;
            ibiscbxContactLabel.Text = hc.props["contact_label"].Value.ToString();
            ibiscbxMailingAddressLabel.Initialize(mailingaddr.dt, "address_label", "address_id");
            if (mailingaddr.DBID > 0)
                ibiscbxMailingAddressLabel.SelectedValue = mailingaddr.DBID;
            else
                ibiscbxMailingAddressLabel.SelectedIndex = -1;
            ibiscbxStreetAddressLabel.Initialize(streetaddr.dt, "address_label", "address_id");
            if (streetaddr.DBID > 0)
                ibiscbxStreetAddressLabel.SelectedValue = streetaddr.DBID;
            else
                ibiscbxStreetAddressLabel.SelectedIndex = -1;

            _resetIsDirtyList();

            MessageBox.Show("Changes have been committed to database.");
        }

        private bool isDirty()
        {
            if (!ibiscbxAccountID.Text.Equals((string)hc.props["contact_label"].Value) ||
                !txtFirstName.Text.Equals((string)hc.props["contact_firstname"].Value) ||
                !txtMiddleName.Text.Equals((string)hc.props["contact_middlename"].Value) ||
                !txtLastName.Text.Equals((string)hc.props["contact_lastname"].Value) ||
                !txtDepartment.Text.Equals((string)hc.props["contact_department"].Value) ||
                !txtEmailAddr.Text.Equals((string)hc.props["contact_email"].Value) ||
                !txtWorkPhone.Text.Equals((string)hc.props["contact_phone"].Value) ||
                !txtMobilePhone.Text.Equals((string)hc.props["contact_mphone"].Value) ||
                Convert.ToInt32(ibiscbxMailingAddressLabel.SelectedValue) != Convert.ToInt32(hc.props["contact_mailingaddr"].Value) ||
                Convert.ToInt32(ibiscbxStreetAddressLabel.SelectedValue) != Convert.ToInt32(hc.props["contact_streetaddr"].Value) ||
                !ibiscbxMailingAddressLabel.Text.Equals((string)mailingaddr.props["address_label"].Value) ||
                !txtMailingAddress1.Text.Equals((string)mailingaddr.props["address_street1"].Value) ||
                !txtMailingAddress2.Text.Equals((string)mailingaddr.props["address_street2"].Value) ||
                !txtMailingAddress3.Text.Equals((string)mailingaddr.props["address_street3"].Value) ||
                !txtMailingCity.Text.Equals((string)mailingaddr.props["address_city"].Value) ||
                Convert.ToInt32(ibiscbxMailingState.SelectedValue) != Convert.ToInt32(mailingaddr.props["address_state"].Value) ||
                !txtMailingZip.Text.Equals((string)mailingaddr.props["address_zip"].Value) ||
                Convert.ToInt32(ibiscbxMailingCountry.SelectedValue) != Convert.ToInt32(mailingaddr.props["address_country"].Value) ||
                !ibiscbxStreetAddressLabel.Text.Equals((string)streetaddr.props["address_label"].Value) ||
                !txtStreetAddress1.Text.Equals((string)streetaddr.props["address_street1"].Value) ||
                !txtStreetAddress2.Text.Equals((string)streetaddr.props["address_street2"].Value) ||
                !txtStreetAddress3.Text.Equals((string)streetaddr.props["address_street3"].Value) ||
                !txtStreetCity.Text.Equals((string)streetaddr.props["address_city"].Value) ||
                Convert.ToInt32(ibiscbxStreetState.SelectedValue) != Convert.ToInt32(streetaddr.props["address_state"].Value) ||
                !txtStreetZip.Text.Equals((string)streetaddr.props["address_zip"].Value) ||
                Convert.ToInt32(ibiscbxStreetCountry.SelectedValue) != Convert.ToInt32(streetaddr.props["address_country"].Value)
                )
                return true;
            else
            return false;
        }

        private void checkFormState()
        {
            if (_isDirty2())
                btnCommitToDB.Image = Resource1.SAVE_BTN_ERROR;
            else
                btnCommitToDB.Image = Resource1.SAVE_BTN_ADD2;
        }

        private void radioMode_Search_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMode_Search.Checked)
            {
                ibiscbxContactLabel.IsInSearchMode = true;
                ibiscbxMailingAddressLabel.IsInSearchMode = true;
                ibiscbxStreetAddressLabel.IsInSearchMode = true;
                ibiscbxAccountID.IsInSearchMode = true;
                ibiscbxContactLabel.Focus();
                btnCommitToDB.Enabled = false;
            }
        }

        private void radioMode_Edit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMode_Edit.Checked)
            {
                ibiscbxContactLabel.IsInExistingEditMode = true;
                ibiscbxMailingAddressLabel.IsInExistingEditMode = true;
                ibiscbxStreetAddressLabel.IsInExistingEditMode = true;
                ibiscbxAccountID.IsInExistingEditMode = true;
                ibiscbxContactLabel.Focus();
                btnCommitToDB.Enabled = true;
            }
        }

        private void radioMode_AddNew_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMode_AddNew.Checked)
            {
                ibiscbxContactLabel.IsInNewStringMode = true;
                ibiscbxMailingAddressLabel.IsInNewStringMode = true;
                ibiscbxStreetAddressLabel.IsInNewStringMode = true;
                ibiscbxAccountID.IsInNewStringMode = true;
                ibiscbxContactLabel.Focus();
                btnCommitToDB.Enabled = true;
                _clearFormAndObject();
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals((string)hc.props["contact_firstname"].Value)) return;
            else isDirty2["hc_contact_firstname"] = true;
            checkFormState();
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            if (txtMiddleName.Text.Equals((string)hc.props["contact_middlename"].Value)) return;
            else isDirty2["hc_contact_middlename"] = true;
            checkFormState();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text.Equals((string)hc.props["contact_lastname"].Value)) return;
            else isDirty2["hc_contact_lastname"] = true;
            checkFormState();
        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {
            if (txtDepartment.Text.Equals((string)hc.props["contact_department"].Value)) return;
            else isDirty2["hc_contact_department"] = true;
            checkFormState();
        }

        private void txtEmailAddr_TextChanged(object sender, EventArgs e)
        {
            if (txtEmailAddr.Text.Equals((string)hc.props["contact_email"].Value)) return;
            else isDirty2["hc_contact_email"] = true;
            checkFormState();
        }

        private void txtWorkPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtWorkPhone.Text.Equals((string)hc.props["contact_phone"].Value)) return;
            else isDirty2["hc_contact_phone"] = true;
            checkFormState();
        }

        private void txtMobilePhone_TextChanged(object sender, EventArgs e)
        {
            if (txtMobilePhone.Text.Equals((string)hc.props["contact_mphone"].Value)) return;
            else isDirty2["hc_contact_mphone"] = true;
            checkFormState();
        }

        private void txtMailingAddress1_TextChanged(object sender, EventArgs e)
        {
            if (txtMailingAddress1.Text.Equals((string)mailingaddr.props["address_street1"].Value)) return;
            else isDirty2["ma_address_street1"] = true;
            checkFormState();
        }

        private void txtMailingAddress2_TextChanged(object sender, EventArgs e)
        {
            if (txtMailingAddress2.Text.Equals((string)mailingaddr.props["address_street2"].Value)) return;
            else isDirty2["ma_address_street2"] = true;
            checkFormState();
        }

        private void txtMailingAddress3_TextChanged(object sender, EventArgs e)
        {
            if (txtMailingAddress3.Text.Equals((string)mailingaddr.props["address_street3"].Value)) return;
            else isDirty2["ma_address_street3"] = true;
            checkFormState();
        }

        private void txtMailingCity_TextChanged(object sender, EventArgs e)
        {
            if (txtMailingCity.Text.Equals((string)mailingaddr.props["address_city"].Value)) return;
            else isDirty2["ma_address_city"] = true;
            checkFormState();
        }

        private void ibiscbxMailingState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (ibiscbxMailingState.Text.Equals((string)mailingaddr.props["address_state"].Value)) return;
            else isDirty2["ma_address_state"] = true;
            checkFormState();
        }

        private void txtMailingZip_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals((string)mailingaddr.props["address_zip"].Value)) return;
            else isDirty2["ma_address_zip"] = true;
            checkFormState();
        }

        private void ibiscbxMailingCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals((string)mailingaddr.props["address_country"].Value)) return;
            else isDirty2["ma_address_country"] = true;
            checkFormState();
        }

        private void ibiscbxMailingAddressLabel_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals((string)mailingaddr.props["address_label"].Value)) return;
            else isDirty2["ma_address_label"] = true;
            checkFormState();
        }

        private void ibiscbxMailingAddressLabel_TextUpdate(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals((string)mailingaddr.props["address_label"].Value)) return;
            else isDirty2["ma_address_label"] = true;
            checkFormState();
        }

        private void txtStreetAddress1_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals((string)streetaddr.props["address_street1"].Value)) return;
            else isDirty2["sa_address_street1"] = true;
            checkFormState();
        }

        private void txtStreetAddress2_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals((string)streetaddr.props["address_street2"].Value)) return;
            else isDirty2["sa_address_street2"] = true;
            checkFormState();
        }

        private void txtStreetAddress3_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals((string)streetaddr.props["address_street3"].Value)) return;
            else isDirty2["sa_address_street3"] = true;
            checkFormState();
        }

        private void txtStreetCity_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals((string)streetaddr.props["address_city"].Value)) return;
            else isDirty2["sa_address_city"] = true;
            checkFormState();
        }

        private void ibiscbxStreetState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals((string)streetaddr.props["address_state"].Value)) return;
            else isDirty2["sa_address_state"] = true;
            checkFormState();
        }

        private void txtStreetZip_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals((string)streetaddr.props["address_zip"].Value)) return;
            else isDirty2["sa_address_zip"] = true;
            checkFormState();
        }

        private void ibiscbxStreetCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals((string)streetaddr.props["address_country"].Value)) return;
            else isDirty2["sa_address_country"] = true;
            checkFormState();
        }

        private void ibiscbxStreetAddressLabel_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals((string)streetaddr.props["address_label"].Value)) return;
            else isDirty2["sa_address_label"] = true;
            checkFormState();
        }

        private void ibiscbxStreetAddressLabel_TextUpdate(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals((string)streetaddr.props["address_label"].Value)) return;
            else isDirty2["sa_address_label"] = true;
            checkFormState();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _clearFormAndObject();
            ibiscbxContactLabel.ResetSearch();
            ibiscbxContactLabel.SelectedIndex = -1;
            ibiscbxMailingAddressLabel.ResetSearch();
            ibiscbxMailingAddressLabel.SelectedIndex = -1;
            ibiscbxStreetAddressLabel.ResetSearch();
            ibiscbxStreetAddressLabel.SelectedIndex = -1;
        }
    }
}
