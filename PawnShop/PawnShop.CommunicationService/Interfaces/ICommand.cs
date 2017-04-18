namespace PawnShop.CommunicationService.Interfaces
{
    public interface ICommand
    {
        int GetParameters { get; }

        ICommand Create(string[] data);

        string Execute();
    }
}
