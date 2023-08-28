using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w11
{
    public class Atleta
    {
        private string _nomi;
        public string Nomi
        {
            get
            {
                return _nomi;
            }
            set
            {
                _nomi = value;
            }
        } 
        public string Cognome { get; set; }
        public string Età { get; set; }
       public string Sport { get; set; }
        public string FullName()
        {
            return _nomi + " " + Cognome;
        }
        public void Informazioni()
        {
            Console.WriteLine("Ho " + Età  + " anni e faccio " + Sport);
        }
    }
}

