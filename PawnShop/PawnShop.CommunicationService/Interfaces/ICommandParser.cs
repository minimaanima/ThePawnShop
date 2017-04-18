namespace PawnShop.CommunicationService.Interfaces
{
    public interface ICommandParser
    {
        ICommand ParseCommand(string[] data);

        void AddCommand(string command, ICommand newCommand);
    }
}
