using System;
using PawnShop.CommunicationService.Interfaces;
using PawnShop.CommunicationService.Utilities;
using PawnShop.Data;
using PawnShop.Models.BusinessModels;
using PawnShop.Models.Enums;

namespace PawnShop.CommunicationService.Commands
{
    public class CashBoxTransactionCommand: Command
    {
        public CashBoxTransactionCommand(string[] data) : base(data)
        {
        }

        public override ICommand Create(string[] data)
        {
            return new CashBoxTransactionCommand(data);
        }

        public override string Execute()
        {
            var operationType = (OperationType)Enum.Parse(typeof(OperationType), Data[1]);
            var value = decimal.Parse(Data[2]);
            var details = Data[3];

            CashBoxTransaction(operationType, value, details);
            return string.Format($"Operation {Data[1]} successfully performed.");
        }

        private void CashBoxTransaction(OperationType operationType, decimal value, string details)
        {
            using (var context = new PawnShopContext())
            {
                context.Users.Attach(LoginUser.User);

                if (operationType == OperationType.Deposit)
                {
                    LoginUser.User.Office.CashBox.Balance += value;
                }
                else
                {
                    LoginUser.User.Office.CashBox.Balance -= value;
                }

                var cashOperation = new CashOperation()
                {
                    CashBox = LoginUser.User.Office.CashBox,
                    Details = details,
                    OperationType = operationType,
                    Value = value
                };

                context.CashOperations.Add(cashOperation);
                context.SaveChanges();
            }
                
        }
    }
}
