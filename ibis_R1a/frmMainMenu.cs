using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using HoldenClasses;

namespace ibis_R1a
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            this.FormClosing += frmMainMenu_FormClosing;

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Resource1.SESSION_FN, FileMode.Open, FileAccess.Read, FileShare.Read);
            HoldenUser hu = (HoldenUser)formatter.Deserialize(stream);
            stream.Close();

            if (!hu.isSU)
            {
                cmdAdmin_UpdatePerms.Hide();
            }
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cmdAdmin_UpdatePerms_Click(object sender, EventArgs e)
        {
            frmUpdatePerms frmUP1 = new frmUpdatePerms();
            frmUP1.Show();
        }

        private void cmdExitfromMM_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdJobInfoSheet_Click(object sender, EventArgs e)
        {
            frmJobInfoSheet frmJIS = new frmJobInfoSheet();
            frmJIS.Show();
        }

        private void btnAddressForm_Click(object sender, EventArgs e)
        {
            frmAddress frmAddr = new frmAddress();
            frmAddr.Show();
        }

        private void btnContactForm_Click(object sender, EventArgs e)
        {
            frmContact frmCtct = new frmContact();
            frmCtct.Show();
        }

        private void btnTestForms_Click(object sender, EventArgs e)
        {
            frmBudget frmJ = new frmBudget();
            frmJ.Show();
        }

        private void btnManageEmployees_Click(object sender, EventArgs e)
        {
            frmEmployee frmE = new frmEmployee();
            frmE.Show();
        }
    }
}
