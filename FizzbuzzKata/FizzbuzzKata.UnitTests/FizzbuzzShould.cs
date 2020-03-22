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

        [TestMethod]
        public void Should_ReturnBuzz_WhenEnterFive()
        {
            Assert.AreEqual("Buzz", _fizzbuzz.FizzbuzzMethod(5));
        }

        [TestMethod]
        public void Should_ReturnBuzz_WhenEnterTen()
        {
            Assert.AreEqual("Buzz", _fizzbuzz.FizzbuzzMethod(10));
        }

        [TestMethod]
        public void Should_ReturnFizzBuzz_WhenEnterFifteen()
        {
            Assert.AreEqual("FizzBuzz", _fizzbuzz.FizzbuzzMethod(15));
        }

        [TestMethod]
        public void Should_ReturnBuzz_WhenEnterThirty()
        {
            Assert.AreEqual("FizzBuzz", _fizzbuzz.FizzbuzzMethod(30));
        }

        [TestMethod]
        public void Should_ReturnBuzz_WhenEnterOneHundred()
        {
            Assert.AreEqual("Buzz", _fizzbuzz.FizzbuzzMethod(100));
        }
    }
}
