namespace AbstractFactoryPattern.Interfaces
{
    public interface IGameConsoleFactory
    {
        INintendo CreateNintendo();

        IPlayStation  CreatePlayStation();
    }
}