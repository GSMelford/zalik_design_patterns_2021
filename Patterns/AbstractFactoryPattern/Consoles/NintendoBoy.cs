using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Consoles
{
    public class NintendoBoy : INintendo
    {
        public string GetNintendoName()
        {
            return "Name: NintendoBoy";
        }

        public string GetSomethingFunnyWithMario()
        {
            return "Game: Mario";
        }
    }
}