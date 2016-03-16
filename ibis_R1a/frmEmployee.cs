using System;
using System.Data;
using System.IO;
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

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Resource1.SESSION_FN, FileMode.Open, FileAccess.Read, FileShare.Read);
            HoldenUser hu = (HoldenUser)formatter.Deserialize(stream);
            stream.Close();
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
