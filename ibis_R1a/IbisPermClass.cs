namespace ibis_R1a
{
    public class IbisPermClass
    {
        public static int NoAccess = 0;
        public static int View = 1;
        public static int Edit = 2;
        public static int AddNew = 4;
        public static int Delete = 8;

        private IbisPermClass()
        {
            throw new System.Exception();
        }
    }
}
