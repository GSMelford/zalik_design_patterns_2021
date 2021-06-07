using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Computers
{
    public class ClassicComputer : IComputer
    {
        public string Name { get; set; }
 
        public ClassicComputer(string name)
        {
            Name = name;
        }
        
        public string Play()
        {
            return $"We were unable to play games on this {Name}. It broke ...";
        }
    }
}