using System;

namespace KlassenDefinieren
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto meinAuto = new Auto("Audi");
            Auto deinAuto = new Auto("Porsche");

            meinAuto.AlterInJahren = 13;
            deinAuto.AlterInJahren = 1;

            Console.WriteLine("Mein Auto fährt aktuell {0} km/h.", meinAuto.SagAktuelleGeschwindigkeit());
            Console.WriteLine("Dein Auto fährt aktuell {0} km/h.", deinAuto.SagAktuelleGeschwindigkeit());
            meinAuto.BeschleunigeAuf100KmH();
            deinAuto.BeschleunigeAuf100KmH();
            Console.WriteLine("Mein Auto fährt aktuell {0} km/h.", meinAuto.SagAktuelleGeschwindigkeit());
            Console.WriteLine("Dein Auto fährt aktuell {0} km/h.", deinAuto.SagAktuelleGeschwindigkeit());

            Console.ReadLine();
        }
    }
}
