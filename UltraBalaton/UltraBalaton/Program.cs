using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace UltraBalaton
{
    class Program
    {
        static void Main(string[] args)
        {
            var versenyzok = new List<Versenyzo>();
            using var sr = new StreamReader(
                path: "../../../src/ub2017egyeni.txt",
                encoding: Encoding.UTF8);
            _ = sr.ReadLine();

            while (!sr.EndOfStream) versenyzok.Add(new Versenyzo(sr.ReadLine()));

            Console.WriteLine($"3.Feladat: Egyéni indulók: {versenyzok.Count} fő");
            var f4 = versenyzok.Count(v => !v.Kategoria && v.TeljesTav == 100);
            Console.WriteLine($"4. feladat: teljes tavot teljesito nok {f4} fo");

        }   
    }
}
