using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0004_Calculator
{
    internal class Input
    {
        public double First { get; set; }
        public double Second { get; set; }
        public char Symbol { get; set; }
        public Input(double first, char symbol, double second)
        {
            First = first;
            Second = second;
            Symbol = symbol;
        }
        public Input()
        {
        }
        public void Read()
        {
            string[] strArray = Console.ReadLine().Split(' ');
            First = double.Parse(strArray[0]);
            Symbol = Convert.ToChar(strArray[1]);
            Second = double.Parse(strArray[2]);
        }
    }
}
