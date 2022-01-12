using System;
using System.Collections.Generic;
using System.Linq;
using DotnetLinq.Model;

namespace DotnetLinq.Service
{
    public class ValaszPrintService
    {
        private static KerdesService kerdesService = new KerdesService();
        private static ValaszService valaszService = new ValaszService();
        private static FelhasznaloService felhasznaloService = new FelhasznaloService();

        public static List<KerdoivSor> GetSzabadszavasSorok()
        {
            List<KerdoivSor> result = new List<KerdoivSor>();

            var szabadszovegesKerdesek = 
                kerdesService
                    .FindAll()
                    .Where(kerdes => kerdes.tipus == KerdesTipus.SZABAD_SZOVEGES);
            
            foreach (var kerdes in szabadszovegesKerdesek)
            {
                var valaszok = valaszService.FindByKerdesId(kerdes.id);
                var felhasznalok = 
                    valaszok.Select(v => v.felhasznaloId).Distinct()
                    .Select(id => felhasznaloService.GetFelhasznaloById(id))
                    .ToArray();


                result.AddRange(valaszok.Join(felhasznalok, v => v.felhasznaloId, f => f.id, (v, f) =>
                    new KerdoivSor
                    {
                        kerdes = kerdes.kerdes,
                        valaszadoValasz = new List<string>() {v.valaszSzoveg},
                        felhasznaloNev = f.nev,
                    }));
            }

            return result;
            /*
             * Második feladat: Implementáljuk ezt a metódust úgy, hogy logolja ki a konzolra az adatbázisban található
             * szabadszavas kérdéseket a hozzá tartozó válaszokkal úgy, hogy a válaszokat felhasználó szerint rendezi.
             * A kapott eredmény az alábbi kell legyen:
             *
             * Megy a biznic?
             * =========================
             * Dzsoki: Megy?
             * Szamanta: Mit főzzek Dzsok?
             * Bobi: Menne?
             * Elli: Nem értek hozzá?
             *
             * Hány részes a Dallas?
             * =========================
             * Dzsoki: 23131
             * Szamanta: Innák inkább
             * Elli: Mit főzzek Dzsok?
             *
             * Van elég olaj?
             * =========================
             * Dzsoki: Fúj ez tea., Egyébként van
             * Szamanta: Whiskey
             * Bobi: Akad
             */
            //return new List<KerdoivSor>();
        }


        public static List<KerdoivSor> GetFeleletvalasztoSorok()
        {
            /*
             * Harmadik feladat: Implementáljuk ezt a metódust úgy, hogy logolja ki a konzolra az adatbázisban található
             * feleletválasztós kérdéseket és a hozzá tartozó válaszokat úgy, hogy a válaszokat felhasználó szerint rendezi.
             * A kapott eredmény az alábbi kell legyen:
             *
             * Hol veszünk idén olajmezőket?
             * =========================
             * Dzsoki: Arkansas
             * Szamanta: Dallas, Alaszka
             * Bobi: Alaszka
             * Elli: Somogy megye
             *
             * Dzsok milyen söröket szeret?
             * =========================
             * Dzsoki: Duff
             * Szamanta: Ászok, Pilsner
             * Bobi: Pilsner
             * Elli: Swvinjan
             *
             * Lucy-nek milyen színű táskái vannak?
             * =========================
             * Dzsoki: Kék
             * Szamanta: Zöld, Sárga
             * Bobi: Sárga
             * Elli: Piros
             */
            return new List<KerdoivSor>();
        }


        public static List<KerdoivSor> GetSkalaSorok()
        {
            /*
             * Negyedik feladat: Implementáljuk ezt a metódust úgy, hogy logolja ki a konzolra az adatbázisban található
             * skálázós kérdéseket és a hozzá tartozó válaszokat úgy, hogy a válaszokat felhasználó szerint rendezi.
             * A kapott eredmény az alábbi kell legyen:
             *
             * Mennyire vagyunk gazdagok?
             * =========================
             * Dzsoki: **
             * Szamanta: **
             * Bobi: *****
             * Elli: ****
             *
             * Mennyire alkoholista Szamanta?
             * =========================
             * Dzsoki: *
             * Szamanta: *****
             * Bobi: **
             * Elli: *
             *
             * Mennyire jó a rancs?
             * =========================
             * Dzsoki: **
             * Szamanta: **
             * Bobi: ***
             * Elli: *
             *
             */
            return new List<KerdoivSor>();
        }
    }
}