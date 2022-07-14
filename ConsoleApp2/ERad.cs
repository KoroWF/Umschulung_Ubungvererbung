using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ERad:Fahrrad
    {
        private double Akku;

        public ERad(int _zoll, double _akku):base (_zoll)
        {
            Akku = _akku;
        }

        public override string Fahren()
        {
            if (Akku > 0)
            {
                return "ERad fährt mit Motor - Akku: " + Akku + "% | Zoll: " + Zoll;
            }

            return "ERad fährt sich sehr schwer mit Muskelkraft - Akku: " + Akku + "% | Zoll: " + Zoll;
        }

    }
    }
