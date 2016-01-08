namespace HoldenClasses
{
    public class HoldenAddress : HoldenObjectClass
    {
        readonly new static string[] dbtypes = { "int", "string", "string", "string",
                                                 "string", "int", "int", "string", "string" };
        readonly new static string[] dbnames = { "address_parent",
                                                 "address_street1",
                                                 "address_street2",
                                                 "address_street3",
                                                 "address_city",
                                                 "address_state",
                                                 "address_country",
                                                 "address_zip", 
                                                 "address_label" };

        readonly static string _TBLNM = "address";
        readonly static string _TBLNM_PK = "address_id";

        public HoldenAddress()
            : base(_TBLNM, _TBLNM_PK, dbnames, dbtypes) { }

        public HoldenAddress(int id)
            : base(id, _TBLNM, _TBLNM_PK, dbnames, dbtypes) { }
    }
}
