
namespace Task_2
{

    public class CalculatorAreaSquare
    {
        public int A { get; set; }
        public int B { get; set; }

        public CalculatorAreaSquare(int a, int b)
        {
            A = a;
            B = b;
        }
        /// <param name="a">width of a rectangle</param>
        /// <param name="b">length of a rectangle</param>
        /// <returns></returns>
        public int Calculator(int a, int b)
        {
            int s;
            s = a * b;
            return s;
        }
    }
}

