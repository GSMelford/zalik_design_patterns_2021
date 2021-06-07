using BuilderPattern.Components;
using BuilderPattern.Interfaces;
using BuilderPattern.Products;

namespace BuilderPattern.Builders
{
    public class ComputerBuilder : IBuilder
    {
        private readonly Computer _computer = new Computer();

        public IBuilder SetCpu(Cpu cpu)
        {
            _computer.Cpu = cpu;
            return this;
        }

        public IBuilder SetMotherCard(MotherCard motherCard)
        {
            _computer.MotherCard = motherCard;
            return this;
        }

        public IBuilder SetRam(Ram ram)
        {
            _computer.Ram = ram;
            return this;
        }

        public IBuilder SetVideoCard(VideoCard videoCard)
        {
            _computer.VideoCard = videoCard;
            return this;
        }

        public IBuilder SetStorageDevice(StorageDevice storageDevice)
        {
            _computer.StorageDevice = storageDevice;
            return this;
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }
}