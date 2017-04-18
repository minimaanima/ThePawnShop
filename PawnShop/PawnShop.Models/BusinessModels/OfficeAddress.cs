namespace PawnShop.Models.BusinessModels
{
    public class OfficeAddress: Address
    {
        public virtual Office Office { get; set; }
    }
}
