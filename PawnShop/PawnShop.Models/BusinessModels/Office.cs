using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PawnShop.Models.BusinessModels
{
    public class Office
    {
        public Office()
        {
            this.Employees = new HashSet<User>();
        }

        [Key]
        [ForeignKey("Address")]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual OfficeAddress Address { get; set; }

        public virtual CashBox CashBox { get; set; }

        [InverseProperty("Office")]
        public virtual ICollection<User> Employees { get; set; }
    }
}
