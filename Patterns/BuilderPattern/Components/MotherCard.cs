namespace BuilderPattern.Components
{
    public class MotherCard : Component
    {
        public int RamSlots { get; }

        public MotherCard(string name, int ramSlots)
            :base(name)
        {
            RamSlots = ramSlots;
        }
    }
}