using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzbuzzKata.UnitTests
{
    [TestClass]
    public class FizzbuzzShould
    {
        Fizzbuzz _fizzbuzz = new Fizzbuzz();

        [TestMethod]
        public void Should_ReturnOne_WhenEnterOne()
        {
            Assert.AreEqual("1", _fizzbuzz.FizzbuzzMethod(1));
        }

        [TestMethod]
        public void Should_ReturnTwo_WhenEnterTwo()
        {
            Assert.AreEqual("2", _fizzbuzz.FizzbuzzMethod(2));
        }

        [TestMethod]
        public void Should_ReturnFizz_WhenEnterThree()
        {
            Assert.AreEqual("Fizz", _fizzbuzz.FizzbuzzMethod(3));
        }

        [TestMethod]
        public void Should_ReturnFizz_WhenEnterSix()
        {
            Assert.AreEqual("Fizz", _fizzbuzz.FizzbuzzMethod(6));
        }
    }
}
