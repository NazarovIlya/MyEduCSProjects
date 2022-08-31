using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proj0004_Calculator
{
    internal class DoAction : Expression
    {
        public DoAction(double first, double second, char symbol)
        {
            First = first;
            Second = second;
            Symbol = symbol;
        }
        public double DoAction()
        {
            double result = 0;
            switch (Symbol)
            {
                case '+':
                    result = Addition();
                    break;
                case '-':
                    result = Substraction();
                    break;
                case '*':
                    result = Multiplication();
                    break;
                case '/':
                    result = Division();
                    break;
            }
            return result;
        }

    }
}
