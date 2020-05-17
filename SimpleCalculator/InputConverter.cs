using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double convertInputToNumeric(string argTextInput)
        {
            double convertedNumber = 0.0;

            if (!double.TryParse(argTextInput, out convertedNumber))
            {
                throw new ArgumentException("Expected a numeric value.");
            }

            return convertedNumber;
        }
    }
}