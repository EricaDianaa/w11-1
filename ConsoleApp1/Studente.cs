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

     
    }
}
