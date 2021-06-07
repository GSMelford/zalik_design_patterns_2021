using BuilderPattern.Components;

namespace BuilderPattern.Interfaces
{
    public interface IBuilder
    {
        public IBuilder SetCpu(Cpu cpu);

        public IBuilder SetMotherCard(MotherCard motherCard);

        public IBuilder SetRam(Ram ram);
        
        public IBuilder SetVideoCard(VideoCard videoCard);

        public IBuilder SetStorageDevice(StorageDevice storageDevice);
    }
}