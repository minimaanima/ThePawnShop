namespace PawnShop.Models.BusinessModels
{
    using System.ComponentModel.DataAnnotations;
    using Enums;

    public class CashOperation
    {
        [Key]
        public int Id { get; set; }

        public OperationType OperationType { get; set; }    

        public string Details { get; set; }

        public decimal Value { get; set; }

        public int CashBoxId { get; set; }

        public virtual CashBox CashBox { get; set; }
    }
}
