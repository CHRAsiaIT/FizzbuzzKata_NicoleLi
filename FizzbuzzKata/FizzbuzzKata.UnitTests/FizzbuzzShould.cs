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
    }
}
