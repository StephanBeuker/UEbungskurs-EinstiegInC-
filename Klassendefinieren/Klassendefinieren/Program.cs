using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Klassendefinieren
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Auto meinAuto = new Auto();
            Auto deinAuto = new Auto();

            meinAuto.alterInJahren = 13;
            meinAuto.marke = "Audi";
            meinAuto.AktuelleGeschwindigkeit(73);
            

            deinAuto.alterInJahren = 1;
            deinAuto.marke = "Porsche";

            meinAuto.AktuelleGeschwindigkeit(100);
            meinAuto.BeschleunigeAuf100KmH();
            deinAuto.BeschleunigeAuf100KmH();

            meinAuto.Beenden();
        }
    }
}
 