using System;
using System.Text;

namespace DEV_3
{
    /// <summary>
    /// This class converts a decimal number to another number system from 2 to 20.
    /// </summary>
    class ConverterOfNumber
    {
        int ConvertNumber;
        int radix;
        
        /// <summary>
        /// Constructor instance.
        /// </summary>
        public ConverterOfNumber(int decimalValues, int radixNumber)
        {
            ConvertNumber = decimalValues;
            radix = radixNumber;
        }

        /// <summary>
        /// This method converts a decimal number to a new number system.
        /// </summary>
        /// <returns>Return a converted number in another number system.</returns>
        public string СonvertDeciminalNumber()
        {
            string resultNamber = "";
            int rest;
            int decimalNumber = ConvertNumber;

            while (decimalNumber > 0)
            {
                rest = decimalNumber % radix;
                if (rest < 9)
                {
                    resultNamber += rest;
                }
                else
                {
                    char newRadixNumber = (char)('A' + rest - 10);
                    resultNamber += newRadixNumber;
                }
                decimalNumber /= radix;
            }
            return (Сonverse(resultNamber));
        }

        /// <summary>
        /// This method returns a value.
        /// </summary>
        /// <returns>Converted string.</returns>
        private string Сonverse(string CounterString)
        {
            char[] ConvertString = CounterString.ToCharArray();
            Array.Reverse(ConvertString);
            return new string(ConvertString);
        }
    }
}
