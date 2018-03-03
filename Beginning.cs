using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    class Entrypoint
    {
        /// <summary>
        /// This class deduced the number of characters from the longest repetition
        /// </summary>
        static void Main(string[] symbols)
        {
            if (symbols.Length == 1)
            {
                Workwithstring String = new Workwithstring(symbols[0]);
                Console.WriteLine(String.maxRepetition());
            }
            else
            {
                Console.WriteLine("wrong view");
            }
        }
    }
}



