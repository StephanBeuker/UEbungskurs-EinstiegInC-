using System; //Bibliothek
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{   //UserStory "Addieren":Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
    class Program
    {
        static void Main(string[] args)
        {
            //Parsing
            Console.WriteLine("Bitte gib den ersten Summanden: ");
            double ersterSummand = double.Parse(Console.ReadLine());

            //Wandel Text in Gleitkommazahl
            Console.WriteLine("Bitte gib den zweiten Summanden: ");
            string zweiterSummand = Console.ReadLine();
            double zweiterSummandAlsZahl = Convert.ToDouble(zweiterSummand);     

            //Berechnung
            double summe = Addiere(ersterSummand, zweiterSummandAlsZahl);
            
            //Ausgabe
            Console.WriteLine("Die Summe ist: {0}", summe);

            WarteAufBenutzerEinagabe();
        }   
        static double Addiere(double a, double b)
        {
            return a + b;
        }


        static void WarteAufBenutzerEinagabe()
        {
            Console.WriteLine();
            Console.WriteLine("\t >>> Zum beenden bitte return drücken <<<");
            Console.ReadLine();
        }
    }
}
