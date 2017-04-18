namespace PawnShop.CommunicationService.Interfaces
{
    public interface ICommandDispatcher
    {
        string DispatchCommand(string[] commandParameters);
    }
}
