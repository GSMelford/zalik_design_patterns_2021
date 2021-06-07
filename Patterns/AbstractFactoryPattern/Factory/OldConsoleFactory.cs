using AbstractFactoryPattern.Consoles;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Factory
{
    public class OldConsoleFactory : IGameConsoleFactory
    {
        public INintendo CreateNintendo()
        {
            return new NintendoBoy();
        }

        public IPlayStation CreatePlayStation()
        {
            return new PlayStationFour();
        }
    }
}