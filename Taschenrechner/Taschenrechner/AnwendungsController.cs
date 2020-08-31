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
            double ersteEingabe = view.HoleZahlVomBenutzer();
            string operation = view.HoleOperatorVomBenuter();
            double zweiteEingabe = view.HoleZahlVomBenutzer();

            model.Berechne(ersteEingabe, zweiteEingabe, operation);

            view.GibResultatAus(operation);
            view.WarteAufEndeDurchBenutzer();

        }
    }
}
