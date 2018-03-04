using System;
using System.Text;

namespace DEV_2
{
    /// <summary>
    /// The entry point to the program.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            FindingOfEvenIndices entryString = new FindingOfEvenIndices(Console.ReadLine());
            entryString.FindSequenceEvenIndex();
        }  
    }  
}
