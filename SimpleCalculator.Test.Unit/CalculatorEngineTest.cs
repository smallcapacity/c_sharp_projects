using System;
using NUnit.Framework;

namespace SimpleCalculator.Test.Unit
{
    [TestFixture]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();
        
        [Test]
        public void AddsTwoNumbersAndReturnsValidResultsForNonSymbolOperations()
        {
            int numberOne = 1;
            int numberTwo = 2;
            string operation = "add";
            double result = _calculatorEngine.calculate(operation, numberOne, numberTwo);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void AddsTwoNumbersAndReturnsValidResultsForSymbolOperations()
        {
            int numberOne = 1;
            int numberTwo = 2;
            string operation = "+";
            double result = _calculatorEngine.calculate(operation, numberOne, numberTwo);
            Assert.AreEqual(3, result);
        }
    }
}