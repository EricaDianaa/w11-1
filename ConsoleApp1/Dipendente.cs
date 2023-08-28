using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dipendente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Lavoro { get;set; }
        public string Stipendio{get; set; }
        public Dipendente(string nome, string cognome, string lavoro, string stipendio)
        {
            Nome = nome;
            Cognome = cognome;
            Lavoro = lavoro;
            Stipendio = stipendio;

        }

     

    }
}
