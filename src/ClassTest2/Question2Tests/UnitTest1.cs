using NUnit.Framework;
using Question2;

namespace Question2Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Madam", true)]
        [TestCase("DHJJDJHDJDJJDGDH", false)]
        [TestCase("aAaBbBbBaAa", true)]
        [TestCase("AAABbBbBaaa", true)]
        [TestCase("AAAbbb", false)]
        public void Test1(string text, bool expected)
        {
            Palindrome palindrome = new Palindrome();
            var result = palindrome.IsPalindrome(text);
            Assert.AreEqual(expected, result);
        }
    }
}