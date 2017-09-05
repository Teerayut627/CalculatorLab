using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    class RPNCalculatorEngine : CalculatorEngine
    {
        public new string Process(string str)
        {
            List<string> parts = str.Split(' ').ToList<string>();
            string result = "";
            Stack<string> rpnStack = new Stack<string>();
            foreach(string i in parts)
            {
                if (isNumber(i))
                {
                    rpnStack.Push(i);
                }
                if (isOperator(i))
                {
                    string secondOperand = rpnStack.Pop();
                    string firstOperand = rpnStack.Pop();
                    result = calculate(i,firstOperand,secondOperand);
                    rpnStack.Push(result);
                }
            }
            return result;
        }
    }
}
