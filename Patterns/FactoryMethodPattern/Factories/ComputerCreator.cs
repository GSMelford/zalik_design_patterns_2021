using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Factories
{
    public abstract class ComputerCreator
    {
        public string Name { get;}
        
        public ComputerCreator (string name)
        { 
            Name = name; 
        }
        
        public abstract IComputer CreateComputer();

        public string TryPlay()
        {
            IComputer computer = CreateComputer();

            return "We are trying to play on a computer.\n Result: " + computer.Play();
        }
    }
}