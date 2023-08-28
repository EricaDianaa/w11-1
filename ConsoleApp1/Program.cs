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
            //classi
            Atleta nomi = new Atleta();

            nomi.Nomi = "Mario";
            nomi.Cognome = "Rossi";
            nomi.Età = "20";
            nomi.Sport = "Calcio";

            Animale animale = new Animale();
            animale.Nomi = "nebbia";
            animale.NomePadrone = "Erica";
            animale.Animal = "cane";


            Studente studente = new Studente("8", "6", "10");
            studente.AnniTrascorsi = 1;
            studente.Nome = "Maria";
            studente.Cognome = "Bianchi";

            Dipendente dipendente = new Dipendente("Mario", "Rossi", "Barista", "1200");

            Film film = new Film("Sole a catinelle", "Comico", "2013");

            //console
            Console.WriteLine(" ");
            Console.WriteLine(nomi.FullName());
            nomi.Informazioni();

            Console.WriteLine(" ");
            Console.WriteLine(animale.FullName());

            Console.WriteLine(" ");
            Console.Write("Sono al " + studente.AnniTrascorsi + " ° anno di università" );
            Console.Write("Per finire la scuola ti mancano " + studente.AnniMancanti +" anni");
            Console.WriteLine(studente.Nome);
            Console.WriteLine(studente.Cognome);
            Console.WriteLine(studente.Matematica);
            Console.WriteLine(studente.Inglese);
            Console.WriteLine(studente.Italiano);

            Console.WriteLine(" ");
            Console.WriteLine(dipendente.Nome);
            Console.WriteLine(dipendente.Cognome);
            Console.WriteLine(dipendente.Lavoro);
            Console.WriteLine(dipendente.Stipendio);

            Console.WriteLine(" ");
            Console.WriteLine(film.Titolo);
            Console.WriteLine(film.Genere);
            Console.WriteLine(film.Anno);

            Console.ReadLine();
        }
    }
}
