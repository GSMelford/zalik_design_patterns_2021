using BuilderPattern.Components;
using BuilderPattern.Interfaces;
using BuilderPattern.Products;

namespace BuilderPattern.Builders
{
    public class ComputerManualBuilder : IBuilder
    {
        private readonly ComputerManual _computerManual = new ComputerManual();
        
        public IBuilder SetCpu(Cpu cpu)
        {
            _computerManual.DescriptionCpu = cpu.Name;
            return this;
        }

        public IBuilder SetMotherCard(MotherCard motherCard)
        {
            _computerManual.DescriptionMotherCard = motherCard.Name;
            return this;
        }

        public IBuilder SetRam(Ram ram)
        {
            _computerManual.DescriptionRam = ram.Name;
            return this;
        }

        public IBuilder SetVideoCard(VideoCard videoCard)
        {
            _computerManual.DescriptionVideoCard = videoCard.Name;
            return this;
        }

        public IBuilder SetStorageDevice(StorageDevice storageDevice)
        {
            _computerManual.DescriptionStorageDevice = storageDevice.Name;
            return this;
        }

        public ComputerManual GetComputerManual()
        {
            return _computerManual;
        }
    }
}