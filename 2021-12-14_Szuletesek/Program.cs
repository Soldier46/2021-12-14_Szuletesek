using System;
using System.Collections.Generic;
using System.IO;

namespace _2021_12_14_Szuletesek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Személy> személyek = new List<Személy>();
            foreach (var sor in File.ReadAllLines("vas.txt"))
            {
                személyek.Add(new Személy(sor));
            }
            személyek[0].CdEll()
            Console.WriteLine();
        }
    }
}
