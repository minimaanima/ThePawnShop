namespace PawnShop.CommunicationService.Commands
{
    using Interfaces;

    public abstract class Command : ICommand
    {
        protected Command(string[] data)
        {
            this.Data = data;
            this.GetParameters = 0;
        }

        public abstract ICommand Create(string[] data);

        public abstract string Execute();

        protected string[] Data { get; set; }

        public int GetParameters { get; protected set; }
    }
}
