using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace HoldenClasses
{
    public abstract class HoldenObjectClass : IHoldenObject
    {
        public int? DBID { get; set; }
        public DataTable dt { get; set; }

        private MySqlConnection dbh { get; set; }
        private MySqlDataAdapter da { get; set; }
        private MySqlCommandBuilder cb { get; set; }

        public Dictionary<string, HoldenObjectFld> props { get; set; }

        public string tblnm { get; set; }
        public string tblnm_pk { get; set; }

        public string[] dbnames;
        public string[] dbtypes;

        protected HoldenObjectClass(string intblnm, string inpk, string[] indbnames, string[] indbtypes)
        {
            tblnm = intblnm;
            tblnm_pk = inpk;
            dbnames = indbnames;
            dbtypes = indbtypes;

            props = new Dictionary<string, HoldenObjectFld>();
            PopFlds();

            DBID = null;
            _init();
        }

        protected HoldenObjectClass(int id, string intblnm, string inpk, string[] indbnames, string[] indbtypes)
        {
            tblnm = intblnm;
            tblnm_pk = inpk;
            dbnames = indbnames;
            dbtypes = indbtypes;

            props = new Dictionary<string, HoldenObjectFld>();
            PopFlds();

            _init();
            PopulateFromDB(id);
        }

        private void PopFlds()
        {
            for (int idx = 0; idx < dbnames.Length; idx++)
            {
                this.props.Add(dbnames[idx], new HoldenObjectFld(dbtypes[idx], dbnames[idx]));
            }
        }

        public void PopulateFromDB(int id)
        {
            dbh.Open();

            DBID = id;
            DataRow row = dt.Rows.Find(DBID);
            foreach (HoldenObjectFld hof in props.Values)
            {
                switch (hof.DBType)
                {
                    case "int":
                        if (Convert.IsDBNull(row[hof.DBName]))
                            row[hof.DBName] = 0;
                        hof.Value = Convert.ToInt32(row[hof.DBName]);
                        break;
                    case "string":
                        hof.Value = row[hof.DBName].ToString();
                        break;
                }
            }

            dbh.Close();
        }

        protected void _init()
        {
            dbh = new MySqlConnection(Properties.Resources.DB_CONNSTR_HES);
            da = new MySqlDataAdapter("SELECT * FROM " + tblnm, dbh);
            cb = new MySqlCommandBuilder(da);
            cb.ConflictOption = ConflictOption.OverwriteChanges;
            dt = new DataTable();
            da.Fill(dt);
            DataColumn[] pk = new DataColumn[] { dt.Columns[tblnm_pk] };
            dt.PrimaryKey = pk;
            dt.Columns[tblnm_pk].AutoIncrement = true;
            dt.Columns[tblnm_pk].AllowDBNull = true;
            dt.Columns[tblnm_pk].AutoIncrementSeed = 0;
            dt.Columns[tblnm_pk].AutoIncrementStep = -1;
        }

        // THIS METHOD PERFORMS A DB INSERT OR UPDATE DEPENDING ON WHETHER DT IS NULL OR NOT.
        public void CommitToDB()
        {
            dbh.Open();

            DataRow row = null;
            if (DBID == null) // dealing with an DB INSERT
                row = dt.NewRow();
            else // dealing with a DB UPDATE
                row = dt.Rows.Find(DBID);

            foreach (HoldenObjectFld hof in props.Values)
            {
                if (hof.Value == null)
                    hof.Value = DBNull.Value;
                row[hof.DBName] = hof.Value;
            }
            if (DBID == null) // dealing with an DB INSERT
                dt.Rows.Add(row);

            MySqlCommand lk_cmd = new MySqlCommand("LOCK TABLES " + tblnm + " WRITE", dbh);
            lk_cmd.ExecuteNonQuery();

            DataTable changes = dt.GetChanges();
            if (changes != null)
            {
                try
                {
                    da.Update(changes);
                    if (da.InsertCommand != null)
                        da.InsertCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord;
                    if (da.UpdateCommand != null)
                        da.UpdateCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord;
                    dt.AcceptChanges();
                    da.Fill(dt);
                }
                catch (DBConcurrencyException dbccex)
                {
                    Console.WriteLine(dbccex.ToString());
                }
            }

            // if in INSERT mode
            if (DBID == null || DBID == 0)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT last_insert_id()", dbh);
                DBID = Convert.ToInt32(cmd.ExecuteScalar());
            }

            MySqlCommand unlk_cmd = new MySqlCommand("UNLOCK TABLES", dbh);
            unlk_cmd.ExecuteNonQuery();

            dbh.Close();
        }
    }
}
