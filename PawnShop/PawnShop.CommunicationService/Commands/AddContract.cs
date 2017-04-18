using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Globalization;
using System.Linq;
using PawnShop.CommunicationService.Interfaces;
using PawnShop.CommunicationService.Utilities;
using PawnShop.Data;
using PawnShop.Models.BusinessModels;
using PawnShop.Models.Enums;

namespace PawnShop.CommunicationService.Commands
{
    public class AddContract: Command
    {
        public AddContract(string[] data) : base(data)
        {
            this.GetParameters = 5;
        }

        public override ICommand Create(string[] data)
        {
            return new AddContract(data);
        }

        public override string Execute()
        {
            var endDate = DateTime.Parse(Data[1]);
            var property = Data[2];
            var properyValue = decimal.Parse(Data[3]);
            var interest = decimal.Parse(Data[4]);
            var clientName = Data[5];

            AddNewContract(property, properyValue, interest, endDate, clientName);
            return string.Format($"New contract successfully added.");
        }

        private void AddNewContract(string property, decimal properyValue, decimal interest, DateTime endDate,
            string clientName)
        {
            using (var context = new PawnShopContext())
            {
                var client =
                  context.Clients.FirstOrDefault(
                      c => string.Concat(c.FirstName, " ", c.MiddleName, " ", c.LastName) == clientName);

                var user = context.Users.FirstOrDefault();

                var contract = new Contract()
                {
                    PledgedProperty = property,
                    PropertyValue = properyValue,
                    Interest = interest,
                    StartDate = DateTime.Today,
                    EndDate = endDate,
                    Employee = user,
                    Client = client,
                    Status = Status.New
                };

                context.Contracts.Add(contract);
                context.SaveChanges();
            }
        }
    }
}
