using System; //Bibliothek
using System.CodeDom;
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
            // EingabeMethode
            string ersteEingabe = HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            string zweiteEingabe = HoleBenutzerEingabe("Bitte gib die zweite Zahl ein: ");
            string operation = HoleBenutzerEingabe("Bitte gib die auszuführende Operation ein (+ oder -):");

            // Wandel Text in Gleitkommazahl
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteEinagabeAlsZahl = Convert.ToDouble(ersteEingabe);
            double zweiteEingabeAlsZahl = Convert.ToDouble(zweiteEingabe);

            // Berechnung
            double result = 0;
            if (operation == "+")
            {
                 result = Addiere(ersteEinagabeAlsZahl, zweiteEingabeAlsZahl);
                Console.WriteLine("Die Summe ist: {0}", result);
            }
            else if (operation == "-")
            {
                 result = Subtrahiere(ersteEinagabeAlsZahl, zweiteEingabeAlsZahl);
                Console.WriteLine("Die Differenz ist: {0}", result);
            }
            else
            {
                Console.WriteLine("falsche Eingabe.");
            }

            // Ausgabe
            
            HoleBenutzerEingabe("\n\t >>> Zum beenden bitte return drücken <<<\n");
        }    
        static string HoleBenutzerEingabe(string ausgabetext)
        {
            Console.WriteLine(ausgabetext);
            string eingabe = Console.ReadLine();
            return eingabe;
        }

        static double Subtrahiere(double a, double b)
        {
            return a - b;
        }


        static double Addiere(double a, double b)
        {
            return a + b;
        }

    }
}
