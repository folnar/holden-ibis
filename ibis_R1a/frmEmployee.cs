using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'holdenengrDataSet.ibis_yesno' table. You can move, or remove it, as needed.
            this.ibis_yesnoTableAdapter.Fill(this.holdenengrDataSet.ibis_yesno);
            // TODO: This line of code loads data into the 'holdenengrDataSet.hesemployee' table. You can move, or remove it, as needed.
            this.hesemployeeTableAdapter.Fill(this.holdenengrDataSet.hesemployee);

        }
    }
}
