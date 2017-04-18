using System.ComponentModel.DataAnnotations.Schema;

namespace PawnShop.Models.BusinessModels
{
    using AuthorizationModels;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public User()
        {
            this.Contracts = new HashSet<Contract>();
        }

        [Key]
        public int Id { get; set; }

        public int OfficeId { get; set; }

        public virtual Office Office { get; set; }

        [ForeignKey("Id")]
        public virtual Credentials Credentials { get; set; }

        [InverseProperty("Employee")]
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
