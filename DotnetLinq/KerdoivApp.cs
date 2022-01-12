using System;
using System.Collections.Generic;
using System.Linq;
using DotnetLinq.Model;
using DotnetLinq.Service;

namespace DotnetLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KerdoivSor> sorok = new List<KerdoivSor>
            {
                new KerdoivSor
                {
                    kerdes = "Kerdes1",
                    felhasznaloNev = "Andi",
                    valaszadoValasz = new List<string>
                    {
                        "A1", "A2", "A3"
                    }
                },
                new KerdoivSor
                {
                    kerdes = "Kerdes1",
                    felhasznaloNev = "Béla",
                    valaszadoValasz = new List<string>
                    {
                        "B1", "B2", "B3"
                    }
                },
                new KerdoivSor
                {
                    kerdes = "Kerdes1",
                    felhasznaloNev = "Cecil",
                    valaszadoValasz = new List<string>
                    {
                        "C1", "C2", "C3"
                    }
                },
                new KerdoivSor
                {
                    kerdes = "Kérdés3",
                    felhasznaloNev = "Cecil",
                    valaszadoValasz = new List<string>
                    {
                        "F1", "F2", "F3"
                    }
                },
                new KerdoivSor
                {
                    kerdes = "Kérdés2",
                    felhasznaloNev = "Béla",
                    valaszadoValasz = new List<string>
                    {
                        "D1", "D2", "D3"
                    }
                },
                new KerdoivSor
                {
                    kerdes = "Kérdés2",
                    felhasznaloNev = "Andi",
                    valaszadoValasz = new List<string>
                    {
                        "E1", "E2", "E3"
                    }
                }
            };

            printSorok(sorok);
            printSorok(ValaszPrintService.GetSzabadszavasSorok());
            printSorok(ValaszPrintService.GetFeleletvalasztoSorok());
            printSorok(ValaszPrintService.GetSkalaSorok());
        }

        private static void printSorok(List<KerdoivSor> sorok)
        {
            /*
             * ELSŐ FELADAT: Implementáljuk ezt a metódust úgy, hogy az inputként megkapott kérdőív sorokat
             * a lenti példában megadott formában írassuk ki a konzolra:
             *
             * Kerdes1
             *        =========================
             * Andi: A1, A2, A3
             * Béla: B1, B2, B3
             * Cecil: C1, C2, C3
             *
             * Kérdés3
             *       =========================
             * Cecil: F1, F2, F3
             *
             * Kérdés2
             *       =========================
             * Béla: D1, D2, D3
             * Andi: E1, E2, E3
             */
            foreach (var kerdoivSor in sorok.GroupBy(sor => sor.kerdes))
            {
                Console.WriteLine(kerdoivSor.Key);
                Console.WriteLine("      =========================");
                foreach (var sor in kerdoivSor)
                {
                    Console.Write(sor.felhasznaloNev + ": ");
                    Console.Write(String.Join(", ", sor.valaszadoValasz));
                    Console.WriteLine();
                }
                
                Console.WriteLine();
            }
            
        }
    }
}