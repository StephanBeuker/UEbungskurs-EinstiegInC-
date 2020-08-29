using System; //Bibliothek
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Calc_AddOnly
{   //UserStory "Addieren":Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
    class Program
    {
        static void Main(string[] args)
        {
            //Parsing
            Console.WriteLine("Bitte gib den ersten Summanden: ");
            int ersterSummand = int.Parse(Console.ReadLine());

            //Convert-KLasse
            Console.WriteLine("Bitte gib den zweiten Summanden: ");
            string zweiterSummand = Console.ReadLine();
            int zweiterSummandAlsZahl = Convert.ToInt32(zweiterSummand);

            //Berechnung
            int summe = ersterSummand + zweiterSummandAlsZahl;
            
            //Ausgabe
            Console.WriteLine("Die Summe ist: {0}", summe);

            Console.ReadKey();

        }   
    }
}
