using System.Collections.Generic;

namespace DotnetLinq.Model
{
    public class Kerdes
    {
        public long id { get; set; }
        public string kerdes { get; set; }
        public KerdesTipus tipus { get; set; }
        public List<Valaszlehetoseg> valaszlehetosegek { get; set; }
    }
}