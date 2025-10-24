using Calc1;
using Calc2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    internal class Operations : ICalc1, ICalc2
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int num3 { get; set; }
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }
        const double pi = 3.14;
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
        public double Sin(double angle)
        {

            angle %= 360;
            if (angle < 0) angle += 360;

            double rad = angle * 3.1415926535 / 180;
            double num3 = rad;
            return num3 - (num3 * num3 * num3) / 6 + (num3 * num3 * num3 * num3 * num3) / 120 - (num3 * num3 * num3 * num3 * num3 * num3 * num3) / 5040;
        }
        public double Cos(double angle)
        {
            angle %= 360;
            if (angle < 0) angle += 360;
            double rad = angle * 3.1415926535 / 180;
            double num3 = rad;
            return 1 - (num3 * num3) / 2 + (num3 * num3 * num3 * num3) / 24 - (num3 * num3 * num3 * num3 * num3 * num3) / 720;
        }
        public double Tan(double angle)
        {
            double sin = Sin(angle);
            double cos = Cos(angle);

            return sin / cos;
        }
    }

}
