using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace IbisUtils
{
    public partial class IbisPermissionsContextMenuStrip : ContextMenuStrip
    {
        private bool prevPerm_None { set; get; }
        private bool prevPerm_Delete { set; get; }
        private bool prevPerm_AddNew { set; get; }
        private bool prevPerm_Edit { set; get; }
        private bool prevPerm_View { set; get; }
        public object ParentObj { set; get; }

        // default constructor sets "None" as the only checked option.
        public IbisPermissionsContextMenuStrip()
        {
            InitializeComponent();

            string[] menu_opts = { "None", "Delete", "Add New", "Edit", "View" };
            foreach (string s in menu_opts)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                tsmi.Text = s;
                if (s.Equals("None")) tsmi.Checked = true;
                else tsmi.Checked = false;
                tsmi.Click += new EventHandler(tsmi_Click);

                this.Items.Add(tsmi);
            }

            this.Closing += new ToolStripDropDownClosingEventHandler(cms_Closing);
            this.Closed += cms_Closed;
        }

        public IbisPermissionsContextMenuStrip(object p)
        {
            // p needs to be an int.
            int permlvl;
            bool isInt = Int32.TryParse(p.ToString(), out permlvl);

            InitializeComponent();

            string[] menu_opts = { "None", "Delete", "Add New", "Edit", "View" };
            foreach (string s in menu_opts)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                tsmi.Text = s;
                if (s.Equals("None")) tsmi.Checked = true;
                else tsmi.Checked = false;
                tsmi.Click += new EventHandler(tsmi_Click);

                this.Items.Add(tsmi);
            }

            this.Closing += new ToolStripDropDownClosingEventHandler(cms_Closing);
            this.Closed += cms_Closed;

            this.setMenuState(permlvl);
        }

        public IbisPermissionsContextMenuStrip(bool[] p)
        {
            InitializeComponent();

            string[] menu_opts = { "None", "Delete", "Add New", "Edit", "View" };
            foreach (string s in menu_opts)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                tsmi.Text = s;
                if (s.Equals("None")) tsmi.Checked = true;
                else tsmi.Checked = false;
                tsmi.Click += new EventHandler(tsmi_Click);

                this.Items.Add(tsmi);
            }

            this.Closing += new ToolStripDropDownClosingEventHandler(cms_Closing);
            this.Closed += cms_Closed;

            this.setMenuState(p);
        }

        void cms_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            String checkedItems = "";
            foreach (ToolStripMenuItem tmpmi in ((ContextMenuStrip)sender).Items)
            {
                if (tmpmi.Checked) checkedItems += tmpmi.Text + "\n";
            }
        }

        void cms_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked)
            {
                e.Cancel = true;
            }
        }

        void tsmi_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            tsmi.Checked ^= true;

            bool autocheckmode = false;
            int permval = 1; // we need to start at 2^0 and set it to 0 if "None" is checked.
            if (tsmi.Text == "None")
            {
                bool[] mst = { true, false, false, false, false };
                this.setMenuState(mst);
                permval = 0;
            }
            else
            {
                foreach (ToolStripMenuItem currmi in this.Items)
                {
                    if (currmi.Text.Equals("None"))
                        currmi.Checked = false;

                    // this only works if permissions are cascaded and appear in the correct order.
                    if (autocheckmode)
                    {
                        currmi.Checked = true;
                        permval *= 2;
                    }
                    else if (currmi.Checked)
                        autocheckmode = true;
                }
            }

            //// set the permissions values for the node tag and the tags of its children.
            //// if the treenode has children, propagate the value of the contextmenu selection to them.
            TreeNode tn = this.ParentObj as TreeNode;
            IbisPermissionsTag nodetag = tn.Tag as IbisPermissionsTag;
            nodetag.SetPermissions(permval);
            //if (tn != null)
            //    MessageBox.Show("selected node: " + nodetag.db_colname + "set to permlvl: " + nodetag.GetPermissionsAsInt());

            if (tn.Nodes.Count > 0)
            {
                foreach (TreeNode dnode in tn.Nodes)
                {
                    IbisPermissionsTag dnodetag = dnode.Tag as IbisPermissionsTag;
                    dnodetag.SetPermissions(permval);
                    //MessageBox.Show("selected node child: " + dnodetag.db_colname);
                    IbisPermissionsContextMenuStrip tmpmenu = dnode.ContextMenuStrip as IbisPermissionsContextMenuStrip;
                    tmpmenu.setMenuState(permval);

                    // This is the lowest possible level available on this tree so a
                    // recursive traversal of the tree is unnecessary.
                    foreach (TreeNode dnode2 in dnode.Nodes)
                    {
                        IbisPermissionsTag dnodetag2 = dnode2.Tag as IbisPermissionsTag;
                        dnodetag2.SetPermissions(permval);
                        //MessageBox.Show("selected node2 child: " + dnodetag2.db_colname);
                        IbisPermissionsContextMenuStrip tmpmenu2 = dnode2.ContextMenuStrip as IbisPermissionsContextMenuStrip;
                        tmpmenu2.setMenuState(permval);
                    }
                }
            }
        }

        private void _setNodePerms(int permval)
        {
            // set the permissions values for the node tag and the tags of its children.
            // if the treenode has children, propagate the value of the contextmenu selection to them.
            TreeNode tn = this.ParentObj as TreeNode;
            IbisPermissionsTag nodetag = tn.Tag as IbisPermissionsTag;
            nodetag.SetPermissions(permval);
            //if (tn != null)
            //    MessageBox.Show("selected node: " + nodetag.db_colname + "set to permlvl: " + nodetag.GetPermissionsAsInt());

            if (tn.Nodes.Count > 0)
            {
                foreach (TreeNode dnode in tn.Nodes)
                {
                    IbisPermissionsTag dnodetag = dnode.Tag as IbisPermissionsTag;
                    dnodetag.SetPermissions(permval);
                    //MessageBox.Show("selected node child: " + dnodetag.db_colname);
                    IbisPermissionsContextMenuStrip tmpmenu = dnode.ContextMenuStrip as IbisPermissionsContextMenuStrip;
                    tmpmenu.setMenuState(permval);
                }
            }
        }

        // this method sets all of menu items' checked properties using
        // an array of boolean values corresponding to the menu items
        // in the order in which they are added to the context menu.
        public void setMenuState(bool[] currstates)
        {
            int idx = 0;
            foreach (ToolStripMenuItem mi in this.Items)
            {
                mi.Checked = currstates[idx];
                idx++;
            }
        }

        public void setMenuState(int i_in)
        {
            bool[] currstates = { i_in == 0, i_in >= 8, i_in >= 4, i_in >= 2, i_in >= 1 };
            setMenuState(currstates);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
