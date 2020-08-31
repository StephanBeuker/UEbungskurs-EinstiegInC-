using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Berechne(double a, double b, string _operation)
        {
            double resultat = 0;
            switch (_operation)
            {
                case "+":
                    resultat = Addiere(a, b);
                    break;
                case "-":
                    resultat = Subtrahiere(a, b);
                    break;
                case "*":
                    resultat = Multipliziere(a, b);
                    break;
                case "/":
                    resultat = Dividiere(a, b);
                    break;
            }
            return resultat;
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
