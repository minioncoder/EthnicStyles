using System.Data.Entity;

namespace EthnicStyles.DataAccess 
{
    public class EthnicDbEntities : DbContext
    {
        public EthnicDbEntities() : base("ET_2019")
        {
            Database.SetInitializer(new EthnicDbInitializer());
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }

    }
}
