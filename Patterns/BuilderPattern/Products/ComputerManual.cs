namespace BuilderPattern.Products
{
    public class ComputerManual
    {
        public string DescriptionCpu { get; set; }
        
        public string DescriptionMotherCard { get; set; }
        
        public string DescriptionRam { get; set; }
        
        public string DescriptionStorageDevice { get; set; }
        
        public string DescriptionVideoCard { get; set; }
        
        public override string ToString()
        {
            return  "Description:\n" +
                   $"Cpu: {DescriptionCpu}\n" +
                   $"MotherCard: {DescriptionMotherCard}\n" +
                   $"Ram: {DescriptionRam}\n" +
                   $"StorageDevice: {DescriptionStorageDevice}\n" +
                   $"VideoCard: {DescriptionVideoCard}\n";
        }
    }
}