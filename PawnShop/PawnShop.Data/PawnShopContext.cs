namespace PawnShop.Data
{
    using System.Data.Entity;
    using Models.AuthorizationModels;
    using Models.BusinessModels;
    using Initializers;

    public class PawnShopContext : DbContext
    {
        public PawnShopContext()
            : base("name=PawnShopContext")
        {
            Database.SetInitializer(new PawnShopIni());
        }

        public virtual IDbSet<User> Users { get; set; }

        public virtual IDbSet<Credentials> Credentials { get; set; }

        public virtual IDbSet<Town> Towns { get; set; }

        public virtual IDbSet<Address> Addresses { get; set; }

        public virtual IDbSet<CashBox> CashBoxes { get; set; }

        public virtual IDbSet<CashOperation> CashOperations { get; set; }

        public virtual IDbSet<Client> Clients { get; set; }

        public virtual IDbSet<Contract> Contracts { get; set; }

        public virtual IDbSet<Office> Offices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Office>().HasOptional(o => o.CashBox).WithRequired(c => c.Office);
            modelBuilder.Entity<User>().HasRequired(u => u.Office).WithMany(o => o.Employees).WillCascadeOnDelete(false);
            modelBuilder.Entity<Office>().HasRequired(o => o.Address).WithOptional(a => a.Office).WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}