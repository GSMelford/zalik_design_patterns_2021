using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Computers
{
    public class GameComputer : IComputer
    {
        public string Name { get; set; }
 
        public GameComputer(string name)
        {
            Name = name;
        }
        
        public string Play()
        {
            return $"We were able to play different games on this {Name}!";
        }
    }
}