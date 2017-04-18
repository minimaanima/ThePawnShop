using System.Collections.Generic;

namespace PawnShop.Models.BusinessModels
{
    public class ClientAddress: Address
    {
        public ClientAddress()
        {
            this.Clients = new HashSet<Client>();
        }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
