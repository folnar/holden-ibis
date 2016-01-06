using System;
using System.Data;

namespace HoldenClasses
{
    interface IHoldenObject
    {
        int? DBID { get; set; }
        DataTable dt { get; set; }

        void CommitToDB();
    }
}
