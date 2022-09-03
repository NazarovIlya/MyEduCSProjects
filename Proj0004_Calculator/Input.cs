using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0004_Calculator
{
    internal class Input
    {
        //public double First { get; private set; }
        //public double Second { get; private set; }
        //public char Symbol { get; private set; }
        public string[] ReadFromConsole()
        {
            Console.WriteLine("Введите любое математическое выражение, например: 2 + 2 или 2 + 5 + 6 - 10");
            string[] strArray = Console.ReadLine().Split(' ');
            //First = double.Parse(strArray[0]);
            //Symbol = Convert.ToChar(strArray[1]);
            //Second = double.Parse(strArray[2]);
            return strArray;
        }
    }
}
