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
            string operation = HoleBenutzerEingabe("Bitte gib die auszuführende Operation ein: \n\t\t+ | - | * | /");
            
            // Wandel Text in Gleitkommazahl
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteEinagabeAlsZahl = Convert.ToDouble(ersteEingabe);
            double zweiteEingabeAlsZahl = Convert.ToDouble(zweiteEingabe);

            // Berechnung
            double resultat = Berechnung(ersteEinagabeAlsZahl, zweiteEingabeAlsZahl, operation);

            // Ausgabe
            GibResultatAus(resultat, operation);
            HoleBenutzerEingabe("\n\t >>> Zum beenden bitte return drücken <<<\n");
        }    
        // Methoden
         static double Berechnung(double a, double b, string _operation)
        {
            double resultat = 0;
            switch (_operation)
            {
                case "+": 
                    resultat = Addiere(a, b);
                    break;
                case "-":
                    resultat = Subtrahiere(a, b);
                    break;
                case "*":
                    resultat = Multipliziere(a, b);
                    break;
                case "/":
                    resultat = Dividiere(a, b);
                    break;
            }
            return resultat;
        }
        static void GibResultatAus(double resultat, string _operation)
        {
            switch (_operation)
            {
                case "+":
                    Console.WriteLine("Die Sumnme ist: {0}", resultat);
                    break;
                case "-":
                    Console.WriteLine("Die Differenz ist: {0}", resultat);
                    break;
                case "*":
                    Console.WriteLine("Das Produkt ist: {0}", resultat);
                    break;
                case "/":
                    Console.WriteLine("Der Quotient ist: {0}", resultat);
                    break;
                default:
                    Console.WriteLine("Ungütige Eingabe");
                    break;
            }
            
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
        static double Multipliziere(double a, double b)
        {
            return a * b;
        }
        static double Dividiere(double a, double b)
        {
            return a / b;
        }

    }
}
