using System;

namespace HoldenClasses
{
    [Serializable]
    public class HoldenUser
    {
        public HoldenPermissionsProfile hpp { get; set; }
        public string un { get; set; }
        public int empnum { get; set; }
        public string pw { get; set; }
        public bool isSU { get; set; }

        public HoldenUser()
        {
            // default constructor
        }

        public HoldenUser(string inUN, string inPW, int inEN, int inPID, bool inISSU)
        {
            un = inUN;
            //int tmpint;
            //int.TryParse(inEN, out tmpint);
            empnum = inEN;
            pw = inPW;
            hpp = new HoldenPermissionsProfile(inPID);
            isSU = inISSU;
        }
    }
}
