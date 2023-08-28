using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animale
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
        public string NomePadrone { get; set; }
        public string Animal { get; set; }
        public string Sport { get; set; }
        public string FullName()
        {
            return "Sono " + NomePadrone + " e ho un " + Animal + " di nome " + _nomi;
        }
    
    
}
}
