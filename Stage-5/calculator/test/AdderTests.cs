namespace calculator.test
{
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class AdderTests
    {
        [Test]
        public void ItShouldAddTwoNumbers()
        {
            var number1 = 7;
            var number2 = 10;
            var expectedResult = 17;

            var target = new Adder();
            var actualResult = target.Add(number1, number2);

            actualResult.Should().Be(expectedResult);
        }
    }
}