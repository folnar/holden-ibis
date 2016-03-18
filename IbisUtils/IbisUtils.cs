using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IbisUtils
{
    public class IbisUtilsMgr
    {
        public static string staticConnID
        {
            get
            {
                return Resource1.DB_CONNSTR_HES;
            }
        }

        public string ConnID
        {
            get
            {
                return Resource1.DB_CONNSTR_HES;
            }
        }

        public string genLoginSQL (string un, string pw)
        {
            return "SELECT ibis_perms.ibis_perms_profilename, ibis_perms.ibis_perms_id, " +
                   "hesemployee_username, hesemployee_hesnumber FROM hesemployee, ibis_perms WHERE hesemployee_username='" + un +
                   "' AND hesemployee_password='" + pw + "' AND ibis_perms.ibis_perms_id = hesemployee_permprofile";
        }

        public List<IbisSchemaTable> loadDBSchema(MySqlConnection dbh)
        {
            string sql = "SELECT t.table_schema AS 'Database', t.table_name AS 'Table', t.table_type AS 'Table Type', " +
                         "c.column_name AS 'Column', c.data_type AS 'Data Type' FROM information_schema.tables t " +
                         "JOIN information_schema.columns c ON t.table_schema = c.table_schema AND t.table_name = c.table_name " +
                         "WHERE t.table_schema = '" + Resource1.DB_HES_DBNAME + "' " +
                         "ORDER BY t.table_type, t.table_name, c.ordinal_position";

            MySqlCommand command = dbh.CreateCommand();
            command.CommandText = sql;

            List<IbisSchemaTable> retval = new List<IbisSchemaTable>();
            using (MySqlDataReader mysqlrdr = command.ExecuteReader())
            {
                // add the first record.
                mysqlrdr.Read();
                string current_table = mysqlrdr.GetValue(1).ToString();
                List<IbisSchemaRecMeta> schrecs = new List<IbisSchemaRecMeta>();
                schrecs.Add(new IbisSchemaRecMeta(mysqlrdr.GetValue(1).ToString(),
                                                  mysqlrdr.GetValue(3).ToString(),
                                                  mysqlrdr.GetValue(4).ToString()));

                // add all of the remaining records, checking to see if the table has changed.
                while (mysqlrdr.Read())
                {
                    if (!mysqlrdr.GetValue(1).Equals(current_table))
                    {
                        retval.Add(new IbisSchemaTable(current_table, schrecs));
                        schrecs = new List<IbisSchemaRecMeta>();
                        current_table = mysqlrdr.GetValue(1).ToString();
                    }

                    schrecs.Add(new IbisSchemaRecMeta(mysqlrdr.GetValue(1).ToString(),
                                                      mysqlrdr.GetValue(3).ToString(),
                                                      mysqlrdr.GetValue(4).ToString()));
                }

                // add the last table.
                retval.Add(new IbisSchemaTable(current_table, schrecs));
            }

            return retval;
        }

        public List<string> getTableNames (MySqlConnection dbh)
        {
            MySqlCommand command = dbh.CreateCommand();
            command.CommandText = "SHOW TABLES;";

            List<string> retvals = new List<string>();
            using (MySqlDataReader mysqlrdr = command.ExecuteReader())
            {
                while (mysqlrdr.Read())
                {
                    retvals.Add(mysqlrdr.GetValue(0).ToString());
                }
            }

            return retvals;
        }

        public List<IbisSchemaRecMeta> getFldNames(string tbl, MySqlConnection dbh)
        {
            MySqlCommand command = dbh.CreateCommand();
            command.CommandText = "SELECT * FROM " + tbl + ";";

            List<IbisSchemaRecMeta> retlist = new List<IbisSchemaRecMeta>();
            using (MySqlDataReader mysqlrdr = command.ExecuteReader(CommandBehavior.KeyInfo))
            {
                DataTable dtSchema = mysqlrdr.GetSchemaTable();

                foreach (DataRow row in dtSchema.Rows)
                {
                    IbisSchemaRecMeta retrec = new IbisSchemaRecMeta();

                    if (row["IsKey"].ToString().Equals("True", StringComparison.Ordinal))
                    {
                        retrec.Add(tbl, row["ColumnName"].ToString(), "INT NOT NULL PRIMARY KEY");
                    }
                    else if (((MySqlDbType)row["ProviderType"]).ToString().Contains("Int"))
                    {
                        retrec.Add(tbl, row["ColumnName"].ToString(), "INT (" + row["ColumnSize"].ToString() + ")");
                    }
                    else
                    {
                        retrec.Add(tbl, row["ColumnName"].ToString(), (MySqlDbType)row["ProviderType"] + "(" + row["ColumnSize"].ToString() + ")");
                    }

                    retlist.Add(retrec);
                }
            }

            return retlist;
        }

        public List<string> getActiveDefNames(MySqlConnection dbh)
        {
            MySqlCommand command = dbh.CreateCommand();
            command.CommandText = "SELECT ibis_siteobjs_fn, ibis_siteobjs_type FROM ibis_siteobjs WHERE ibis_siteobjs_active = 1;";

            List<string> retlist = new List<string>();
            using (MySqlDataReader mysqlrdr = command.ExecuteReader(CommandBehavior.KeyInfo))
            {
                while (mysqlrdr.Read())
                {
                    retlist.Add(mysqlrdr["ibis_siteobjs_type"].ToString() + "def_" + mysqlrdr["ibis_siteobjs_fn"].ToString());
                }
            }

            return retlist;
        }


        public List<string> getActiveDefNames(MySqlConnection dbh, string deftyp)
        {
            MySqlCommand command = dbh.CreateCommand();
            command.CommandText = "SELECT ibis_siteobjs_fn, ibis_siteobjs_type FROM ibis_siteobjs WHERE ibis_siteobjs_active = 1 AND ibis_siteobjs_type = '" + deftyp + "';";

            List<string> retlist = new List<string>();
            using (MySqlDataReader mysqlrdr = command.ExecuteReader(CommandBehavior.KeyInfo))
            {
                while (mysqlrdr.Read())
                {
                    retlist.Add(mysqlrdr["ibis_siteobjs_type"].ToString() + "def_" + mysqlrdr["ibis_siteobjs_fn"].ToString());
                }
            }

            return retlist;
        }

        public List<string> getPermProfileNames(MySqlConnection dbh)
        {
            MySqlCommand command = dbh.CreateCommand();
            command.CommandText = "SELECT ibis_perms_id, ibis_perms_profilename;";

            List<string> retlist = new List<string>();
            using (MySqlDataReader mysqlrdr = command.ExecuteReader(CommandBehavior.KeyInfo))
            {
                while (mysqlrdr.Read())
                {
                    retlist.Add(mysqlrdr["ibis_siteobjs_type"].ToString() + "def_" + mysqlrdr["ibis_siteobjs_fn"].ToString());
                }
            }

            return retlist;
        }

        public DataTable getDataTable(string qry, MySqlConnection dbh)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(qry, dbh);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // a static version without pre-existing data connection
        public static DataTable getDataTable(string qry)
        {
            MySqlConnection dbh = new MySqlConnection(staticConnID);
            MySqlDataAdapter da = new MySqlDataAdapter(qry, dbh);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // because of tightly-cast datatypes in datarow.field<>, parameter p1 must be the
        // column name of a mysql type which returns a string in the datarow, e.g. varchar.
        public void populateComboBoxMenu(DataTable dtPerms, ComboBox comboBox, MySqlConnection dbh, string p1, string p2)
        {
            DataRow blankrow = dtPerms.NewRow();
            blankrow[p1] = " - ";
            blankrow[p2] = 0;
            dtPerms.Rows.InsertAt(blankrow, 0);

            comboBox.DataSource = dtPerms.DefaultView;
            comboBox.DisplayMember = p1;
            comboBox.ValueMember = p2;

            // use this bit to add autocomplete functionality to combobox.
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection autocompstrs = new AutoCompleteStringCollection();
            foreach (DataRow row in dtPerms.Rows)
            {
                autocompstrs.Add(row.Field<string>(p1));
            }
            comboBox.AutoCompleteCustomSource = autocompstrs;
        }
    }
}
