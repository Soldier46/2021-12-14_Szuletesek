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

        public bool CdvEll
        {
            get
            {
               string sz = SzemélyiSzám.Replace("-", "");
                int checkSum = sz[sz.Length];
                int szum = 0;

                for (int i = 0; i < SzemélyiSzám.Length; i++)
                {
                    checkSum += i * sz[i]; 
                }
                return false;
            }
        }
        public Személy(string sor)
        {
            SzemélyiSzám = sor;
        }
    }
}
