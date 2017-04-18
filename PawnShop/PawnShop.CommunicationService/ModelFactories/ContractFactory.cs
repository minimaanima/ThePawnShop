using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using PawnShop.CommunicationService.Utilities;
using PawnShop.Data;
using PawnShop.Data.DTOs;
using PawnShop.Models.BusinessModels;
using PawnShop.Models.Enums;

namespace PawnShop.CommunicationService.ModelFactories
{
    public static class ContractFactory
    {
        public static IEnumerable<ContractDto> GetContracts(Status status = Status.All)
        {
            using (var context = new PawnShopContext())
            {
               MapperInitiliazer.InitiliazeContracts();

                if (status == Status.All)
                {
                    var contracts =
                        context.Contracts
                        //.Where(c => c.Employee.Office.Name == LoginUser.User.Office.Name)
                            .ProjectTo<ContractDto>()
                            .ToList();

                    return contracts;
                }

                var filtredContracts =
                        context.Contracts.Where(c => c.Employee.Office.Name == LoginUser.User.Office.Name && c.Status == status)
                            .ProjectTo<ContractDto>()
                            .ToList();

                return filtredContracts;
            }
        }

        public static ContractDto GetContractById(int contractId)
        {
            using (var context = new PawnShopContext())
            {
                var contract = context.Contracts.Find(contractId);
                var contractDto = new ContractDto()
                {
                    ContractId = contract.Id,
                    Client = contract.Client.FirstName + " " + contract.Client.MiddleName + " " + contract.Client.LastName + Environment.NewLine + contract.Client.PersonalID,
                    DateOfRegistrationAndExpiring =
                                contract.StartDate.Date.ToString() + " - " + contract.EndDate.Date.ToString(),
                    PropertyValue = contract.PropertyValue,
                    Interest = contract.Interest,
                    Days = (contract.StartDate - contract.EndDate).Days,
                    PledgedProperty = contract.PledgedProperty,
                    Status = contract.Status

                };

                return contractDto;
            }
        }

        public static IEnumerable<ContractDto> GetContractsByClientsPersonalId(int personalId)
        {
            using (var context = new PawnShopContext())
            {
                MapperInitiliazer.InitiliazeContracts();

                var contracts = context.Contracts.Where(c => c.Employee.Office.Name == LoginUser.User.Office.Name && c.Client.PersonalID == personalId)
                            .ProjectTo<ContractDto>()
                            .ToList();

                return contracts;
            }
        }

        public static IEnumerable<ContractDto> GetContractsByClientsName(string name)
        {
            using (var context = new PawnShopContext())
            {
                MapperInitiliazer.InitiliazeContracts();

                var contracts = context.Contracts.Where(c => /*c.Employee.Office.Name == LoginUser.User.Office.Name && */string.Concat(c.Client.FirstName, " ", c.Client.MiddleName, " ", c.Client.LastName) == name)
                            .ProjectTo<ContractDto>()
                            .ToList();

                return contracts;
            }
        }

        public static IEnumerable<ContractDto> GetContractsByTown(string town)
        {
            using (var context = new PawnShopContext())
            {
                MapperInitiliazer.InitiliazeContracts();

                var contracts = context.Contracts.Where(c => c.Employee.Office.Name == LoginUser.User.Office.Name && c.Employee.Office.Address.Town.Name == town)
                            .ProjectTo<ContractDto>()
                            .ToList();

                return contracts;
            }
        }

        public static IEnumerable<ContractDto> GetContractsByAddress(string address)
        {
            using (var context = new PawnShopContext())
            {
                MapperInitiliazer.InitiliazeContracts();

                var contracts = context.Contracts.Where(c => c.Employee.Office.Name == LoginUser.User.Office.Name && c.Client.Address.Text == address)
                            .ProjectTo<ContractDto>()
                            .ToList();

                return contracts;
            }
        }

        public static ContractDetailsDto GetContractDetails(ContractDto contractDto)
        {
            using (var context = new PawnShopContext())
            {
                var employee = context.Contracts.Find(contractDto.ContractId).Employee.Credentials.Email;

                var contractDetails = new ContractDetailsDto()
                {
                    Date = contractDto.DateOfRegistrationAndExpiring,
                    Operator = employee,
                    ProperyValue = contractDto.PropertyValue.ToString(),
                    ValueAfterInterest = (contractDto.PropertyValue * contractDto.Interest + contractDto.PropertyValue).ToString()
                };

                return contractDetails;
            }
        }
    }
}
