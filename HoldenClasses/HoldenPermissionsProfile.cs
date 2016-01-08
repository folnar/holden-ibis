using System;
using System.Collections.Generic;
using System.Data;
using IbisUtils;

namespace HoldenClasses
{
    [Serializable]
    public class HoldenPermissionsProfile
    {
        public int DBID { get; set; }
        public string Name { get; set; }
        public Dictionary<string, object> Permissions { get; set; }

        public HoldenPermissionsProfile()
        {
            // default constructor
        }

        public HoldenPermissionsProfile(int id)
        {
            PopulateFromDB(id);
        }

        public void PopulateFromDB(int id)
        {
            if (id < 1) return;

            DBID = id;
            DataTable dt = IbisUtilsMgr.getDataTable("SELECT * FROM ibis_perms WHERE ibis_perms_id = " + id);
            Permissions = new Dictionary<string, object>();
            Name = dt.Rows[0]["ibis_perms_profilename"].ToString();
            foreach (DataColumn col in dt.Columns)
            {
                // this 'if' is necessary since ibis_perms itself does not have a permissions set as it can only be edited by the update tool.
                if (col.ColumnName.Equals("ibis_perms_id") ||
                    col.ColumnName.Equals("ibis_perms_profilename"))
                    continue;

                Permissions.Add(col.ColumnName, dt.Rows[0][col.ColumnName]);
            }
        }
    }
}
