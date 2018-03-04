using System;
using System.Text;

namespace DEV_2
{
    /// <summary>
    /// This class looks for all even indexes in a string.
    /// </summary>
    class OnlyEvenElementsOfTheString
    {
        private string entryString;

        public OnlyEvenElementsOfTheString(string value)
        {
            entryString = value;
        }

        /// <summary>
        /// This method generates a string of characters with positive indices.
        /// </summary>
        public string FindSequenceEvenIndex()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < entryString.Length; i += 2)
            {
                sb.Append(entryString[i]);
            }
            return sb.ToString();
        }
    }
}
