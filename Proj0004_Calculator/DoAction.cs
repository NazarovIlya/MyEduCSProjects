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
        public DoAction()
        {
            _expression = new Expression();
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
        public double DoSomeAction(string[] numberArray)
        {
            _expression.First = Convert.ToDouble(numberArray[0]);
            int i = 0;
            while (i < numberArray.Length - 1)
            {

                _expression.Symbol = Convert.ToChar(numberArray[i + 1]);
                _expression.Second = Convert.ToDouble(numberArray[i + 2]);
                _expression.First = SwitchAction();
                i += 2;
            }
            return _expression.First;
        }
        

    }
}
