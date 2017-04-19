using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawnShop.CommunicationService.Interfaces;
using PawnShop.CommunicationService.Utilities;
using PawnShop.Data;
using PawnShop.Models.BusinessModels;

namespace PawnShop.CommunicationService.Commands
{
    public class AddClientCommand: Command
    {
        public AddClientCommand(string[] data) : base(data)
        {
            GetParameters = 12;
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
            var property = Data[9];
            var propertyValue = Data[10];
            var interest = Data[11];
            var endDate = Data[12];

            AddNewClient(address, firstName, middleName, lastName, personalId, idCardNumber, phonenumber, town, property, propertyValue, interest, endDate);

            return string.Format($"Added successfully new client.");
        }

        private static void AddNewClient(string address, string firstName, string middleName, string lastName, string personalId,
            string idCardNumber, string phonenumber, string town, string property, string propertyValue, string interest, string endDate)
        {
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

                var clientName = client.FirstName + " " + client.MiddleName + " " + client.LastName;
                context.Clients.Add(client);
                context.SaveChanges();
                AddContract.AddNewContract(property, decimal.Parse(propertyValue), decimal.Parse(interest), DateTime.Parse(endDate), clientName);
            }
        }
    }
}
