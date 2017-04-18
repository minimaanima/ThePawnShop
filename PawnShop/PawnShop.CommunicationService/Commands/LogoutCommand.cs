using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawnShop.CommunicationService.Interfaces;
using PawnShop.CommunicationService.Utilities;
using PawnShop.Data;

namespace PawnShop.CommunicationService.Commands
{
    public class LogoutCommand : Command
    {
        public LogoutCommand(string[] data) : base(data)
        {
        }

        public override ICommand Create(string[] data)
        {
            return new LogoutCommand(data);
        }

        public override string Execute()
        {
            using (var context = new PawnShopContext())
            {

                if (LoginUser.User == null)
                {
                    throw new InvalidOperationException("There is no loged in user!");
                }

                var username = context.Credentials.Find(LoginUser.User.Id).Email;
               
                LoginUser.User = null;

                return string.Format($"User {username} successfully loged out in!");
            }
        }
    }
}
