using InterfaceCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculate : ICalculator
    {
        const double pi = 3.14;
        public int num3 { get; set; }
        public int num4 { get; set; }

        public int Exponentiation2(int num3)
        {
            return num3 * num3;
        }
        public int Exponentiation3(int num3)
        {
            return (num3 * num3 * num3);
        }
        public double Root(double num3)
        {
            double guess = num3 / 2;
            for (int i = 0; i < 10; i++)
            {
                guess = (guess + num3 / guess) / 2;
            }
            return guess;
        }
        public double Sin(int num3)
        {
            return (num3 * pi) / 60;
        }
        public double Cos(int num3)
        {
            return (num3 * pi) / 90;
        }
        public double Tan(int num3)
        {
            return (num3 * pi) / 180;
        }
    }
}