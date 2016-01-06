using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HoldenClasses;
using IbisUtils;

namespace ibis_R1a
{
    public partial class frmUpdatePerms : Form
    {
        public frmUpdatePerms()
        {
            InitializeComponent();
        }

        private void frmUpdatePerms_Load(object sender, EventArgs e)
        {
            LoadPermissions();
            cmdAddEditPermProfiles.Tag = "addnew";
        }

        private void LoadPermissions()
        {
            Ibis ibisobj = new Ibis();
            ibisobj.loadDBSchema();

            // create list of existing database tables and active listdefs, formdefs, and prefilterdefs.
            List<string> extant = new List<string>();
            Dictionary<string, int> flds = new Dictionary<string, int>();

            TreeNode outermost_level = new TreeNode("DATABASE FIELDS");
            outermost_level.ContextMenuStrip = new IbisPermissionsContextMenuStrip(0);
            outermost_level.Tag = new IbisPermissionsTag("DATABASE FIELDS");
            ((IbisPermissionsContextMenuStrip)outermost_level.ContextMenuStrip).ParentObj = outermost_level;
            tvPermUpdForm.Nodes.Add(outermost_level);
            
            foreach (IbisSchemaTable tablerec in ibisobj.DBSchema)
            {
                if (tablerec.tablename.Equals("ibis_perms")) continue;

                TreeNode tmpnode1 = new TreeNode(tablerec.tablename);
                tmpnode1.ContextMenuStrip = new IbisPermissionsContextMenuStrip(0);
                tmpnode1.Tag = new IbisPermissionsTag("tbl_" + tablerec.tablename);
                ((IbisPermissionsContextMenuStrip)tmpnode1.ContextMenuStrip).ParentObj = tmpnode1;
                flds.Add(tablerec.tablename, 0);
                extant.Add("tbl_" + tablerec.tablename);

                foreach (IbisSchemaRecMeta entry in tablerec.schematbl)
                {
                    extant.Add(tablerec.tablename + "_" + entry.fldnm);
                    TreeNode tmpnode2 = new TreeNode(tablerec.tablename + "_" + entry.fldnm);
                    tmpnode2.ContextMenuStrip = new IbisPermissionsContextMenuStrip(0);
                    tmpnode2.Tag = new IbisPermissionsTag(tablerec.tablename + "_" + entry.fldnm);
                    ((IbisPermissionsContextMenuStrip)tmpnode2.ContextMenuStrip).ParentObj = tmpnode2;

                    if (entry.fldtyp.StartsWith("VarChar", StringComparison.Ordinal)) tmpnode2.ForeColor = Color.ForestGreen;
                    else if (entry.fldtyp.EndsWith("KEY", StringComparison.Ordinal)) tmpnode2.ForeColor = Color.Purple;
                    else if (entry.fldtyp.StartsWith("INT", StringComparison.Ordinal)) tmpnode2.ForeColor = Color.SaddleBrown;

                    tmpnode1.Nodes.Add(tmpnode2);
                }

                outermost_level.Nodes.Add(tmpnode1);
            }
            lblPermUpdNumTables.Text = ibisobj.DBSchema.Count + " tables retrieved from db.";

            TreeNode tmpnode = new TreeNode("FORM DEFINITIONS");
            tmpnode.ContextMenuStrip = new IbisPermissionsContextMenuStrip(0);
            tmpnode.Tag = new IbisPermissionsTag("FORM DEFINITIONS");
            ((IbisPermissionsContextMenuStrip)tmpnode.ContextMenuStrip).ParentObj = tmpnode;
            tvPermUpdForm.Nodes.Add(tmpnode);
            foreach (string s in ibisobj.getActiveDefNames("form"))
            {
                string defnm = s.Substring(0, s.Length - 4);
                extant.Add(defnm);
                TreeNode tn = new TreeNode(s);
                tn.Tag = new IbisPermissionsTag(defnm);
                tn.ContextMenuStrip = new IbisPermissionsContextMenuStrip();
                ((IbisPermissionsContextMenuStrip)tn.ContextMenuStrip).ParentObj = tn;
                tmpnode.Nodes.Add(tn);
            }
            
            tmpnode = new TreeNode("LIST DEFINITIONS");
            tmpnode.ContextMenuStrip = new IbisPermissionsContextMenuStrip(0);
            tmpnode.Tag = new IbisPermissionsTag("LIST DEFINITIONS");
            ((IbisPermissionsContextMenuStrip)tmpnode.ContextMenuStrip).ParentObj = tmpnode;
            tvPermUpdForm.Nodes.Add(tmpnode);
            foreach (string s in ibisobj.getActiveDefNames("list"))
            {
                string defnm = s.Substring(0, s.Length - 4);
                extant.Add(defnm);
                TreeNode tn = new TreeNode(s);
                tn.Tag = new IbisPermissionsTag(defnm);
                tn.ContextMenuStrip = new IbisPermissionsContextMenuStrip();
                ((IbisPermissionsContextMenuStrip)tn.ContextMenuStrip).ParentObj = tn;
                tmpnode.Nodes.Add(tn);
            }
            
            tmpnode = new TreeNode("PREFILTER DEFINITIONS");
            tmpnode.ContextMenuStrip = new IbisPermissionsContextMenuStrip(0);
            tmpnode.Tag = new IbisPermissionsTag("PREFILTER DEFINITIONS");
            ((IbisPermissionsContextMenuStrip)tmpnode.ContextMenuStrip).ParentObj = tmpnode;
            tvPermUpdForm.Nodes.Add(tmpnode);
            foreach (string s in ibisobj.getActiveDefNames("prefilter"))
            {
                string defnm = s.Substring(0, s.Length - 5);
                extant.Add(defnm);
                TreeNode tn = new TreeNode(s);
                tn.Tag = new IbisPermissionsTag(defnm);
                tn.ContextMenuStrip = new IbisPermissionsContextMenuStrip();
                ((IbisPermissionsContextMenuStrip)tn.ContextMenuStrip).ParentObj = tn;
                tmpnode.Nodes.Add(tn);
            }

            //
            // UPDATE THESE COMBOBOXES TO IBISCOMBOBOXES.
            //
            _populateProfilesCMB();

            // see if there are items in the database which need permissions added to the profile records.
            HoldenPermissionsProfile hpp = new HoldenPermissionsProfile(ibisobj.profileID);
            IEnumerable<string> missing = extant.Except(hpp.Permissions.Keys);
            foreach (string s in missing)
            {
                tvToAdd.Nodes.Add(s);
            }

            if (tvToAdd.Nodes.Count > 0)
            {
                btnAddPermToDB.Text = "Add These Permissions";
                btnAddPermToDB.Tag = "a";
                btnAddPermToDB.Visible = true;
                cmdAddEditPermProfiles.Enabled = false;
                cmbPermProfileSel.Enabled = false;
            }
            // otherwise, see if permissions profile columns need to be removed from the table.
            else
            {
                IEnumerable<string> toomany = hpp.Permissions.Keys.Except(extant);
                foreach (string s in toomany)
                {
                    tvToAdd.Nodes.Add(s);
                }
                if (tvToAdd.Nodes.Count > 0)
                {
                    btnAddPermToDB.Text = "Remove These Permissions";
                    btnAddPermToDB.Tag = "r";
                    btnAddPermToDB.Visible = true;
                    cmdAddEditPermProfiles.Enabled = false;
                    cmbPermProfileSel.Enabled = false;
                }
            }
        }

        private void _populateProfilesCMB()
        {
            Ibis ibisobj = new Ibis();
            string sql = "SELECT ibis_perms_id, ibis_perms_profilename FROM ibis_perms ORDER BY ibis_perms_profilename";
            ibisobj.populateComboBoxMenu(sql, this.cmbPermProfileSel, "ibis_perms_profilename", "ibis_perms_id");
        }

        private void _populateProfilesCMB(object inparam)
        {
            int currval;
            int.TryParse(inparam.ToString(), out currval);
            Ibis ibisobj = new Ibis();
            string sql = "SELECT ibis_perms_id, ibis_perms_profilename FROM ibis_perms ORDER BY ibis_perms_profilename";
            ibisobj.populateComboBoxMenu(sql, this.cmbPermProfileSel, "ibis_perms_profilename", "ibis_perms_id");
            cmbPermProfileSel.SelectedValue = currval;
        }

        // this method updates all permissions extant in the permissions profile
        private void UpdatePermissionsTV(HoldenPermissionsProfile hpp)
        {
            // HERE WE NEED TO ITERATE OVER TREE VIEW AND JUST CHANGE
            // PERMISSIONS IN THE CONTEXT MENUS.
            foreach (TreeNode outernode in tvPermUpdForm.Nodes)
            {
                foreach (TreeNode tn in outernode.Nodes)
                {
                    string key = tn.Text;
                    if (outernode.Text.Equals("DATABASE FIELDS"))
                        key = "tbl_" + key;
                    else if (outernode.Text.Equals("FORM DEFINITIONS"))
                        key = key.Substring(0, key.Length - 4);
                    else if (outernode.Text.Equals("LIST DEFINITIONS"))
                        key = key.Substring(0, key.Length - 4);
                    else if (outernode.Text.Equals("PREFILTER DEFINITIONS"))
                        key = key.Substring(0, key.Length - 5);

                    ((IbisPermissionsContextMenuStrip)tn.ContextMenuStrip).setMenuState(Convert.ToInt32(hpp.Permissions[key]));
                    ((IbisPermissionsTag)tn.Tag).SetPermissions(Convert.ToInt32(hpp.Permissions[key]));

                    foreach (TreeNode tn2 in tn.Nodes)
                    {
                        int val;
                        if (hpp.Permissions[tn2.Text] is DBNull || !hpp.Permissions.ContainsKey(tn2.Text))
                            val = 0;
                        else
                            val = Convert.ToInt32(hpp.Permissions[tn2.Text]);

                        ((IbisPermissionsContextMenuStrip)tn2.ContextMenuStrip).setMenuState(val);
                        ((IbisPermissionsTag)tn2.Tag).SetPermissions(val);
                    }
                }
            }
        }

        private void cmdAddEditPermProfiles_Click(object sender, EventArgs e)
        {
            using (MySqlConnection dbh = new MySqlConnection(Resource1.DB_CONNSTR_HES))
            {
                dbh.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbh;

                Button btn = sender as Button;
                if (btn.Tag.Equals("update"))
                    cmd.CommandText = "UPDATE ibis_perms SET ";
                else
                    cmd.CommandText = "INSERT INTO ibis_perms ";

                // no need for a recursive traversal structure here as there being
                // three levels of the treeview is not going to ever change.
                List<string> flds = new List<string>();
                Dictionary<string, int> fldhash = new Dictionary<string, int>();
                foreach (TreeNode outernode in tvPermUpdForm.Nodes)
                {
                    foreach (TreeNode tn in outernode.Nodes)
                    {
                        IbisPermissionsTag ipt = tn.Tag as IbisPermissionsTag;
                        if (btn.Tag.Equals("update"))
                            flds.Add(ipt.db_colname + " = " + ipt.GetPermissionsAsInt());
                        else if (btn.Tag.Equals("addnew"))
                            fldhash.Add(ipt.db_colname, ipt.GetPermissionsAsInt());
                        //MessageBox.Show("permission for node: " + ipt.db_colname + " = " + ipt.GetPermissionsAsInt());

                        foreach (TreeNode tn2 in tn.Nodes)
                        {
                            IbisPermissionsTag ipt2 = tn2.Tag as IbisPermissionsTag;
                            if (btn.Tag.Equals("update"))
                                flds.Add(ipt2.db_colname + " = " + ipt2.GetPermissionsAsInt());
                            else if (btn.Tag.Equals("addnew"))
                                fldhash.Add(ipt2.db_colname, ipt2.GetPermissionsAsInt());
                            //MessageBox.Show("permission for node: " + ipt2.db_colname + " = " + ipt2.GetPermissionsAsInt());
                        }
                    }
                }

                if (btn.Tag.Equals("update"))
                {
                    cmd.CommandText += String.Join(", ", flds.ToArray<string>());
                    cmd.CommandText += " WHERE ibis_perms_id = " + cmbPermProfileSel.SelectedValue;
                }
                else if (btn.Tag.Equals("addnew"))
                {
                    List<string> k = new List<string>();
                    List<int> v = new List<int>();
                    foreach (string key in fldhash.Keys)
                    {
                        k.Add(key);
                        v.Add(fldhash[key]);
                    }

                    cmd.CommandText += "(ibis_perms_profilename, " + String.Join(", ", k) +
                        ") VALUES (@profname, " + String.Join(", ", v) + ")";
                    cmd.Parameters.AddWithValue("@profname", cmbPermProfileSel.Text);
                }

                //IbisMessageBox imb = new IbisMessageBox("stmt: " + cmd.CommandText);
                //imb.ShowDialog();

                try
                {
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException me)
                {
                    MessageBox.Show("mysql exception occurred: " + me.ToString());
                    return;
                }
                catch (Exception e1)
                {
                    MessageBox.Show("exception occurred: " + e1.ToString());
                    return;
                }

                MessageBox.Show("Permissions datatable successfully updated.");

                _populateProfilesCMB(cmbPermProfileSel.SelectedValue);

                dbh.Close();
            }
        }

        private void cmbPermProfileSel_TextChanged(object sender, EventArgs e)
        {
            if (cmbPermProfileSel.SelectedIndex >= 1 &&
                cmbPermProfileSel.AutoCompleteCustomSource.Contains(cmbPermProfileSel.Text) &&
                !cmbPermProfileSel.Text.Equals(cmbPermProfileSel.AutoCompleteCustomSource[0]))
            {
                HoldenPermissionsProfile hppTmp = new HoldenPermissionsProfile(Convert.ToInt32(cmbPermProfileSel.SelectedValue));
                UpdatePermissionsTV(hppTmp);
                cmdAddEditPermProfiles.Text = "Update " + hppTmp.Name + ": " + hppTmp.DBID;
                cmdAddEditPermProfiles.Tag = "update";
            }
            else
            {
                cmdAddEditPermProfiles.Text = "Add New Profile";
                cmdAddEditPermProfiles.Tag = "addnew";
            }
        }

        // this allows nodes to be selected by right-clicking as well as by left-clicking.
        private void tvPermUpdForm_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tvPermUpdForm.SelectedNode = e.Node;
            }
        }

        private void cmbPermProfileSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            // UPDATE PERMISSIONS IN CONTEXT MENUS.
            //
        }

        private void btnAddPermToDB_Click(object sender, EventArgs e)
        {
            using (MySqlConnection dbh = new MySqlConnection(Resource1.DB_CONNSTR_HES))
            {
                dbh.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbh;

                foreach (TreeNode tn in tvToAdd.Nodes)
                {
                    try
                    {
                        if (((Button)sender).Tag.Equals("a"))
                            cmd.CommandText = "ALTER TABLE ibis_perms ADD COLUMN " + tn.Text + " VARCHAR(2) DEFAULT 0";
                        else if (((Button)sender).Tag.Equals("r"))
                            cmd.CommandText = "ALTER TABLE ibis_perms DROP COLUMN " + tn.Text;
                        else // default to add mode.
                            cmd.CommandText = "ALTER TABLE ibis_perms ADD COLUMN " + tn.Text + " VARCHAR(2) DEFAULT 0";
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException mysqle)
                    {
                        MessageBox.Show("mysql ERROR: " + mysqle.ToString() + "\nSQL_STMT: " + cmd.CommandText);
                        return;
                    }
                    catch (Exception m1ex)
                    {
                        MessageBox.Show("M1_ERROR: " + m1ex.ToString());
                        return;
                    }
                }

                dbh.Close();
            }

            MessageBox.Show("Fields successfully added to the permissions table.");
            Application.Exit();
        }
    }
}
