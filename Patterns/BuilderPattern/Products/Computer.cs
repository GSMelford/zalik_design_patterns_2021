using System;
using BuilderPattern.Interfaces;

namespace BuilderPattern.Products
{
    public class Computer : ComputerComponents, IComputer
    {
        private bool _switchedOn;

        private readonly Random _random;

        public Computer()
        {
            _random = new Random();
        }
        
        public bool TurnOnOrOff()
        {
            if (_switchedOn)
            {
                _switchedOn = false;
            }
            
            if (MotherCard != null)
            {
                if (Cpu != null)
                {
                    if (Ram != null)
                    {
                        if (StorageDevice != null)
                        {
                            if (VideoCard != null)
                            {
                                Display("The computer turned on.");
                                _switchedOn = true;
                                return true;
                            }
                            Display("Missing Video Card");
                            return false;
                        }
                        Display("Missing Storage Device");
                        return false;
                    }
                    Display("Missing Ram");
                    return false;
                }
                Display("Missing Cpu");
                return false;
            }
            Display("Missing MotherCard");
            return false;
        }

        public void PlayGame()
        {
            Display("Started to play...");
            
            Display(_random.Next(0, 1) == 0 ? "You lose" : "You win");
        }

        public void DoHomework()
        {
            Display("Doing my homework.");
        }

        public void Display(string message)
        {
            Console.WriteLine(message + "\n");
        }

        public override string ToString()
        {
            return  "Your Computer:\n" +
                   $"CPU: {Cpu?.Name} Gigahertz: {Cpu?.Gigahertz} Cores: {Cpu?.Cores}\n" +
                   $"MotherCard: {MotherCard?.Name} RamSlots: {MotherCard?.RamSlots}\n" +
                   $"Ram: {Ram?.Name} Numbers: {Ram?.NumberPlanks}\n" +
                   $"StorageDevice: {StorageDevice?.Name} Type: {StorageDevice?.Type}\n" +
                   $"VideoCard: {VideoCard?.Name} Memory: {VideoCard?.AmountVideoMemory} GB\n";
        }
    }
}