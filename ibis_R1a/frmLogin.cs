using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using HoldenClasses;
using IbisUtils;

namespace ibis_R1a
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void chkShowPWChars_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPWChars.Checked;
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            Ibis myIbis = new Ibis();

            if (myIbis.validateLogin(txtUsername.Text, txtPassword.Text))
            {
                // login successful
                HoldenUser UserInfo = new HoldenUser(myIbis.empun, txtPassword.Text, myIbis.empnum, myIbis.profileID, myIbis.isSU);
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(Resource1.SESSION_FN, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, UserInfo);
                stream.Close();

                // open main menu
                frmMainMenu frmMM1 = new frmMainMenu();
                frmMM1.Show();
                this.Hide(); // this.Close() will trigger the frmLogin_FormClosed event which closes the application.
            }
            else
            {
                // Login Failed
                MessageBox.Show("Nuhuh. You gets none access.");
            } 
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
