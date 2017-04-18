namespace PawnShop.CommunicationService.Core
{
    using Interfaces;
    using System;

    public class CommandDispatcher : ICommandDispatcher
    {
        private ICommand command;
        private readonly ICommandParser parser;

        public CommandDispatcher()
        {
            this.parser = new CommandParser();
        }

        public string DispatchCommand(string[] commandParameters)
        {
            command = parser.ParseCommand(commandParameters);

            if (commandParameters.Length < command.GetParameters)
            {
                throw new InvalidOperationException($"Command {commandParameters[0]} is not valid");
            }

            return command.Execute();
        }

    }
}
