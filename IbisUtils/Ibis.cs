using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IbisUtils
{
    public class Ibis
    {
        private static MySqlConnection _dbh;
        private static bool _isSU;
        private static int _profileID;
        private static IbisUtilsMgr _iu;
        private static string _strCurrtbl;
        private static List<IbisSchemaTable> _dbschema;

        public string empun { get; set; }
        public string empnum { get; set; }

        public List<string> tblnms { get; set; }

        public Dictionary<string, object> sessperms { get; set; }

        public List<IbisSchemaTable> DBSchema
        {
            get { return _dbschema; }
            set { _dbschema = value; }
        }

        public string strCurrtbl
        {
            get { return _strCurrtbl; }
            set { _strCurrtbl = value; }
        }

        public MySqlConnection dbh
        {
            get { return _dbh; }
            set { _dbh = value; }
        }

        public int profileID
        {
            get { return _profileID; }
            set { _profileID = value; }
        }

        public bool isSU
        {
            get { return _isSU; }
            set { _isSU = value; }
        }

        public Ibis()
        {
            _iu = new IbisUtilsMgr();
            
            _dbh = new MySqlConnection(_iu.ConnID);
            _dbh.Open();
            
            this.isSU = false;
            
            this.tblnms = new List<string>();
            this.loadTableNames();
            
            _dbschema = new List<IbisSchemaTable>();

            this.sessperms = new Dictionary<string,object>();
        }

        public void loadPermissions()
        {
            MySqlCommand stmt = new MySqlCommand("SELECT * FROM ibis_perms", dbh);

            using (MySqlDataReader mysqlrdr = stmt.ExecuteReader())
            {
                try
                {
                    mysqlrdr.Read();
                }
                catch (Exception e)
                {
                    MessageBox.Show("mysql read error: " + e.Message);
                }
            }

            return;
        }

        public bool validateLogin (string un, string pw)
        {
            MySqlDataAdapter sth = new MySqlDataAdapter(_iu.genLoginSQL(un, pw), dbh);
            DataTable dt = new DataTable();
            sth.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.profileID = dt.Rows[0].Field<int>(1);
                this.empun = dt.Rows[0].Field<string>(2);
                this.empnum = dt.Rows[0].Field<string>(3);
                
                if (dt.Rows[0].Field<String>(0).Equals("superuser"))
                {
                    this.isSU = true;
                }
                    
                return true;
            }
            else { return false; }
        }

        public void loadDBSchema()
        {
            this.DBSchema = _iu.loadDBSchema(dbh);
        }

        private void loadTableNames()
        {
            this.tblnms = _iu.getTableNames(dbh);
        }

        // this is a wrapper for the ibisutils method.
        public IbisSchemaTable getFldNames(string tbl)
        {
            IbisSchemaTable rettbl = new IbisSchemaTable();
            rettbl.tablename = tbl;
            rettbl.schematbl = _iu.getFldNames (tbl, dbh);
            return rettbl;
        }

        public void loadFldNames(string tbl)
        {
            _dbschema.Add(new IbisSchemaTable(tbl, _iu.getFldNames(tbl, dbh)));
        }

        public void ExecQry (string stmt)
        {
            MySqlCommand cmd = new MySqlCommand(stmt, dbh);
            cmd.ExecuteNonQuery(); 
        }

        public List<string> getActiveDefNames()
        {
            return _iu.getActiveDefNames(dbh);
        }

        public List<string> getActiveDefNames(string deftype)
        {
            if (deftype.Equals("all", StringComparison.Ordinal)) return _iu.getActiveDefNames(dbh);
            return _iu.getActiveDefNames(dbh, deftype);
        }

        public DataTable getDataTable(string qry)
        {
            return _iu.getDataTable(qry, dbh);
        }

        public void populateComboBoxMenu(string sql, System.Windows.Forms.ComboBox comboBox, string p1, string p2)
        {
            DataTable dtPerms = getDataTable(sql);
            _iu.populateComboBoxMenu(dtPerms, comboBox, dbh, p1, p2);
        }

    }
}
