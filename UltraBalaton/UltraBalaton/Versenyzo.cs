using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraBalaton
{
    class Versenyzo
    {
        public string Nev { get; set; }
        public int VersenySzam { get; set; }
        public bool Kategoria { get; set; }
        public TimeSpan IdoPontszamok { get; set; }
        public int TeljesTav { get; set; }

        public Versenyzo(string beolvasottSor)
        {
            string[] adat = beolvasottSor.Split(';');
            this.Nev = adat[0];
            this.VersenySzam = int.Parse(adat[1]);
            this.Kategoria = adat[2] == "Ferfi";
            var ido = adat[3].Split(";");
            IdoPontszamok = new TimeSpan(
               hours: int.Parse(ido[0]),
               minutes: int.Parse(ido[1]),
               seconds: int.Parse(ido[2]));
            this.TeljesTav = int.Parse(adat[4]);
        }
    }
}
