using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK8PO
{
    public class Rozpis
    {
        public string Muzstvo { get; set; }
        public string[,] RozpisText { get; set; }

        public Rozpis(string muzstvo, string[,] rozpisText)
        {
            Muzstvo = muzstvo;
            RozpisText = rozpisText;
        }

        public override string ToString()
        {
            return Muzstvo;
        }
    }
}
