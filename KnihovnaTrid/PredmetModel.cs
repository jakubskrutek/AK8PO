using System;
using System.Collections.Generic;
using System.Text;

namespace KnihovnaTrid
{
    public class PredmetModel
    {
        public string Zkratka { get; set; }
        public string Nazev { get; set; }
        public int PocetKreditu { get; set; }
        public int PocetTydnu { get; set; }
        public int HodinyPrednasek { get; set; }
        public int HodinyCviceni { get; set; }
        public int HodinySeminaru { get; set; }
        public enum ZpusobZakonceni { Zkouska, Zapocet, ZkouskaIZapocet };
        public enum JazykVyuky { CZ, EN };
        public int VelikostTridy { get; set; }
        public ZamestnanecModel VyucujiciPredmetu { get; set; } = new ZamestnanecModel();
    }
}
