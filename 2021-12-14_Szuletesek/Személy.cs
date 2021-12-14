using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_12_14_Szuletesek
{
    class Személy
    {
        public string SzemélyiSzám { get; set; }
        public Személy(string sor)
        {
            SzemélyiSzám = sor;
        }
    }
}
