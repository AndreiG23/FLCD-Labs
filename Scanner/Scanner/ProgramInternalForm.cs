using System;
using System.Collections.Generic;
using System.Text;

namespace Scanner
{
    public class ProgramInternalForm
    {
        private Dictionary<int, Pair> pif = new Dictionary<int, Pair>();

        public ProgramInternalForm() { }

        public void add(int code,Pair pos)
        {
            pif.Add(code, pos);
        }

        public Dictionary<int,Pair> getPIF()
        {
            return this.pif;
        }
    }
}
