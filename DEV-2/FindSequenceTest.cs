using System;
using Xunit;
using DEV_2;

namespace DEV_2.Test
{
    public class FindSequenceTest
    {
        [Fact]
        public void NullStringTest()
        {
            //Arrange
            string str = String.Empty;
            //Act
            StringBuilder sb = new StringBuilder();
            //Assert
            Assert.Null(sb.FindSequenceEvenIndex(str));
        }
        [Fact]
        public void EvenIndexTest()
        {
            //Arrange
            string original = "Hello";
            string expected = "Hlo";
            //Act
            StringBuilder sb = new StringBuilder();
            //Assert
            Assert.Equal(sb.FindSequenceEvenIndex(original), expected);

        }
    }
}