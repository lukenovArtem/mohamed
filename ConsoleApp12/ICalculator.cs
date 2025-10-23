using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCalculator
{
    internal interface ICalculator
    {
        public int num3 { get; set; }
        public int num4 { get; set; }
        public int Exponentiation2(int num3);
        public int Exponentiation3(int num3);
        public double Root(double num3);
        public double Sin(double num3);
        public double Cos(double num3);
        public double Tan(double num3);
    }
}