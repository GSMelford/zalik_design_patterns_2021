namespace BuilderPattern.Interfaces
{
    public interface IComputer
    {
        public bool TurnOnOrOff();

        public void PlayGame();

        public void DoHomework();

        public void Display(string str);
    }
}