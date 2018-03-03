using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    /// <summary>
    /// This class is for working with a string
    /// </summary>
    class Workwithstring
    {
        private string currentString;

        /// <summary>
        /// This method finds repetitions of the symbols in the string
        /// </summary>
        /// <returns> The maximum number of symbol repetitions per line </returns>
        public int maxRepetition()
        {
            int maxLength = 0;
            int count = 0;
            char firstSymbol = currentString[0];
            for (int i = 0; i < currentString.Length; i++)
            {
                if (firstSymbol == currentString[i])
                {
                    count++;
                    if (maxLength < count)
                    {
                        maxLength = count;
                    }
                }
                else
                {
                    firstSymbol = currentString[i];
                    count = 0;
                }
            }
            return maxLength;
        }

        public Workwithstring(string ourString)
        {
            currentString = ourString;
        }
    }
}



