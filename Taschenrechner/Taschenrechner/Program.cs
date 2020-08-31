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
            RechnerModel model = new RechnerModel();
            double resultat = model.Berechne(ersteEinagabeAlsZahl, zweiteEingabeAlsZahl, operation);

            // Ausgabe
            GibResultatAus(resultat, operation);
            HoleBenutzerEingabe("\n\t >>> Zum beenden bitte return drücken <<<\n");
        }
        // Methoden
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

    }
}
