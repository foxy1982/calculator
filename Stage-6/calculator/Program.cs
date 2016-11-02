namespace calculator
{
    using Microsoft.Practices.Unity;
    using System;

    internal class Program
    {
        private static Calculator _calculator;

        private static IUnityContainer _container;

        private static void Main(string[] args)
        {
            Bootstrap();
            Console.WriteLine("Enter a query (e.g. 5 x 8):");
            var myString = Console.ReadLine();
            Console.WriteLine(_calculator.Calculate(myString));
            Console.ReadLine();
        }

        private static void Bootstrap()
        {
            _container = new UnityContainer();
            _container.RegisterType<IQueryParser, QueryParser>();
            _container.RegisterType<IMultiplier, Multiplier>();
            _container.RegisterType<IAdder, Adder>();
            _container.RegisterType<ISubtractor, Subtractor>();
            _container.RegisterType<IDivider, Divider>();
            _container.RegisterType<Calculator>();

            _calculator = _container.Resolve<Calculator>();
        }
    }
}