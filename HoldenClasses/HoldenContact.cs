using System;

namespace HoldenClasses
{
    public class HoldenContact : HoldenObjectClass
    {
        readonly new static string[] dbtypes = { "string", "int", "string", "string",
                                                 "string", "string", "string", "string",
                                                 "int", "int", "string" };
        readonly new static string[] dbnames = { "contact_label",
                                                 "contact_accountid",
                                                 "contact_lastname",
                                                 "contact_middlename",
                                                 "contact_firstname",
                                                 "contact_department",
                                                 "contact_email",
                                                 "contact_phone",
                                                 "contact_mailingaddr",
                                                 "contact_streetaddr",
                                                 "contact_mphone" };

        public HoldenClient account;
        public HoldenAddress mailingaddr;
        public HoldenAddress streetaddr;

        readonly static string _TBLNM = "contact";
        readonly static string _TBLNM_PK = "contact_id";

        public HoldenContact()
            : base(_TBLNM, _TBLNM_PK, dbnames, dbtypes) { }

        public HoldenContact(int id)
            : base(id, _TBLNM, _TBLNM_PK, dbnames, dbtypes)
        {
            account = new HoldenClient(Convert.ToInt32(props["contact_accountid"].Value));
            mailingaddr = new HoldenAddress(Convert.ToInt32(props["contact_mailingaddr"].Value));
            streetaddr = new HoldenAddress(Convert.ToInt32(props["contact_streetaddr"].Value));
        }
    }
}