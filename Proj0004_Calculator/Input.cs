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
        public void ReadFromConsole()
        {
            string[] strArray = Console.ReadLine().Split(' ');
            //First = double.Parse(strArray[0]);
            //Symbol = Convert.ToChar(strArray[1]);
            //Second = double.Parse(strArray[2]);
        }
    }
}
