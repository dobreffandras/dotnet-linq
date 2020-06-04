using System.Collections.Generic;
using System.Linq;
using DotnetLinq.Model;

namespace DotnetLinq.Service
{
    public class FelhasznaloService
    {
        private static List<Felhasznalo> felhasznalok;

        public FelhasznaloService()
        {
            felhasznalok = new List<Felhasznalo>
            {
                new Felhasznalo
                {
                    id = 1,
                    nev = "Dzsoki"
                },
                new Felhasznalo
                {
                    id = 2,
                    nev = "Szamanta"
                },
                new Felhasznalo
                {
                    id = 3,
                    nev = "Bobi"
                },
                new Felhasznalo
                {
                    id = 4,
                    nev = "Elli"
                }
            };
        }

        public Felhasznalo GetFelhasznaloById(long key)
        {
            return felhasznalok
                .FirstOrDefault(felhasznalo => felhasznalo.id == key);
        }
    }
}