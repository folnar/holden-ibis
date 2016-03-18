using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using HoldenClasses;

namespace ibis_R1a
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            ibis_stateTableAdapter.Fill(holdenengrDataSet.ibis_state);
            ibis_perms_forDDTableAdapter.Fill(holdenengrDataSet.ibis_perms_forDD);
            ibis_yesnoTableAdapter.Fill(holdenengrDataSet.ibis_yesno);
            hesemployeeTableAdapter.Fill(holdenengrDataSet.hesemployee);

            setupAccessControl();
        }

        private void setupAccessControl()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Resource1.SESSION_FN, FileMode.Open, FileAccess.Read, FileShare.Read);
            HoldenUser hu = (HoldenUser)formatter.Deserialize(stream);
            stream.Close();

            if (Convert.ToInt16(hu.hpp.Permissions["hesemployee_hesemployee_password"]) < IbisPermClass.View)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Enabled = false;
            }
            if (Convert.ToInt16(hu.hpp.Permissions["tbl_hesemployee"]) < IbisPermClass.AddNew)
            {
                bindingNavigatorAddNewItem.Enabled = false;
            }
            if (Convert.ToInt16(hu.hpp.Permissions["tbl_hesemployee"]) < IbisPermClass.Delete)
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
            if (Convert.ToInt16(hu.hpp.Permissions["tbl_hesemployee"]) < IbisPermClass.Edit)
            {
                foreach (Control c in panelRHS.Controls)
                {
                    PropertyInfo prop = c.GetType().GetProperty("ReadOnly", BindingFlags.Public | BindingFlags.Instance);
                    if (null != prop && prop.CanWrite)
                    {
                        prop.SetValue(c, true, null);
                        c.BackColor = System.Drawing.Color.White;
                    }
                }
                foreach (Control c in panelLHS.Controls)
                {
                    PropertyInfo prop = c.GetType().GetProperty("ReadOnly", BindingFlags.Public | BindingFlags.Instance);
                    if (null != prop && prop.CanWrite)
                    {
                        prop.SetValue(c, true, null);
                        c.BackColor = System.Drawing.Color.White;
                    }
                }
                //cbxState.Enabled = false;
                //cbxState.BackColor = System.Drawing.Color.White;
                btnCommitToDB.Enabled = false;
                saveToolStripButton.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ((sender as Button).Parent as Form).Close();
        }

        private void btnCommitToDB_Click(object sender, EventArgs e)
        {
            Validate();
            hesemployeeBindingSource.EndEdit();
            try
            {
                hesemployeeTableAdapter.Update(holdenengrDataSet.hesemployee);
            }
            catch (DataException de)
            {
                MessageBox.Show("(0x0113)Data Exception: \n" + de.Message + "\nContact dcasale@umd.edu");
            }

            MessageBox.Show("Database updated.");
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Validate();
            hesemployeeBindingSource.EndEdit();
            try
            {
                hesemployeeTableAdapter.Update(holdenengrDataSet.hesemployee);
            }
            catch (DataException de)
            {
                MessageBox.Show("(0x0114)Data Exception: \n" + de.Message + "\nContact dcasale@umd.edu");
            }

            MessageBox.Show("Database updated.");
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            int pos = hesemployeeBindingSource.Find("hesemployee_lastname", tstxtLastNameSearch.Text);
            hesemployeeBindingSource.Position = pos;
        }

        private void tstxtLastNameSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tsbtnSearch.PerformClick();
            }
        }
    }
}
