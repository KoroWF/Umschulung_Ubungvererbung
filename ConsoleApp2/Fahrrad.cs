using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Fahrrad
    {
        private int zoll;

        public int Zoll { get { return zoll; }}

        public Fahrrad(int _zoll)
        {

            this.zoll = _zoll;
        }

        public virtual string Fahren()
        {
            return "Fahrrad fährt mit Muskelkraft - Zoll: " + Zoll;
        }
    }
}
