using PawnShop.Models.BusinessModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawnShop.Models.AuthorizationModels;
using PawnShop.Models.Enums;

namespace PawnShop.Data.Initializers
{
    public class PawnShopIni: CreateDatabaseIfNotExists<PawnShopContext>
    {
        protected override void Seed(PawnShopContext context)
        {
            ImportTowns(context);
            ImportOffices(context);
            ImportUsers(context);
            ImportClients(context);
            ImportContracts(context);
            base.Seed(context);
        }

        private static void ImportTowns(PawnShopContext context)
        {
            var town = new Town()
            {
                Name = "Sofia"
            };

            var town2 = new Town()
            {
                Name = "Plovdiv"
            };

            var town3 = new Town()
            {
                Name = "Varna"
            };

            var town4 = new Town()
            {
                Name = "Bourgas"
            };

            var town5 = new Town()
            {
                Name = "Yambol"
            };

            context.Towns.AddOrUpdate(t => t.Name, town);
            context.Towns.AddOrUpdate(t => t.Name, town2);
            context.Towns.AddOrUpdate(t => t.Name, town3);
            context.Towns.AddOrUpdate(t => t.Name, town4);
            context.Towns.AddOrUpdate(t => t.Name, town5);
            context.SaveChanges();
        }

        private static void ImportOffices(PawnShopContext context)
        {
            var offices = new List<Office>()
            {
                new Office()
                {
                    Name ="Koito razbira tuka se spira",
                    Address = new OfficeAddress()
                    {
                        Text = "Graf Ignatiev 57"
                    },
                    CashBox = new CashBox()
                    {
                        Balance = 6991.00m
                    }
                },
                new Office()
                {
                    Name = "Zalojna kushta pri bat Mitko",
                    Address = new OfficeAddress()
                    {
                        Text = "Raina Knyaginya 132"
                    },
                    CashBox = new CashBox()
                    {
                        Balance = 2616.00m
                    }
                },
                new Office()
                {
                    Name = "Zlatna kushta",
                    Address = new OfficeAddress()
                    {
                        Text = "Doktor Donchev 12g"
                    },
                    CashBox = new CashBox()
                    {
                        Balance = 5150.00m
                    }
                },
                new Office()
                {
                    Name = "Zalagai smelo",
                    Address = new OfficeAddress()
                    {
                        Text = "Razcufnal trilistnik 152"
                    },
                    CashBox = new CashBox()
                    {
                        Balance = 8000.00m
                    }
                },
                new Office()
                {
                    Name = "Detelina",
                    Address = new OfficeAddress()
                    {
                        Text = "Graf Ignatiev 57"
                    },
                    CashBox = new CashBox()
                    {
                        Balance = 4000.00m
                    }
                },
                new Office()
                {
                    Name = "Koksal baba",
                    Address = new OfficeAddress()
                    {
                        Text = "Brigalnica 19"
                    },
                    CashBox = new CashBox()
                    {
                        Balance = 3560.00m
                    }
                },
                new Office()
                {
                    Name = "Priqteli",
                    Address = new OfficeAddress()
                    {
                        Text = "Han Asparuh 1"
                    },
                    CashBox = new CashBox()
                    {
                        Balance = 2600.00m
                    }
                },
                new Office()
                {
                    Name = "Dimitrovi",
                    Address = new OfficeAddress()
                    {
                        Text = "Onq blok tam do 3tiq otlqvo"
                    },
                    CashBox = new CashBox()
                    {
                        Balance = 6991.00m
                    }
                },
                new Office()
                {
                    Name = "Stoimenovi",
                    Address = new OfficeAddress()
                    {
                        Text = "Losh vulk 18"
                    },
                    CashBox = new CashBox()
                    {
                        Balance = 5900.00m
                    }
                }
            };

            var townsCount = context.Towns.Local.Count;
            var random = new Random();
            foreach (var office in offices)
            {
                office.Address.Town = context.Towns.Local[random.Next(0, townsCount - 1)];
            }

            offices.ForEach(a => context.Offices.AddOrUpdate(ad => ad.Name, a));
            context.SaveChanges();
        }

        private static void ImportUsers(PawnShopContext context)
        {
           var users = new List<User>()
           {
               new User()
               {
                   Credentials = new Credentials()
                   {
                       Email = "georgiIvanov@abv.bg",
                       Password = "1122334455"
                   }
               },
                new User()
               {
                   Credentials = new Credentials()
                   {
                       Email = "plamkata@gmail.com",
                       Password = "23ada132"
                   }
               },
                 new User()
               {
                   Credentials = new Credentials()
                   {
                       Email = "batJoro94@abv.bg",
                       Password = "qwerty123"
                   }
               },
                  new User()
               {
                   Credentials = new Credentials()
                   {
                       Email = "pamelaAndersan@abv.bg",
                       Password = "1238adc2123"
                   }
               },
                   new User()
               {
                   Credentials = new Credentials()
                   {
                       Email = "minkaChestnata@abv.bg",
                       Password = "000033"
                   }
               },
                    new User()
               {
                   Credentials = new Credentials()
                   {
                       Email = "stamatYordanov@icloud.com",
                       Password = "asdasd123"
                   }
               },
                     new User()
               {
                   Credentials = new Credentials()
                   {
                       Email = "mitko91@abv.bg",
                       Password = "mitakaMadafaka123"
                   }
               },
                      new User()
               {
                   Credentials = new Credentials()
                   {
                       Email = "peturAngelov@abv.bg",
                       Password = "pepo123"
                   }
               },
                       new User()
               {
                   Credentials = new Credentials()
                   {
                       Email = "galenceto@abv.bg",
                       Password = "cunki33"
                   }
               },
                        new User()
               {
                   Credentials = new Credentials()
                   {
                       Email = "asenchoTaxito@abv.bg",
                       Password = "777777"
                   }
               },
                         new User()
               {
                   Credentials = new Credentials()
                   {
                       Email = "toniNaika@abv.bg",
                       Password = "001323"
                   }
               }
           };

            var officesCount = context.Offices.Local.Count;
            var random = new Random();

            foreach (var user in users)
            {
                user.Office = context.Offices.Local[random.Next(0, officesCount - 1)];
            }

            users.ForEach(u => context.Users.AddOrUpdate(us => us.Id, u));
            context.SaveChanges();
        }

        private static void ImportClients(PawnShopContext context)
        {
            var townsCount = context.Towns.Local.Count;
            var random = new Random();

            var clients = new List<Client>()
            {
                new Client()
                {
                    FirstName = "Petur",
                    LastName = "Petrov",
                    MiddleName = "Petrov",
                    PersonalID = 940132932,
                    IDCardNumber = "555SSAAD555",
                    PhoneNumber = "0899331232",
                    RegistrationDate = new DateTime(2017,02,02),
                    Address = new ClientAddress()
                    {
                        Text = "Lulyak 12",
                        Town = context.Towns.Local[random.Next(0, townsCount - 1)]
                    }
                },
                new Client()
                {
                    FirstName = "Georgi",
                    LastName = "Georgiev",
                    MiddleName = "Georgiev",
                    PersonalID = 93991933,
                    IDCardNumber = "AD23213566",
                    PhoneNumber = "0887331233",
                    RegistrationDate = new DateTime(2017,03,02),
                    Address = new ClientAddress()
                    {
                        Text = "San Stefano 11",
                        Town = context.Towns.Local[random.Next(0, townsCount - 1)]
                    }
                },
                new Client()
                {
                    FirstName = "Plamena",
                    LastName = "Plamenova",
                    MiddleName = "Petrova",
                    PersonalID = 900132352,
                    IDCardNumber = "991112337",
                    PhoneNumber = "0899335412",
                    RegistrationDate = new DateTime(2017,01,21),
                    Address = new ClientAddress()
                    {
                        Text = "Samarsko zname 5",
                        Town = context.Towns.Local[random.Next(0, townsCount - 1)]
                    }
                },
                new Client()
                {
                    FirstName = "Stamat",
                    LastName = "Stamatov",
                    MiddleName = "Georgiev",
                    PersonalID = 912132332,
                    IDCardNumber = "B345B314",
                    PhoneNumber = "0879333333",
                    RegistrationDate = new DateTime(2016,12,02),
                    Address = new ClientAddress()
                    {
                        Text = "Oblak 10",
                        Town = context.Towns.Local[random.Next(0, townsCount - 1)]
                    }
                },
                new Client()
                {
                    FirstName = "Kremena",
                    LastName = "Simeonova",
                    MiddleName = "Georgieva",
                    PersonalID = 990132935,
                    IDCardNumber = "JU334411K",
                    PhoneNumber = "0876451732",
                    RegistrationDate = new DateTime(2017,04,11),
                    Address = new ClientAddress()
                    {
                        Text = "Indje Voivoda 156",
                        Town = context.Towns.Local[random.Next(0, townsCount - 1)]
                    }
                },
                new Client()
                {
                    FirstName = "Dimitur",
                    LastName = "Dimitrov",
                    MiddleName = "Petrov",
                    PersonalID = 930731832,
                    IDCardNumber = "5555AD1233",
                    PhoneNumber = "0897441232",
                    RegistrationDate = new DateTime(2017,01,29),
                    Address = new ClientAddress()
                    {
                        Text = "Amigo 12",
                        Town = context.Towns.Local[random.Next(0, townsCount - 1)]
                    }
                },
                new Client()
                {
                    FirstName = "Galin",
                    LastName = "Petrov",
                    MiddleName = "Galinov",
                    PersonalID = 941133952,
                    IDCardNumber = "ASD999301",
                    PhoneNumber = "0859400232",
                    RegistrationDate = new DateTime(2017,02,02),
                    Address = new ClientAddress()
                    {
                        Text = "Zlatni duni 12",
                        Town = context.Towns.Local[random.Next(0, townsCount - 1)]
                    }
                },
                new Client()
                {
                    FirstName = "Penko",
                    LastName = "Penkov",
                    MiddleName = "Penkov",
                    PersonalID = 900199932,
                    IDCardNumber = "999412422A",
                    PhoneNumber = "089000012",
                    RegistrationDate = new DateTime(2017,02,13),
                    Address = new ClientAddress()
                    {
                        Text = "Makedoniya 12",
                        Town = context.Towns.Local[random.Next(0, townsCount - 1)]
                    }
                }
            };

            clients.ForEach(c => context.Clients.AddOrUpdate(cl => new {cl.FirstName, cl.LastName, cl.MiddleName}, c));
            context.SaveChanges();
        }

        private static void ImportContracts(PawnShopContext context)
        {
            var contracts = new List<Contract>()
            {
                new Contract()
                {
                    PledgedProperty = "Iphone 5s",
                    Status = Status.Active,
                    PropertyValue = 320,
                    Interest = 2.12m
                },
                new Contract()
                {
                    PledgedProperty = "Plazment Televizor Samsung",
                    Status = Status.Active,
                    PropertyValue = 600,
                    Interest = 2.14m
                },
                new Contract()
                {
                    PledgedProperty = "Iphone 7s plues",
                    Status = Status.Active,
                    PropertyValue = 1000,
                    Interest = 2.00m
                },
                new Contract()
                {
                    PledgedProperty = "Laptop Alienware",
                    Status = Status.Overtimed,
                    PropertyValue = 1500,
                    Interest = 2.12m
                },
                new Contract()
                {
                    PledgedProperty = "Huaweii S510",
                    Status = Status.Active,
                    PropertyValue = 600,
                    Interest = 2.12m
                },
                new Contract()
                {
                    PledgedProperty = "Zlatna grivna",
                    Status = Status.Active,
                    PropertyValue = 100,
                    Interest = 1.09m
                },
                new Contract()
                {
                    PledgedProperty = "Zlaten komplekt-grivna,prusten,kolie",
                    Status = Status.Active,
                    PropertyValue = 500,
                    Interest = 1.123m
                },
                new Contract()
                {
                    PledgedProperty = "Peralnq Toshiba",
                    Status = Status.Active,
                    PropertyValue = 150,
                    Interest = 0.57m
                },
                new Contract()
                {
                    PledgedProperty = "Stereouredba",
                    Status = Status.Active,
                    PropertyValue = 320,
                    Interest = 2.12m
                },
                new Contract()
                {
                    PledgedProperty = "Pult",
                    Status = Status.Active,
                    PropertyValue = 500,
                    Interest = 2.12m
                },
                new Contract()
                {
                    PledgedProperty = "Printer Samsung",
                    Status = Status.Active,
                    PropertyValue = 200,
                    Interest = 2.12m
                },
                new Contract()
                {
                    PledgedProperty = "Mac book Pro",
                    Status = Status.Active,
                    PropertyValue = 1500,
                    Interest = 2.12m
                },
                new Contract()
                {
                    PledgedProperty = "Tablet Apple",
                    Status = Status.Active,
                    PropertyValue = 500,
                    Interest = 2.12m
                },
                new Contract()
                {
                    PledgedProperty = "Tablet Lenovo",
                    Status = Status.Active,
                    PropertyValue = 300,
                    Interest = 2.12m
                },
                new Contract()
                {
                    PledgedProperty = "Kola Audi A3",
                    Status = Status.Active,
                    PropertyValue = 2000,
                    Interest = 3.12m
                },
                new Contract()
                {
                    PledgedProperty = "Kola Audi Q7",
                    Status = Status.Active,
                    PropertyValue = 4500,
                    Interest = 5.12m
                },
            };

            var clientsCount = context.Clients.Local.Count;
            var employeesCount = context.Users.Local.Count;
            var random = new Random();

            foreach (var contract in contracts)
            {
                var client = context.Clients.Local[random.Next(0, clientsCount - 1)];
                var employee = context.Users.Local[random.Next(0, employeesCount - 1)];
                contract.Client = client;
                contract.StartDate = client.RegistrationDate;
                contract.EndDate = client.RegistrationDate.AddMonths(3);
                contract.Employee = employee;
            }

            contracts.ForEach(c => context.Contracts.AddOrUpdate(cnt => cnt.Id, c));
            context.SaveChanges();
        }
    }
}
