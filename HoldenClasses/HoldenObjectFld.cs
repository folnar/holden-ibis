using System;

namespace HoldenClasses
{
    public class HoldenObjectFld
    {
        public object Value { get; set; }
        public string DBType { get; set; }
        public string DBName { get; set; }

        public HoldenObjectFld()
        {
            // default constructor
        }

        public HoldenObjectFld(string indbt, string indbn)
        {
            DBType = indbt;
            DBName = indbn;
        }
    }
}
