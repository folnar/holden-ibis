using System;

namespace IbisUtils
{
    public class IbisPermissionsTag
    {
        public bool canRead { get; set; }
        public bool canEdit { get; set; }
        public bool canAddNew { get; set; }
        public bool canDelete { get; set; }
        public string db_colname { get; set; }

        public IbisPermissionsTag()
        {
            // default constructor
            this.canAddNew = false;
            this.canDelete = false;
            this.canEdit = false;
            this.canRead = false;
            this.db_colname = "";
        }

        public IbisPermissionsTag(string colnm, string strPerms)
        {
            // permissions are, from MSB to LSB as follows: canDelete, canAddNew, canEdit, and canRead.
            int intPerms = Convert.ToUInt16(strPerms);
            this.canDelete = Convert.ToBoolean((intPerms & 0x8) >> 3);
            this.canAddNew = Convert.ToBoolean((intPerms & 0x4) >> 2);
            this.canEdit = Convert.ToBoolean((intPerms & 0x2) >> 1);
            this.canRead = Convert.ToBoolean((intPerms & 0x1));
            this.db_colname = colnm;
        }

        public IbisPermissionsTag(string colnm, int intPerms)
        {
            // permissions are, from MSB to LSB as follows: canDelete, canAddNew, canEdit, and canRead.
            this.canDelete = Convert.ToBoolean((intPerms & 0x8) >> 3);
            this.canAddNew = Convert.ToBoolean((intPerms & 0x4) >> 2);
            this.canEdit = Convert.ToBoolean((intPerms & 0x2) >> 1);
            this.canRead = Convert.ToBoolean((intPerms & 0x1));
            this.db_colname = colnm;
        }

        public IbisPermissionsTag(string colnm)
        {
            // TODO: Complete member initialization
            this.canAddNew = false;
            this.canDelete = false;
            this.canEdit = false;
            this.canRead = false;
            this.db_colname = colnm;
        }

        public int GetPermissionsAsInt()
        {
            if (this.canDelete)
                return 8;
            else if (this.canAddNew)
                return 4;
            else if (this.canEdit)
                return 2;
            else if (this.canRead)
                return 1;
            else
                return 0;
        }

        public void SetPermissions(int intPerms)
        {
            this.canDelete = Convert.ToBoolean((intPerms & 0x8) >> 3);
            this.canAddNew = Convert.ToBoolean((intPerms & 0x4) >> 2);
            this.canEdit = Convert.ToBoolean((intPerms & 0x2) >> 1);
            this.canRead = Convert.ToBoolean((intPerms & 0x1));
        }
    }
}
