using FizzBuzz.Handlers;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzUnitTest1
    {
        private readonly Operations _ops;

        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            bool result = _ops.is_prime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
    }

}