using System;

namespace HoldenClasses
{
    public class HoldenClient : HoldenObjectClass
    {
        readonly new static string[] dbtypes = { "int", "string", "string", "string" };
        readonly new static string[] dbnames = { "client_address",
                                                 "client_name",
                                                 "client_code",
                                                 "client_contact" };

        public HoldenAddress ha;

        readonly static string _TBLNM = "client";
        readonly static string _TBLNM_PK = "client_id";

        public HoldenClient()
            : base(_TBLNM, _TBLNM_PK, dbnames, dbtypes) { }

        public HoldenClient(int id)
            : base(id, _TBLNM, _TBLNM_PK, dbnames, dbtypes)
        {
            ha = new HoldenAddress(Convert.ToInt32(props["client_address"].Value));
        }
    }
}
