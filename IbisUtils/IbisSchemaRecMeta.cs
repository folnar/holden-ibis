namespace IbisUtils
{
    public class IbisSchemaRecMeta
    {
        public string tblnm { get; set; }
        public string fldnm { get; set; }
        public string fldtyp { get; set; }

        public void Add(string t, string fn, string ft)
        {
            this.tblnm = t;
            this.fldnm = fn;
            this.fldtyp = ft;
        }

        public IbisSchemaRecMeta()
        {
            // default constructor
        }

        public IbisSchemaRecMeta(string t, string fn, string ft)
        {
            this.tblnm = t;
            this.fldnm = fn;
            this.fldtyp = ft;
        }
    }
}
