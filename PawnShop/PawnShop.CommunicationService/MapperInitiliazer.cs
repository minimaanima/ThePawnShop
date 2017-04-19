using System;
using System.Data.Entity.SqlServer;
using AutoMapper;
using PawnShop.Data.DTOs;
using PawnShop.Models.BusinessModels;

namespace PawnShop.CommunicationService
{
    public static class MapperInitiliazer
    {
        public static void InitiliazeContracts()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Contract, ContractDto>()
               .ForMember(opt => opt.DateOfRegistrationAndExpiring, op => op.MapFrom(c => c.StartDate + " - " + Environment.NewLine + c.EndDate))
               .ForMember(opt => opt.Days, op => op.MapFrom(c => SqlFunctions.DateDiff("day", c.StartDate, c.EndDate).Value))
               .ForMember(opt => opt.ContractId, op => op.MapFrom(c => c.Id))
               .ForMember(opt => opt.Client, op => op.MapFrom(c => c.Client.FirstName + " " + c.Client.MiddleName + " " + c.Client.LastName + Environment.NewLine + c.Client.PersonalID))
               );
        }

        public static void InitializeClients()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Client, ClientDto>()
           .ForMember(op => op.FullName, opt => opt.MapFrom(c => string.Concat(c.FirstName, " ", c.MiddleName, " ", c.LastName)))
           .ForMember(op => op.TownName, opt => opt.MapFrom(c => c.Address.Town.Name))
           .ForMember(op => op.AddressName, opt => opt.MapFrom(c => c.Address.Text))
               );

        }

        public static void InitializeStatistics()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<CashOperation, StatisticDto>()
           .ForMember(op => op.OperationType, opt => opt.MapFrom(c => c.OperationType.ToString()))
           .ForMember(op => op.DateTime, opt => opt.MapFrom(c => c.DateTime.ToString()))
               );

        }
    }
}
