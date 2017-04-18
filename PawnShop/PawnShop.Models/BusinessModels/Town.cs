namespace PawnShop.Models.BusinessModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public class Town
    {
        public Town()
        {
            this.Addresses = new HashSet<Address>();
        }

        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
