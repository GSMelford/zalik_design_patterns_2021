using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Consoles
{
    public class NintendoSwitch : INintendo
    {
        public string GetNintendoName()
        {
            return "Name: NintendoSwitch";
        }

        public string GetSomethingFunnyWithMario()
        {
            return "Game: MarioCar";
        }
    }
}