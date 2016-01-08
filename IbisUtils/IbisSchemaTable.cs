using System.Collections.Generic;

namespace IbisUtils
{
    public class IbisSchemaTable
    {
        private string _tablename;
        private List<IbisSchemaRecMeta> _intschema;

        public IbisSchemaTable(string tbl, List<IbisSchemaRecMeta> list)
        {
            this._tablename = tbl;
            this._intschema = list;
        }

        public IbisSchemaTable()
        {
            // default constructor
        }

        public string tablename
        {
            get { return _tablename; }
            set { _tablename = value; }
        }

        public List<IbisSchemaRecMeta> schematbl
        {
            get { return _intschema; }
            set { _intschema = value; }
        }
    }
}
