using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta nomi = new Atleta();

            nomi.Nomi = "Mario";
            nomi.Cognome = "Rossi";
            nomi.Età = "20";
            nomi.Sport = "Calcio";

            Animale animale = new Animale();
            animale.Nomi = "nebbia";
            animale.NomePadrone = "Erica";
            animale.Animal = "cane";


            Studente studente=new Studente();
            studente.AnniTrascorsi = 1;


            Console.WriteLine(nomi.FullName());
            nomi.Informazioni();
            Console.WriteLine(animale.FullName());
            Console.Write("Sono al " + studente.AnniTrascorsi + " ° anno di università" );
            Console.Write("Per finire la scuola ti mancano " + studente.AnniMancanti + "anni");
            Console.ReadLine();
        }
    }
}
