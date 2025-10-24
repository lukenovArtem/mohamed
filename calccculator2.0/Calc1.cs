using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc1
{
    internal interface ICalc1
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int Subtraction(int num1, int num2);
        public int Sum(int num1, int num2);
        public int Multiplication(int num1, int num2);
        public int Division(int num1, int num2);


    }
}
