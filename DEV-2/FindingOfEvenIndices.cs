using System;
using System.Text;

namespace DEV_2
{
    /// <summary>
    /// This class looks for all even indexes in a string.
    /// </summary>
    class FindingOfEvenIndices
    {
        private string entryString;

        public FindingOfEvenIndices(string value)
        {
            entryString = value;
        }

        /// <summary>
        /// This method removes all odd indexes and displays even.
        /// </summary>
        public void FindSequenceEvenIndex()
        {
            StringBuilder sb = new StringBuilder(entryString);

            for (int i = 1; i < sb.Length; i++)
            {
                sb.Remove(i, 1);
            }
            Console.WriteLine(sb);
        }
    }
}
