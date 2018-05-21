using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Task_2;

namespace Task_2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 2;
            int b = 7;
            int s = 14;
            CalculatorAreaSquare calculator = new CalculatorAreaSquare(a, b);
            Assert.AreEqual(s,calculator.Calculator(a, b));
        }
    }
}
