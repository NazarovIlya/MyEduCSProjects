using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0004_Calculator
{
    internal class Expression
    {
        public double First { get; set; }
        public double Second { get;  set; }
        public char Symbol { get; set; }
        public Expression(double first, double second, char symbol)
        {
            First = first;
            Second = second;
            Symbol = symbol;
        }
        public Expression()
        {
        }
        public double Addition()
        {
            return First + Second;
        }
        public double Substraction()
        {
            return First - Second;
        }
        public double Multiplication()
        {
            return First * Second;
        }
        public double Division()
        {
            return First / Second;
        }
    }
}
