namespace BuilderPattern.Components
{
    public class StorageDevice : Component
    {
        public string Type { get; }

        public StorageDevice(string name, string type) 
            : base(name)
        {
            Type = type;
        }
    }
}