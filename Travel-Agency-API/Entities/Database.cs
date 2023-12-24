using Microsoft.EntityFrameworkCore;
using Travel_Agency_API.Entities.Clients;
using Travel_Agency_API.Entities.Products;
using Travel_Agency_Project.Entities.Dossiers;

namespace Travel_Agency_Project.Entities
{
    public class Database:DbContext
    {
        public Database(DbContextOptions<Database> options)
        : base(options)
        { }
        public DbSet<Client> Client => Set<Client>();
        public DbSet<Dossier> Dossier => Set<Dossier>();
        public DbSet<Product> Product => Set<Product>();
    }
}
