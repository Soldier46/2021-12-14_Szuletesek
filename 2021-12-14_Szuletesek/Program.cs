using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021_12_14_Szuletesek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Szemely> személyek = new List<Szemely>();
            foreach (var sor in File.ReadAllLines("vas.txt"))
            {
                személyek.Add(new Szemely(sor));
            }

            if (személyek[1].CdvEll)
            {
                Console.WriteLine("helyes: " + személyek[1].SzemélyiSzám);
            }
            Console.WriteLine($"4. feladat: Ellenőrzés");


            / Linq típusu programozás/
             személyek //lista
              .Where(x => !x.CdvEll).ToList() //HA HAMIS AKKOR BRUH 
               .ForEach(sz => Console.WriteLine($"\tHibás az {sz.SzemélyiSzám} személyi azonosító")); //az x elemeken menjen végig (előző paraméter) 
            int töröl = személyek.RemoveAll(x => !x.CdvEll);
            Console.WriteLine(személyek.Count);
            / hagyományos típusu programozás/
             /*
            foreach (var sz in személyek)
            {
                if (!sz.CdvEll) //hamis
                {
                    Console.WriteLine($"\tHibás az {sz.SzemélyiSzám} személyi azonosító");
                }
            }
            */
             //hagyományos típusu programozás FOR - al /
              /*
              for (int i = 0; i < személyek.Count; i++)
              {
                  if (!személyek[i].CdvEll)
                  {
                      Console.WriteLine($"\tHibás az {személyek[i].SzemélyiSzám} személyi azonosító");
                      személyek.Remove(személyek[i]);
              }
              }
              */
              //5.
              Console.WriteLine($"Szóra sem érdemes 5. feladat: Vas megyében a vizsgált évek {személyek.Count} csecsemő született");

            //6.
            int fiúk = személyek //a fiúkba tároljuk az adatot amit a Count() számol meg
            .Where(x => x.SzemélyiSzám.First() == '1' || x.SzemélyiSzám.First() == '3').ToList()  //fiú = 1/3 számmal kezdődik ,a változó neve mind1, A ToList() MINDIG KELL!!!
            .Count();
            Console.WriteLine($"6. feladat: Fiúk száma: {fiúk}");

            //7.
            int minÉv = 5000;
            int maxÉv = 0;
            foreach (var sz in személyek)
            {
                int akt = int.Parse(sz.SzemélyiSzám.Substring(2, 2));
                if (akt >= 1997 && akt <= 1999) akt += 1900;
                else akt += 2000;
                if (akt < minÉv) minÉv = akt;
                if (akt > maxÉv) maxÉv = akt;
            }
            Console.WriteLine(minÉv);
            Console.ReadKey();
        }
    }
}
