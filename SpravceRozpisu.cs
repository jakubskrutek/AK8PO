using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK8PO
{
    public class SpravceRozpisu
    {
        public List<Rozpis> Rozpisy { get; set; }

        public SpravceRozpisu()
        {
            Rozpisy = new List<Rozpis>();
        }

        public void Nahraj(string muzstvo, string rozpisText)
        {
            if (rozpisText == "...")        // podmínka pro výjimku, doplň později0
                throw new ArgumentException("Zvolen nesprávný .txt soubor s daty.");
            Rozpis rozpis = new Rozpis(muzstvo, rozpisText);        // tady přijde už upravený string (metoda v metodě asi)
            Rozpisy.Add(rozpis);
        }
    }
}
