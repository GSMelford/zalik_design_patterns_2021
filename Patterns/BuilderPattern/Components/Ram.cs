namespace BuilderPattern.Components
{
    public class Ram : Component
    {
        public int NumberPlanks { get; }

        public Ram(string name, int numberPlanks)
            : base(name)
        {
            NumberPlanks = numberPlanks;
        }
    }
}