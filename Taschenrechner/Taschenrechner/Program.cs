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
            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);
            // EingabeMethode
            string ersteEingabe = view.HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            string zweiteEingabe = view.HoleBenutzerEingabe("Bitte gib die zweite Zahl ein: ");
            string operation = view.HoleBenutzerEingabe("Bitte gib die auszuführende Operation ein: \n\t\t+ | - | * | /");
            
            // Wandel Text in Gleitkommazahl
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteEinagabeAlsZahl = Convert.ToDouble(ersteEingabe);
            double zweiteEingabeAlsZahl = Convert.ToDouble(zweiteEingabe);

            // Berechnung
            model.Berechne(ersteEinagabeAlsZahl, zweiteEingabeAlsZahl, operation);

            // Ausgabe
            view.GibResultatAus(operation);
            view.HoleBenutzerEingabe("\n\t >>> Zum beenden bitte return drücken <<<\n");
        }
       
       

    }
}
