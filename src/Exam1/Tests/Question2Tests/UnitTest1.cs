using NUnit.Framework;
using Question2;
using System.Collections;
using System.Linq;

namespace Question2Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(4550, new int[] { 2, 5, 7, 13 })]
        [TestCase(144, new int[] { 2, 3 })]
        [TestCase(348040, new int[] { 2, 5, 7, 11, 113 })]
        [TestCase(271, new int[] { 271 })]
        [TestCase(1, new int[] { })]
        public void Test1(int number, int[] expected)
        {
            Assert.True(Enumerable.SequenceEqual(expected, 
                FactorCalculator.FindFactors(number)));
        }
    }
}