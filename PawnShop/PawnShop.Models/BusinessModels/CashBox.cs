using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PawnShop.Models.BusinessModels
{
    public class CashBox
    {
        public CashBox()
        {
            this.CashOperations = new HashSet<CashOperation>();
        }

        [Key]
        public int Id { get; set; }

        public decimal Balance { get; set; }

        [ForeignKey("Id")]
        public virtual Office Office { get; set; }

        public virtual ICollection<CashOperation> CashOperations { get; set; }
    }
}
