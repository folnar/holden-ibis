using System;
using System.Windows.Forms;

namespace IbisUtils
{
    public partial class IbisMessageBox : Form
    {
        public IbisMessageBox()
        {
            InitializeComponent();
        }

        public IbisMessageBox(string msg)
        {
            InitializeComponent();
            this.Content.Text = msg;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
