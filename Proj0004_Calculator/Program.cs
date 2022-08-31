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
            Input input = new Input();
            input.Read();
            DoAction action = new DoAction(input.First, input.Second, input.Symbol);
            double result = 0;
            result = action.DoAction();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
