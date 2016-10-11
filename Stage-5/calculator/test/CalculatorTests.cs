namespace calculator.test
{
    using NUnit.Framework;
    using Rhino.Mocks;

    [TestFixture]
    public class CalculatorTests
    {
        [SetUp]
        public void SetUp()
        {
            _mockQueryParser = MockRepository.GenerateMock<IQueryParser>();
            _mockAdder = MockRepository.GenerateMock<IAdder>();
            _mockDivider = MockRepository.GenerateMock<IDivider>();
            _mockMultiplier = MockRepository.GenerateMock<IMultiplier>();
            _mockSubtractor = MockRepository.GenerateMock<ISubtractor>();
            _calculator = new Calculator(_mockQueryParser, _mockMultiplier, _mockAdder, _mockSubtractor, _mockDivider);
        }

        private Calculator _calculator;

        private IQueryParser _mockQueryParser;
        private IAdder _mockAdder;
        private IDivider _mockDivider;
        private IMultiplier _mockMultiplier;
        private ISubtractor _mockSubtractor;

        [Test]
        public void ItShouldCallAdderWhenGivenPlusSymbol()
        {
            _mockQueryParser.Stub(x => x.Parse(Arg<string>.Is.Anything)).Return(new Calculation("+", 2, 3));

            _mockAdder.Expect(x => x.Add(Arg.Is(2), Arg.Is(3))).Return(0);
            _calculator.Calculate("");

            _mockAdder.VerifyAllExpectations();
            _mockDivider.VerifyAllExpectations();
            _mockMultiplier.VerifyAllExpectations();
            _mockSubtractor.VerifyAllExpectations();
        }

        [Test]
        public void ItShouldCallDividerWhenGivenSlashSymbol()
        {
            _mockQueryParser.Stub(x => x.Parse(Arg<string>.Is.Anything)).Return(new Calculation("/", 2, 3));

            _mockDivider.Expect(x => x.Divide(Arg.Is(2), Arg.Is(3))).Return(0);
            _calculator.Calculate("");

            _mockAdder.VerifyAllExpectations();
            _mockDivider.VerifyAllExpectations();
            _mockMultiplier.VerifyAllExpectations();
            _mockSubtractor.VerifyAllExpectations();
        }

        [Test]
        public void ItShouldCallMultiplierWhenGivenXSymbol()
        {
            _mockQueryParser.Stub(x => x.Parse(Arg<string>.Is.Anything)).Return(new Calculation("x", 2, 3));

            _mockMultiplier.Expect(x => x.Multiply(Arg.Is(2), Arg.Is(3))).Return(0);
            _calculator.Calculate("");

            _mockAdder.VerifyAllExpectations();
            _mockDivider.VerifyAllExpectations();
            _mockMultiplier.VerifyAllExpectations();
            _mockSubtractor.VerifyAllExpectations();
        }

        [Test]
        public void ItShouldCallSubtractorWhenGivenHyphenSymbol()
        {
            _mockQueryParser.Stub(x => x.Parse(Arg<string>.Is.Anything)).Return(new Calculation("-", 2, 3));

            _mockSubtractor.Expect(x => x.Subtract(Arg.Is(2), Arg.Is(3))).Return(0);
            _calculator.Calculate("");

            _mockAdder.VerifyAllExpectations();
            _mockDivider.VerifyAllExpectations();
            _mockMultiplier.VerifyAllExpectations();
            _mockSubtractor.VerifyAllExpectations();
        }

        [Test]
        public void ItShouldPassInputToQueryParser()
        {
            var inputText = "2 x 3";

            _mockQueryParser.Expect(x => x.Parse(Arg.Is(inputText))).Return(new Calculation("x", 2, 3));

            _calculator.Calculate(inputText);

            _mockQueryParser.VerifyAllExpectations();
        }
    }
}