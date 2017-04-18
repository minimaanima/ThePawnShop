namespace PawnShop.Models.BusinessModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Client
    {
        public Client()
        {
            this.Contracts = new HashSet<Contract>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public int PersonalID { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public int AddressId { get; set; }

        public virtual ClientAddress Address { get; set; }

        [Required]
        public string IDCardNumber { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
