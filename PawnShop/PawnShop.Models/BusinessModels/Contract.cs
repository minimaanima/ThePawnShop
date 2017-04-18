namespace PawnShop.Models.BusinessModels
{
    using Enums;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Contract
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string PledgedProperty { get; set; }

        [Required]
        public decimal PropertyValue { get; set; }

        [Required]
        public decimal Interest { get; set; }

        [Required]
        public Status Status { get; set; }

        public int ClientId { get; set; }

        public virtual Client Client { get; set; }

        public int EmployeeId { get; set; }

        public virtual User Employee { get; set; }

    }
}
