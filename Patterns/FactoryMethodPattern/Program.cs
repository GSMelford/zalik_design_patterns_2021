using System;
using FactoryMethodPattern.Creators;
using FactoryMethodPattern.Factories;

namespace FactoryMethodPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            TestComputer(new ClassicComputerCreator("Bad Computer"));
            TestComputer(new GameComputerCreator("Super Gaming Computer"));
        }

        private static void TestComputer(ComputerCreator creator)
        {
            Console.WriteLine(creator.TryPlay());
        }
    }
}