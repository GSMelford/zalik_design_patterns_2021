using AbstractFactoryPattern.Consoles;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Factory
{
    public class NewConsoleFactory : IGameConsoleFactory
    {
        public INintendo CreateNintendo()
        {
            return new NintendoSwitch();
        }

        public IPlayStation CreatePlayStation()
        {
            return new PlayStationFive();
        }
    }
}