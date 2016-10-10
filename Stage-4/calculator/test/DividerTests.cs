using FluentAssertions;
using NUnit.Framework;

namespace calculator.test
{
    [TestFixture]
    public class DividerTests
    {
        [Test]
        public void ItShouldAddTwoNumbers()
        {
            var number1 = 16;
            var number2 = 8;
            var expectedResult = 2;

            var target = new Divider();
            var actualResult = target.Divide(number1, number2);

            actualResult.Should().Be(expectedResult);
        }
    }
}