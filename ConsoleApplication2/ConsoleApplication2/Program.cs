using System;
using Microsoft.Practices.Unity;
using NUnit.Framework;
using Rhino.Mocks;

namespace ConsoleApplication2
{
    public class Program
    {
        private static Calculator _calculator;

        public static void Main(string[] args)
        {
            //Bootstrap();
            BootstrapWithUnity();
            Console.WriteLine("Please enter something useful");
            var myString = Console.ReadLine();
            Console.WriteLine(_calculator.CalculatorLogic(myString));
            Console.ReadLine();

        }

        private static void Bootstrap()
        {
            Multiplier mul = new Multiplier();
            Subtractor sub = new Subtractor();
            Additron add = new Additron();
            StringToArrayYay str = new StringToArrayYay();
            _calculator = new Calculator(mul, sub, add, str);
        }

        private static void BootstrapWithUnity()
        {
            var container = new UnityContainer();
            container.RegisterType<Calculator>();
            container.RegisterType<IMultiplier, Multiplier>();
            container.RegisterType<ISubtractor, Subtractor>();
            container.RegisterType<IAdditron, Additron>();
            container.RegisterType<IStringToArrayYay, StringToArrayYay>();
            _calculator = container.Resolve<Calculator>();
        }
    }

    public class Calculator
    {
        private readonly IMultiplier _multiplier;
        private readonly ISubtractor _subtractor;
        private readonly IAdditron _additron;
        private readonly IStringToArrayYay _stringToArrayYay;

        public Calculator(IMultiplier multiplier, ISubtractor subtractor, IAdditron additron, IStringToArrayYay stringToArrayYay)
        {
            _multiplier = multiplier;
            _subtractor = subtractor;
            _additron = additron;
            _stringToArrayYay = stringToArrayYay;
        }

        public decimal CalculatorLogic(string text)
        {
            var args = _stringToArrayYay.TurnIntoStringArray(text);
            var result = 0m;
            switch (args[1])
            {
                case "x":
                    result = _multiplier.Mulitply(args);
                    break;
                case "+":
                    result = _additron.Add(args);
                    break;
                case "-":
                    result = _subtractor.Subtract(args);
                    break;
            }

            return result;
        }
    }

    [TestFixture]
    public class CalculatorTest
    {
        private IMultiplier _multiplier;
        private ISubtractor _subtractor;
        private IAdditron _additron;
        private IStringToArrayYay _stringToArrayYay;
        [Test]
        public void it_calls_a_multiplier()
        {
            var testString = "4 x 4";
            _multiplier = MockRepository.GenerateMock<IMultiplier>();
            _subtractor = MockRepository.GenerateStub<ISubtractor>();
            _additron = MockRepository.GenerateStub<IAdditron>();
            _stringToArrayYay = MockRepository.GenerateMock<IStringToArrayYay>();
            _stringToArrayYay.Stub(x => x.TurnIntoStringArray(testString)).Return(new [] { "4", "x", "4"});
            var calculator = new Calculator(_multiplier, _subtractor, _additron, _stringToArrayYay);
            calculator.CalculatorLogic(testString);
            _multiplier.AssertWasCalled(x => x.Mulitply(new []{"4", "x", "4"}));
        }
    }
}
