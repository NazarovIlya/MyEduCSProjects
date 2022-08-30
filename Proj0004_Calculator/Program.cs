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
            Expression expression = new Expression();
            input.Read();
            expression.First = input.First;
            expression.Second = input.Second;
            expression.Symbol = input.Symbol;
            //    public void Action()
            //    {
            double result = 0;
                switch (input.Symbol)
                {
                    case '+':
                        result = expression.Addition();
                        break;
                    case '-':
                        result = expression.Substraction();
                        break;
                    case '*':
                        result = expression.Multiplication();
                        break;
                    case '/':
                        result = expression.Division();
                        break;
                }
        //    }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
