using FactoryMethodPattern.Computers;
using FactoryMethodPattern.Factories;
using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Creators
{
    public class GameComputerCreator : ComputerCreator
    {
        public GameComputerCreator(string name) : base(name)
        {
        }

        public override IComputer CreateComputer()
        {
            return new GameComputer(Name);
        }
    }
}