namespace calculator.test
{
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class SubtractorTests
    {
        [Test]
        public void ItShouldSubtractTwoNumbers()
        {
            var number1 = 45;
            var number2 = 10;
            var expectedResult = 35;

            var target = new Subtractor();
            var actualResult = target.Subtract(number1, number2);

            actualResult.Should().Be(expectedResult);
        }
    }
}