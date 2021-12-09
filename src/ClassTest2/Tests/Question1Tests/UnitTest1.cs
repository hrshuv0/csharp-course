using NUnit.Framework;
using Question1;

namespace Question1Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Hello Bangladesh", "hsedalgnaB olleH")]
        [TestCase("There is a dog in the pond.", ".dnop eht ni god a si erehT")]
        [TestCase("1,2,3 Let's Start!", "!tratS s'teL 3,2,1")]
        public void Test1(string text, string expected)
        {
            var result = Utility.Reverse(text);
            Assert.AreEqual(expected, result);
        }
    }
}