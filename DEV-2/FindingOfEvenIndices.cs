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
            StringBuilder sb = new StringBuilder(entryString);

            for (int i = 1; i < sb.Length; i++)
            {
                sb.Remove(i, 1);
            }
            return sb.ToString();
        }
    }
}
