using System;

namespace DEV_1
{
    /// <summary>
    /// This class is for working with a string
    /// </summary>
    class WorkWithString
    {
        private string currentString;

        /// <summary>
        /// This method finds repetitions of the symbols in the string
        /// </summary>
        /// <returns> The maximum number of symbol repetitions per line </returns>
        public int MaxRepetition()
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
                 return maxLength;
                else
                {
                    firstSymbol = currentString[i];
                    count = 0;
                }
            }  
        }

        public WorkWithString(string ourString)
        {
            currentString = ourString;
        }
    }
}
