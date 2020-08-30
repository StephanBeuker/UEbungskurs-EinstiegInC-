using System; //Bibliothek
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{   
    class Program
    {
        static void Main(string[] args)
        {
            //  EingabeMethode
            string ersterSummand = HoleSummanden("Bitte gib den ersten Summanden ein: ");
            string zweiterSummand = HoleSummanden("Bitte gib den zweiten Summanden ein: ");

            //Wandel Text in Gleitkommazahl
            double ersterSummandAlsZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandAlsZahl = Convert.ToDouble(zweiterSummand);     

            //Berechnung
            double summe = Addiere(ersterSummandAlsZahl, zweiterSummandAlsZahl);
            
            //Ausgabe
            Console.WriteLine("Die Summe ist: {0}", summe);

            WarteAufBenutzerEinagabe();
        }   
        static string HoleSummanden(string ausgabetext)
        {
            Console.WriteLine(ausgabetext);
            string eingabe = Console.ReadLine();
            return eingabe;
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
