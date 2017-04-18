using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using PawnShop.CommunicationService.Utilities;
using PawnShop.Data;
using PawnShop.Data.DTOs;
using PawnShop.Models.BusinessModels;

namespace PawnShop.CommunicationService.ModelFactories
{
    public static class ClientFactory
    {
        public static IEnumerable<ClientDto> GetClients()
        {
            MapperInitiliazer.InitializeClients();

            using (var context = new PawnShopContext())
            {
                var clients =
                    context.Clients
                    //.Where(
                    //        c => c.Contracts.Any(con => con.Employee.Office.Name == LoginUser.User.Office.Name))
                        .ProjectTo<ClientDto>()
                        .ToList();

                return clients;
            }
        }
    }
}
