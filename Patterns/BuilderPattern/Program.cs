using System;
using BuilderPattern.Builders;
using BuilderPattern.Components;
using BuilderPattern.Consultants;
using BuilderPattern.Products;

namespace BuilderPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            ComputerBuilder computerBuilder = new ComputerBuilder();
            ComputerManualBuilder computerManualBuilder = new ComputerManualBuilder();
            
            Consultant consultant = new Consultant {Builder = computerBuilder};
            
            Console.WriteLine("Building a super computer:");
            consultant.BuildSuperMegaDuperComputer();
            Console.WriteLine(computerBuilder.GetComputer().ToString());
            
            Console.WriteLine("Building a classic computer:");
            consultant.BuildClassicComputer();
            Console.WriteLine(computerBuilder.GetComputer().ToString());
            
            Console.WriteLine("Building a manual for classic computer:");
            consultant.Builder = computerManualBuilder;
            consultant.BuildClassicComputer();
            Console.WriteLine(computerManualBuilder.GetComputerManual().ToString());

            CreateComputer();
        }

        private static void CreateComputer()
        {
            ComputerBuilder computerBuilder = new ComputerBuilder();
            computerBuilder
                .SetCpu(new Cpu("Cpu1", 1.8, 2))
                .SetRam(new Ram("Ram", 3))
                .SetMotherCard(new MotherCard("NoName", 3));

            Computer computer = computerBuilder.GetComputer();
            Console.WriteLine(computer.ToString());
            computer.TurnOnOrOff();
            
            computer.DoHomework();
            computer.PlayGame();
        }
    }
}