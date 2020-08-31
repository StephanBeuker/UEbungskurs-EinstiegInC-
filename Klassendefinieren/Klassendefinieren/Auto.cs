using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendefinieren
{
    public class Auto
    {
        // Attribute
        public string marke;
        public int alterInJahren;
        private int aktuelleGeschwindigkeit;

        

        // Methoden
        public void BeschleunigeAuf100KmH()
        {
            aktuelleGeschwindigkeit = 100;
            if (IstSchnell())
            {
                Console.WriteLine("Habe schnell beschleunigt!");
            }
            else
            {
                Console.WriteLine("Habe normal beschleunigt!");
            }
        }
        public int AktuelleGeschwindigkeit(int a)
        {
            return aktuelleGeschwindigkeit;
        }
        private bool IstSchnell()
        {
            if (marke == "Porsche")
            {
                return true;
            }
            return false;
        }
        public void Beenden()
        {
            Console.WriteLine("\n\t\t >>>Press Enter to close window<<<");
            Console.ReadLine();
        }
    }
}
