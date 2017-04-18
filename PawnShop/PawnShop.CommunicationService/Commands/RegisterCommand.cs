using System;
using System.Linq;
using PawnShop.CommunicationService.Interfaces;
using PawnShop.CommunicationService.Utilities;
using PawnShop.Data;
using PawnShop.Models.AuthorizationModels;
using PawnShop.Models.BusinessModels;

namespace PawnShop.CommunicationService.Commands
{
    public class RegisterCommand: Command
    {
        public RegisterCommand(string[] data) : base(data)
        {
            GetParameters = 4;
        }

        public override ICommand Create(string[] data)
        {
            return new RegisterCommand(data);
        }

        public override string Execute()
        {
            string officeName = Data[1];
            string username = Data[2];
            string password = Data[3];
            string confirmedPassword = Data[4];

            RegisterUser(officeName,username, password, confirmedPassword);

            return string.Format($"User {username} registered successfully!");
        }

        private void RegisterUser(string officeName, string username, string password, string confirmedPassword)
        {
            using (var context = new PawnShopContext())
            {
                if (context.Users.Any(u => u.Credentials.Email == username))
                {
                    throw new ArgumentException($"User with that username already exists!");
                }

                if (!password.Equals(confirmedPassword))
                {
                    throw new ArgumentException($"Passwords do not match!");
                }

                if (LoginUser.User != null)
                {
                    throw new ArgumentException($"Login users cannot register. Logout first!");
                }

                var office = context.Offices.FirstOrDefault(o => o.Name == officeName);
                var user = new User()
                {
                    Office = office,
                    Credentials = new Credentials()
                    {
                        Email = username,
                        Password = password
                    }
                };

                context.Users.Add(user);
                context.SaveChanges();
                LoginUser.User = user;
            }
        }
    }
}
