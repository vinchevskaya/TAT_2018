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
            FindingOfEvenIndices inputString = new FindingOfEvenIndices(Console.ReadLine());
            inputString.FindSequenceEvenIndex();
        }  
    }  
}
