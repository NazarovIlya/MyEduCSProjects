using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proj0004_Calculator
{
    internal class DoAction
    {
        private readonly Expression _expression;
        public DoAction(double first, double second, char symbol)
        {
            _expression = new Expression(first, second, symbol);
        }
        public double SwitchAction()
        {
            double result = 0;
            switch (_expression.Symbol)
            {
                case '+':
                    result = _expression.Addition();
                    break;
                case '-':
                    result = _expression.Substraction();
                    break;
                case '*':
                    result = _expression.Multiplication();
                    break;
                case '/':
                    result = _expression.Division();
                    break;
            }
            return result;
        }

    }
}
