using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel
{
    class Dij
    {
        

        public int ev { get; set; }
        public string nev { get; set; }
        public string szulhal { get; set; }
        public (int Szuletes,int? Halal) SzH { get; set; }
        public string orszkod { get; set; }



        public Dij(string sor)
        {
            var r = sor.Split(';');
            this.ev =int.Parse(r[0]);
            this.nev = r[1];
            this.szulhal = r[2];
            var szh = r[2].Split("-");
            int? H = szh[1].Length == 0 ? null : int.Parse(szh[1]);
            SzH = (int.Parse(szh[0]), H);
            this.orszkod = r[3];
        }

    }
}
