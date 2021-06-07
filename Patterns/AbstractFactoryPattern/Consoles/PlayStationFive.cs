using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Consoles
{
    public class PlayStationFive : IPlayStation
    {
        public string GetPlayStationName()
        {
            return "Name: PlayStationFive";
        }

        public string GetGodOfWar()
        {
            return "The game works at high even with RTX (if he is there)";
        }
    }
}