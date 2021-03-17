using System;
using System.Collections.Generic;
using System.Text;

namespace KnihovnaTrid
{
    public class SkupinaModel
    {
        public string Zkratka { get; set; }
        public string Nazev { get; set; }
        public int Rocnik { get; set; }
        public enum Semestr { LS, ZS };
        public int PocetStudentu { get; set; }
        public enum FormaStudia { P, K };
        public enum TypStudia { Bc, Mgr };
        public enum Jazyk { CZ, EN };
        public List<PredmetModel> PeredmetySkupiny { get; set; } = new List<PredmetModel>();
    }
}
