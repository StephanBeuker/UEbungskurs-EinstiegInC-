using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class AnwendungsController
    {
        private ConsoleView view;
        private RechnerModel model;
        public AnwendungsController(ConsoleView view, RechnerModel model)
        {
            this.view = view;
            this.model = model;
        }
        public void Ausfuehren()
        {
            string ersteEingabe = view.HoleZahlVomBenutzer();
            string operation = view.HoleOperatorVomBenuter();
            string zweiteEingabe = view.HoleZahlVomBenutzer();

            double ersteEinagabeAlsZahl = Convert.ToDouble(ersteEingabe);
            double zweiteEingabeAlsZahl = Convert.ToDouble(zweiteEingabe);

            model.Berechne(ersteEinagabeAlsZahl, zweiteEingabeAlsZahl, operation);

            view.GibResultatAus(operation);
            view.WarteAufEndeDurchBenutzer();

        }
    }
}
