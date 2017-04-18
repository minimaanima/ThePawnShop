using System;
using System.Linq;
using PawnShop.CommunicationService.Interfaces;
using PawnShop.CommunicationService.Utilities;
using PawnShop.Data;

namespace PawnShop.CommunicationService.Commands
{
    public class LoginCommand : Command
    {
        public LoginCommand(string[] data) : base(data)
        {
            this.GetParameters = 2;
        }

        public override ICommand Create(string[] data)
        {
            return new LoginCommand(data);
        }

        public override string Execute()
        {
            var username = Data[1];
            var password = Data[2];

            LogUser(username, password);

            return string.Format($"User {username} successfully logged in!");
        }

        private static void LogUser(string username, string password)
        {
            using (var context = new PawnShopContext())
            {
                var checkUser = context.Users.Select(u => u.Credentials).Any(c => c.Email == username && c.Password == password);
                var checkPassword = context.Users.Select(u => u.Credentials)
                    .Where(c => c.Email == username)
                    .Select(c=> c.Password)
                    .FirstOrDefault();

                if (!checkUser || checkPassword != password)
                {
                    throw new ArgumentException("Invalid username or password");
                }

                if (LoginUser.User != null)
                {
                    throw new ArgumentException("You should log out first");
                }

                var userId = context.Credentials.FirstOrDefault(c => c.Email == username).Id;
                var user = context.Users.Find(userId);
                LoginUser.User = user;
            }
        }
    }
}
