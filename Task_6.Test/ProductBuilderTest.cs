using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Task_6;

namespace Task_6.Test
{
    [TestFixture]
    public class ProductBuilderTest
    {
        [Test]
        public void SetTypeNullTest()
        {
            var product = new ProductBuilder();
            Assert.Throws<ArgumentException>(() => product.SetType(string.Empty));
        }
        [Test]
        public void SetNameNullTest()
        {
            var product = new ProductBuilder();
            Assert.Throws<ArgumentException>(() => product.SetName(string.Empty));
        }
    }
}
