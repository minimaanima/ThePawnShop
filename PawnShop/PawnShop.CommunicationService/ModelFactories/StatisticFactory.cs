using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using AutoMapper.QueryableExtensions;
using PawnShop.CommunicationService.Utilities;
using PawnShop.Data;
using PawnShop.Data.DTOs;
using PawnShop.Models.BusinessModels;

namespace PawnShop.CommunicationService.ModelFactories
{
    public static class StatisticFactory
    {
        public static IEnumerable<StatisticDto> GetOperations(string startDateString, string endDateString)
        {
            using (var context = new PawnShopContext())
            {
                MapperInitiliazer.InitializeStatistics();
                context.Users.Attach(LoginUser.User);

                var startDate = DateTime.Parse(startDateString);
                var endDate = DateTime.Parse(endDateString);

                if (startDate > endDate)
                {
                    throw new InvalidOperationException("Invalid data provided.");
                }

                var operations =
                    context.CashOperations.Where(c => c.CashBox.Office.Name == LoginUser.User.Office.Name &&
                                                      (SqlFunctions.DateDiff("day", c.DateTime, startDate).Value <= 0 &&
                                                       SqlFunctions.DateDiff("day", c.DateTime, endDate).Value >= 0))
                        .OrderBy(c=> c.DateTime)
                        .ProjectTo<StatisticDto>()
                        .ToList();

                return operations;
            }
        }

        public static IEnumerable<CashOperation> GetFirstAndLastOperation(string startDateString, string endDateString)
        {
            using (var context = new PawnShopContext())
            {
                context.Users.Attach(LoginUser.User);

                var startDate = DateTime.Parse(startDateString);
                var endDate = DateTime.Parse(endDateString);

                if (startDate > endDate)
                {
                    throw new InvalidOperationException("Invalid data provided.");
                }

                var operations =
                    context.CashOperations.Where(c => c.CashBox.Office.Name == LoginUser.User.Office.Name &&
                                                      (SqlFunctions.DateDiff("day", c.DateTime, startDate).Value <= 0 &&
                                                       SqlFunctions.DateDiff("day", c.DateTime, endDate).Value >= 0))
                        .OrderBy(c => c.DateTime)
                        .ToList();

                var filtredOperations = new []
                {
                    operations.First(),
                    operations.Last()
                };

                return operations;
            }
        }
    }
}
