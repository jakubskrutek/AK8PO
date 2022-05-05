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
            if (rozpisText.Contains("Český stolní tenis") == false)        // podmínka pro výjimku, doplň později
                throw new ArgumentException("Zvolen nesprávný .txt soubor s daty.");
            string[,] zpracovanyRozpis = ZpracujRozpis(rozpisText);
            Rozpis rozpis = new Rozpis(muzstvo, zpracovanyRozpis);        // tady přijde už upravený string (metoda v metodě asi)
            Rozpisy.Add(rozpis);
        }

        private string[,] ZpracujRozpis(string rozpisText)
        {
            /* POLE ÚDAJE OBSAHUJE TYTO HODNOTY NA DANÝCH INDEXECH:
             *  0 - kolo
             *  1 - datum a čas               
             *  2 - domácí
             *  3 - hosté
             *  4 - výsledek
             *  5 - poznámka
             */

            byte faze = 0;
            byte udaj = 1;
            int prubeh = 0;
            string zasobnik = "";
            string vysledek = "";
            string[,] udaje = new string[1000, 6];

            foreach (char znak in rozpisText) {
                if (faze == 0) {
                    zasobnik += znak;
                    if (zasobnik.Contains("\tHosté"))
                        faze = 1;
                }
                if (faze == 1) {
                    if (znak == '1') {
                        faze = 2;
                        zasobnik = "";
                    }
                }
                if (faze == 2) {
                    zasobnik += znak;
                    if (zasobnik.Contains("\t\t\r\n")) {
                        foreach (char ch in zasobnik) {
                            vysledek += ch;
                            switch (udaj) {
                                case 1:
                                    if (vysledek.Contains("\t")) {
                                        udaje[prubeh, 0] = vysledek.Trim();
                                        vysledek = "";
                                        udaj = 2;
                                    }
                                    break;
                                case 2:
                                    if (vysledek.Contains("\r\n")) {
                                        vysledek = vysledek.Remove(0, 2).Trim();
                                        udaje[prubeh, 1] = vysledek;
                                        vysledek = "";
                                        udaj = 6;
                                    }
                                    else if (vysledek.Contains("\t")) {
                                        vysledek = vysledek.Remove(0, 2).Trim();
                                        udaje[prubeh, 1] = vysledek;
                                        udaje[prubeh, 5] = "nic";
                                        vysledek = "";
                                        udaj = 3;
                                    }
                                    break;
                                case 3:
                                    if (vysledek.Contains("\r\n")) {
                                        vysledek = vysledek.Trim();
                                        string opraveny = "";
                                        foreach (char x in vysledek) {
                                            if (x != '"')
                                                opraveny += x;
                                        }
                                        udaje[prubeh, 2] = opraveny;
                                        vysledek = "";
                                        udaj = 4;
                                    }
                                    break;
                                case 4:
                                    if (vysledek.Contains('<') && vysledek.Contains('>'))
                                        vysledek = "";
                                    else if (vysledek.Contains('<') && vysledek.Contains("\t")) {
                                        vysledek = vysledek.Trim();
                                        string opraveny = "";
                                        foreach (char x in vysledek) {
                                            if ((x != '"') && (x != '<'))
                                                opraveny += x;
                                        }
                                        udaje[prubeh, 3] = opraveny.Trim();
                                        vysledek = "<";
                                        udaj = 5;
                                    }
                                    break;
                                case 5:
                                    if (vysledek.Contains('<') && vysledek.Contains('>'))
                                        vysledek = "";
                                    else if (vysledek.Contains("\t") && vysledek.Contains('<')) {
                                        vysledek = vysledek.Substring(0, vysledek.Length - 2).Trim();
                                        udaje[prubeh, 4] = vysledek;
                                        vysledek = "";
                                        udaj = 100;
                                    }
                                    break;
                                case 6:
                                    if (vysledek.Contains("\r\n")) {
                                        udaje[prubeh, 5] = vysledek.Trim();
                                        vysledek = "";
                                        udaj = 3;
                                    }
                                    break;
                                default:
                                    vysledek = "";
                                    break;
                            }
                        }
                        udaj = 1;
                        zasobnik = "";
                        prubeh++;
                    }

                }
            }
            int index = 0;
            for (int i = 0; i < udaje.GetLength(0); i++) {
                if (udaje[i, 0] == null) {
                    index = i;
                    break;
                }
            }
            string[,] vyslednyRozpis = new string[index, 6];

            for (int i = 0; i < vyslednyRozpis.GetLength(0); i++) {
                for (int j = 0; j < 6; j++)
                    vyslednyRozpis[i, j] = udaje[i, j];
            }
            return vyslednyRozpis;
        }
    }
}
