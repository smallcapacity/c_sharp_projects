using System;

namespace SimpleCalculator
{
    public class StringToIntConverter
    {
        public int convert(string input)
        {
            try
            {
                int convertedNumber;
                bool isConvertedSuccessfully = int.TryParse(input, out convertedNumber);

                if (!isConvertedSuccessfully)
                {
                   // throw new Exception("Conversion was not successful");
                   Console.WriteLine("not successful");
                }

                return convertedNumber;
            }
            catch (Exception ex)
            {
                throw new Exception("new message", ex);
            }
        }
    }
}