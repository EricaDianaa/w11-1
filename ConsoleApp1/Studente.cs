using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Studente
    {
        public double AnniTrascorsi { get; set; }
        public double AnniMancanti

        {
            get
            {
                return 5 - AnniTrascorsi;
            }
        }
        public string Nome { get; set; }
        public string Cognome {get; set; }
        public string Matematica{ get; set; }
        public string Italiano {get; set; }
        public string Inglese { get; set; }

        public Studente(string matematica, string italiano, string inglese)
        {
            Matematica = matematica;
            Italiano = italiano;
            Matematica = inglese;
           
        }


    }
}
