using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Consoles
{
    public class PlayStationFour : IPlayStation
    {
        public string GetPlayStationName()
        {
            return "Name: PlayStationFour";
        }

        public string GetGodOfWar()
        {
            return "The game runs on medium";
        }
    }
}