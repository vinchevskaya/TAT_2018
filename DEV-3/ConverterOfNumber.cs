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

        public ConverterOfNumber(int arg1, int arg2)
        {
            ConvertNumber = arg1;
            radix = arg2;
        }

        /// <summary>
        /// This method converts a decimal number to a new number system.
        /// </summary>
        /// <returns> Return a converted number in another number system. </returns>
        public string СonvertDeciminalNumber()
        {
            string result = "";
            int rest;
            int buffer = ConvertNumber;
            while (buffer > 0)
            {
                rest = buffer % radix;
                if (rest < 9)
                {
                    result += rest;
                }
                else
                {
                    char newRadix = (char)(65 + rest - 10);
                    result += newRadix;
                }
                buffer = buffer / radix;
            }
            return (Сonverse(result));
        }

        /// <summary>
        /// This method returns a value.
        /// </summary>
        /// <param name="CounterString">return string, taken from another method</param>
        /// <returns>returns the reverse-converted string</returns>
        private string Сonverse(string CounterString)
        {
            char[] ConvertString = CounterString.ToCharArray();
            Array.Reverse(ConvertString);
            return new string(ConvertString);
        }
    }
}

