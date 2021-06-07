namespace BuilderPattern.Components
{
    public abstract class Component
    {
        public string Name { get;}

        protected Component(string name)
        {
            Name = name;
        }
    }
}