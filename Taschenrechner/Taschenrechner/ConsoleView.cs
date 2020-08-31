using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class ConsoleView
    {
        private RechnerModel model;
        public ConsoleView(RechnerModel model)
        {
            this.model = model;
        }
        public string HoleZahlVomBenutzer()
        {
            Console.Write("Bitte gib eine Zahl für die Berechung ein: ");
            return Console.ReadLine();
        }
        public string HoleOperatorVomBenuter()
        {
            Console.Write("Bitte gib die auszuführende Operation ein: \n\t\t+ | - | * | /:\t");
            return Console.ReadLine();
        }
        public void WarteAufEndeDurchBenutzer()
        {
            Console.Write("\n\t >>> Zum beenden bitte return drücken <<<\n");
            Console.ReadLine();
        }
        public void GibResultatAus(string _operation)
        {
            switch (_operation)
            {
                case "+":
                    Console.WriteLine("Die Sumnme ist: {0}", model.Resultat);
                    break;
                case "-":
                    Console.WriteLine("Die Differenz ist: {0}", model.Resultat);
                    break;
                case "*":
                    Console.WriteLine("Das Produkt ist: {0}", model.Resultat);
                    break;
                case "/":
                    Console.WriteLine("Der Quotient ist: {0}", model.Resultat);
                    break;
                default:
                    Console.WriteLine("Ungütige Eingabe");
                    break;
            }

        }

    }
}
