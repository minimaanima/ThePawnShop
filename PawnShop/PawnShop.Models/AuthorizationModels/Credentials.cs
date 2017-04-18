namespace PawnShop.Models.AuthorizationModels
{
    using System.ComponentModel.DataAnnotations;
    using ValidationModels.Attributes;
    using BusinessModels;

    public class Credentials
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Email]
        public string Email { get; set; }

        [Required]
        [Password(4, 50, ShouldContainDigit = false, ShouldContainCapitalLetter = false, ShouldContainLowercaseLetter = false, ShouldContainSpecialSymbol = false)]
        public string Password { get; set; }
    }
}
