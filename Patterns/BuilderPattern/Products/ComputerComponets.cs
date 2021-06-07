using BuilderPattern.Components;

namespace BuilderPattern.Products
{
    public abstract class ComputerComponents
    {
        public Cpu Cpu { get; set; }
        
        public MotherCard MotherCard { get; set; }
        
        public Ram Ram { get; set; }
        
        public StorageDevice StorageDevice { get; set; }
        
        public VideoCard VideoCard { get; set; }
    }
}