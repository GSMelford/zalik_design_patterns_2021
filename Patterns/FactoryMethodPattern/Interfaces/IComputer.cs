namespace FactoryMethodPattern.Interfaces
{
    public interface IComputer
    {
        public string Name { get; set; }
        public string Play();
    }
}