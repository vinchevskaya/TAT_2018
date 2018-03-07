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
        public ConverterOfNumber(int arg1, int arg2)
        {
            ConvertNumber = arg1;
            radix = arg2;
        }

        /// <summary>
        /// This method converts a decimal number to a new number system.
        /// </summary>
        /// <returns>Return a converted number in another number system.</returns>
        public string СonvertDeciminalNumber()
        {
            string result = "";
            int rest;
            int number = ConvertNumber;
            while (number > 0)
            {
                rest = number % radix;
                if (rest <= 9)
                {
                    result += rest;
                }
                else
                {
                    char newRadix = (char)(55 + rest);
                    result += newRadix;
                }
                number /= radix;
            }
            return (Сonverse(result));
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
