using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double resultVariable = 0.0;

            switch (argOperation.ToLower())
            {
               case "add" :
               case "+":
                   resultVariable = argFirstNumber + argSecondNumber;
                   break;
               case "subtract" :
               case "-":
                   resultVariable = argFirstNumber - argSecondNumber;
                   break;
               case "multiply" :
               case "*":
                   resultVariable = argFirstNumber * argSecondNumber;
                   break;
               case "divide" :
               case "/":
                   resultVariable = argFirstNumber / argSecondNumber;
                   break;
               default:
                   throw new InvalidOperationException("Specified operation is not recognized");
            }

            return resultVariable;
        }
    }
}