using System;
using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Михайло запускає фабрику нових консолей:\n");
            CheckConsoles(new NewConsoleFactory());
            
            Console.WriteLine("Михайло запускає фабрику старих консолей:\n");
            CheckConsoles(new OldConsoleFactory());
        }
        
        private static void CheckConsoles(IGameConsoleFactory console)
        {
            INintendo nintendo = console.CreateNintendo();
            IPlayStation playStation = console.CreatePlayStation();

            Console.WriteLine(nintendo.GetNintendoName() + "\n" + nintendo.GetSomethingFunnyWithMario());
            Console.WriteLine(playStation.GetPlayStationName() + "\n" + playStation.GetGodOfWar());
        }
    }
}