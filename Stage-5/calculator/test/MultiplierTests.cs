namespace calculator.test
{
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class MultiplierTests
    {
        [Test]
        public void ItShoulMultiplyTwoNumbers()
        {
            var number1 = 7;
            var number2 = 10;
            var expectedResult = 70;

            var target = new Multiplier();
            var actualResult = target.Multiply(number1, number2);

            actualResult.Should().Be(expectedResult);
        }
    }
}