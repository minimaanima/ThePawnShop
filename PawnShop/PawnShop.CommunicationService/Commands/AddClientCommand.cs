using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawnShop.CommunicationService.Interfaces;
using PawnShop.Data;
using PawnShop.Models.BusinessModels;

namespace PawnShop.CommunicationService.Commands
{
    public class AddClientCommand: Command
    {
        public AddClientCommand(string[] data) : base(data)
        {
            GetParameters = 8;
        }

        public override ICommand Create(string[] data)
        {
           return new AddClientCommand(data);
        }

        public override string Execute()
        {
            var firstName = Data[1];
            var middleName = Data[2];
            var lastName = Data[3];
            var address = Data[4];
            var personalId = Data[5];
            var idCardNumber = Data[6];
            var phonenumber = Data[7];
            var town = Data[8];

            using (var context = new PawnShopContext())
            {
                var addressLiving = context.Addresses.FirstOrDefault(a => a.Text == address);
            
                var client = new Client()
                {
                    FirstName = firstName,
                    MiddleName = middleName,
                    LastName = lastName,
                    PersonalID = int.Parse(personalId),
                    IDCardNumber = idCardNumber,
                    PhoneNumber = phonenumber,
                    RegistrationDate = DateTime.Now
                   
                };

                var townLiving = context.Towns.FirstOrDefault(t => t.Name == town);
                if (townLiving == null)
                {
                    townLiving = new Town()
                    {
                        Name = town
                    };
                }

                if (addressLiving == null)
                {
                    client.Address = new ClientAddress()
                    {
                        Text = address,
                        Town = townLiving
                    };
                }
                else
                {
                    client.Address = (ClientAddress) addressLiving;
                }

                context.Clients.Add(client);
                context.SaveChanges();
            }

            return string.Format($"Added successfully new client.");
        }
    }
}
