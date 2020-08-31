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
        public string HoleBenutzerEingabe(string ausgabetext)
        {
            Console.WriteLine(ausgabetext);
            return Console.ReadLine();
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
