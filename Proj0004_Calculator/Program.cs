using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proj0004_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input input = new Input();
            //input.ReadFromConsole();
            DoAction action = new DoAction();
            double result = 0;
            string[] strArray = Console.ReadLine().Split(' ');
            result = action.DoSomeAction(strArray);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
