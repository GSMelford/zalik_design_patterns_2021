namespace BuilderPattern.Components
{
    public class Cpu : Component
    {
        public double Gigahertz { get; }
        
        public int Cores { get; }

        public Cpu(string name, double gigahertz, int cores) 
            : base(name)
        {
            Gigahertz = gigahertz;
            Cores = cores;
        }
    }
}