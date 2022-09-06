using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCCS0006_ArethmitecOperators
{
    internal class Input
    {
        Expression expression = new Expression();
        public Input()
        {
        }

        public void ReadFromConsole()
        {
            Console.WriteLine();
            string[] array = Console.ReadLine().Split(' ', ',');
            expression.First = Convert.ToDouble(array[0]);
            expression.Second = Convert.ToDouble(array[1]);
        }
    }
}
