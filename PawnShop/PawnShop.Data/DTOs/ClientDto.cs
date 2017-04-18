using System;

namespace PawnShop.Data.DTOs
{
    public class ClientDto
    {
        public int PersonalID { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string TownName { get; set; }

        public string AddressName { get; set; }

        public string IDCardNumber { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
