namespace BuilderPattern.Components
{
    public class VideoCard : Component
    {
        public int AmountVideoMemory { get; }

        public VideoCard(string name, int amountVideoMemory) 
            : base(name)
        {
            AmountVideoMemory = amountVideoMemory;
        }
    }
}