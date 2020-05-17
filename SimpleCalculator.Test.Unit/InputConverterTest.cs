using NUnit.Framework;

namespace SimpleCalculator.Test.Unit
{
    [TestFixture]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter(); 
        
        [Test]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.convertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }
        
        [Test]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "$";
            Assert.That(()=> _inputConverter.convertInputToNumeric(inputNumber), Throws.ArgumentException);
        }
    }
}