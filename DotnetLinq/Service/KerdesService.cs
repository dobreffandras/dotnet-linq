using System.Collections.Generic;
using System.Linq;
using DotnetLinq.Model;

namespace DotnetLinq.Service
{
    public class KerdesService
    {
        private static List<Kerdes> db;
        private static long counter = 0l;

        public KerdesService()
        {
            db = new List<Kerdes>
            {
                new Kerdes
                {
                    id = counter++,
                    tipus = KerdesTipus.SZABAD_SZOVEGES,
                    kerdes = "Megy a biznic?"
                },
                new Kerdes
                {
                    id = counter++,
                    tipus = KerdesTipus.SZABAD_SZOVEGES,
                    kerdes = "Hány részes a Dallas?"
                },
                new Kerdes
                {
                    id = counter++,
                    tipus = KerdesTipus.SZABAD_SZOVEGES,
                    kerdes = "Van elég olaj?"
                },
                new Kerdes
                {
                    id = counter++,
                    tipus = KerdesTipus.FELELET_VALASZTO,
                    kerdes = "Hol veszünk idén olajmezőket?",
                    valaszlehetosegek = new List<Valaszlehetoseg>
                    {
                        new Valaszlehetoseg
                        {
                            kerdesId = counter,
                            valasz = "Arkansas",
                            sorszam = 1
                        },
                        new Valaszlehetoseg
                        {
                            kerdesId = counter,
                            valasz = "Dallas",
                            sorszam = 2
                        },
                        new Valaszlehetoseg
                        {
                            kerdesId = counter,
                            valasz = "Alaszka",
                            sorszam = 3
                        },
                        new Valaszlehetoseg
                        {
                            kerdesId = counter,
                            valasz = "Somogy megye",
                            sorszam = 4
                        },
                        new Valaszlehetoseg
                        {
                            kerdesId = counter,
                            valasz = "Irak",
                            sorszam = 5
                        }
                    }
                },
                new Kerdes
                {
                    id = counter++,
                    tipus = KerdesTipus.FELELET_VALASZTO,
                    kerdes = "Dzsoki milyen söröket szeret?",
                    valaszlehetosegek = new List<Valaszlehetoseg>
                    {
                        new Valaszlehetoseg
                        {
                            kerdesId = counter,
                            valasz = "Duff",
                            sorszam = 1
                        },
                        new Valaszlehetoseg
                        {
                            kerdesId = counter,
                            valasz = "Ászok",
                            sorszam = 2
                        },
                        new Valaszlehetoseg
                        {
                            kerdesId = counter,
                            valasz = "Pilsner",
                            sorszam = 3
                        },
                        new Valaszlehetoseg
                        {
                            kerdesId = counter,
                            valasz = "Swvinjan",
                            sorszam = 4
                        },
                        new Valaszlehetoseg
                        {
                            kerdesId = counter,
                            valasz = "Dreher",
                            sorszam = 5
                        }
                    }
                },
                new Kerdes
                {
                    id = counter++,
                    tipus = KerdesTipus.FELELET_VALASZTO,
                    kerdes = "Lucy-nek milyen színű táskái vannak?",
                    valaszlehetosegek = new List<Valaszlehetoseg>
                    {
                        new Valaszlehetoseg
                        {
                            kerdesId = counter,
                            valasz = "Kék",
                            sorszam = 1
                        },
                        new Valaszlehetoseg
                        {
                            kerdesId = counter,
                            valasz = "Zöld",
                            sorszam = 2
                        },
                        new Valaszlehetoseg
                        {
                            kerdesId = counter,
                            valasz = "Sárga",
                            sorszam = 3
                        },
                        new Valaszlehetoseg
                        {
                            kerdesId = counter,
                            valasz = "Piros",
                            sorszam = 4
                        },
                        new Valaszlehetoseg
                        {
                            kerdesId = counter,
                            valasz = "Narancs",
                            sorszam = 5
                        }
                    }
                },
                new Kerdes
                {
                    id = counter++,
                    tipus = KerdesTipus.SKALA,
                    kerdes = "Mennyire vagyunk gazdagok?"
                },
                new Kerdes
                {
                    id = counter++,
                    tipus = KerdesTipus.SKALA,
                    kerdes = "Mennyire alkoholista Szamanta?"
                },
                new Kerdes
                {
                    id = counter++,
                    tipus = KerdesTipus.SKALA,
                    kerdes = "Mennyire jó a rancs?"
                }
            };
        }

        public List<Kerdes> FindAll()
        {
            return db;
        }

        public static Kerdes FindById(long id)
        {
            return db
                .FirstOrDefault(kerdes => kerdes.id == id);
        }
    }
}