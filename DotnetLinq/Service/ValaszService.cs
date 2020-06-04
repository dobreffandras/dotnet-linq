using System.Collections.Generic;
using System.Linq;
using DotnetLinq.Model;

namespace DotnetLinq.Service
{
    public class ValaszService
    {
        private static List<Valasz> db;
        private static long counter = 0l;

        public ValaszService()
        {
            db = new List<Valasz>
            {
                new Valasz
                {
                    kerdesId = 1l,
                    felhasznaloId = 1l,
                    valaszSzoveg = "23131"
                },
                new Valasz
                {
                    kerdesId = 1l,
                    felhasznaloId = 2l,
                    valaszSzoveg = "Innák inkább"
                },
                new Valasz
                {
                    kerdesId = 1l,
                    felhasznaloId = 4l,
                    valaszSzoveg = "Mit főzzek Dzsoki?"
                },
                new Valasz
                {
                    kerdesId = 0l,
                    felhasznaloId = 1l,
                    valaszSzoveg = "Megy?"
                },
                new Valasz
                {
                    kerdesId = 0l,
                    felhasznaloId = 2l,
                    valaszSzoveg = "Mit főzzek Dzsoki?"
                },
                new Valasz
                {
                    kerdesId = 0l,
                    felhasznaloId = 3l,
                    valaszSzoveg = "Menne?"
                },
                new Valasz
                {
                    kerdesId = 0l,
                    felhasznaloId = 4l,
                    valaszSzoveg = "Nem értek hozzá?"
                },
                new Valasz
                {
                    kerdesId = 2l,
                    felhasznaloId = 1l,
                    valaszSzoveg = "Fúj ez tea., Egyébként van"
                },
                new Valasz
                {
                    kerdesId = 2l,
                    felhasznaloId = 2l,
                    valaszSzoveg = "Whiskey"
                },
                new Valasz
                {
                    kerdesId = 2l,
                    felhasznaloId = 3l,
                    valaszSzoveg = "Akad"
                },
                new Valasz
                {
                    kerdesId = 3l,
                    felhasznaloId = 1l,
                    valaszErtek = 1
                },
                new Valasz
                {
                    kerdesId = 3l,
                    felhasznaloId = 2l,
                    valaszErtek = 2
                },
                new Valasz
                {
                    kerdesId = 3l,
                    felhasznaloId = 2l,
                    valaszErtek = 3
                },
                new Valasz
                {
                    kerdesId = 3l,
                    felhasznaloId = 3l,
                    valaszErtek = 3
                },
                new Valasz
                {
                    kerdesId = 3l,
                    felhasznaloId = 4l,
                    valaszErtek = 4
                },
                new Valasz
                {
                    kerdesId = 4l,
                    felhasznaloId = 1l,
                    valaszErtek = 1
                },
                new Valasz
                {
                    kerdesId = 4l,
                    felhasznaloId = 2l,
                    valaszErtek = 2
                },
                new Valasz
                {
                    kerdesId = 4l,
                    felhasznaloId = 2l,
                    valaszErtek = 3
                },
                new Valasz
                {
                    kerdesId = 4l,
                    felhasznaloId = 3l,
                    valaszErtek = 3
                },
                new Valasz
                {
                    kerdesId = 4l,
                    felhasznaloId = 4l,
                    valaszErtek = 4
                },
                new Valasz
                {
                    kerdesId = 5l,
                    felhasznaloId = 1l,
                    valaszErtek = 1
                },
                new Valasz
                {
                    kerdesId = 5l,
                    felhasznaloId = 2l,
                    valaszErtek = 2
                },
                new Valasz
                {
                    kerdesId = 5l,
                    felhasznaloId = 2l,
                    valaszErtek = 3
                },
                new Valasz
                {
                    kerdesId = 5l,
                    felhasznaloId = 3l,
                    valaszErtek = 3
                },
                new Valasz
                {
                    kerdesId = 5l,
                    felhasznaloId = 4l,
                    valaszErtek = 4
                },
                new Valasz
                {
                    kerdesId = 6l,
                    felhasznaloId = 1l,
                    valaszErtek = 2
                },
                new Valasz
                {
                    kerdesId = 6l,
                    felhasznaloId = 2l,
                    valaszErtek = 2
                },
                new Valasz
                {
                    kerdesId = 6l,
                    felhasznaloId = 3l,
                    valaszErtek = 5
                },
                new Valasz
                {
                    kerdesId = 6l,
                    felhasznaloId = 4l,
                    valaszErtek = 4
                },
                new Valasz
                {
                    kerdesId = 7l,
                    felhasznaloId = 1l,
                    valaszErtek = 1
                },
                new Valasz
                {
                    kerdesId = 7l,
                    felhasznaloId = 2l,
                    valaszErtek = 5
                },
                new Valasz
                {
                    kerdesId = 7l,
                    felhasznaloId = 3l,
                    valaszErtek = 2
                },
                new Valasz
                {
                    kerdesId = 7l,
                    felhasznaloId = 4l,
                    valaszErtek = 1
                },
                new Valasz
                {
                    kerdesId = 8l,
                    felhasznaloId = 1l,
                    valaszErtek = 2
                },
                new Valasz
                {
                    kerdesId = 8l,
                    felhasznaloId = 2l,
                    valaszErtek = 2
                },
                new Valasz
                {
                    kerdesId = 8l,
                    felhasznaloId = 3l,
                    valaszErtek = 3
                },
                new Valasz
                {
                    kerdesId = 8l,
                    felhasznaloId = 4l,
                    valaszErtek = 1
                }
            };
        }

        public List<Valasz> FindByKerdesId(long id)
        {
            return db
                .Where(valasz => valasz.kerdesId == id)
                .ToList();
        }
    }
}