using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Film
    {
        public string Titolo{get; set; }
        public string Genere { get; set; }
        public string Anno { get; set; }

        public Film(string titolo, string genere, string anno)
        {
            Titolo = titolo;
            Genere = genere;
            Anno = anno;
        }   
    }
}
