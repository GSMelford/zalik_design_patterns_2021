using FactoryMethodPattern.Computers;
using FactoryMethodPattern.Factories;
using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Creators
{
    public class ClassicComputerCreator : ComputerCreator
    {
        public ClassicComputerCreator(string name) : base(name)
        {
        }

        public override IComputer CreateComputer()
        {
            return new ClassicComputer(Name);
        }
    }
}