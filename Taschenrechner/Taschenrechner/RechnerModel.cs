using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Resultat { get; private set; }
        public string Operation { get; private set; }
        public RechnerModel()
        {
            Resultat = 0;
            Operation = "unbekannt";
        }
        public void Berechne(double a, double b, string _operation)
        {
            this.Operation = _operation;
            switch (_operation)
            {
                case "+":
                    Resultat = Addiere(a, b);
                    break;
                case "-":
                    Resultat = Subtrahiere(a, b);
                    break;
                case "*":
                    Resultat = Multipliziere(a, b);
                    break;
                case "/":
                    Resultat = Dividiere(a, b);
                    break;
            }
        }
        
        private double Subtrahiere(double a, double b)
        {
            return a - b;
        }
        private double Addiere(double a, double b)
        {
            return a + b;
        }
        private double Multipliziere(double a, double b)
        {
            return a * b;
        }
        private double Dividiere(double a, double b)
        {
            return a / b;
        }
    }
}
