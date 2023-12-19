using Travel_Agency_API.Entities.Clients;
using Travel_Agency_API.Entities.Products;
using Travel_Agency_Project.Entities.Dossiers;

namespace Travel_Agency_Project.Entities
{
    public static class DataSeeder
    {
        public static void SeedData(Database dbContext)
        {
            // Check if there is any data in the table
            if (!dbContext.Dossier.Any())
            {
                Random random = new Random();
                // Seed some initial data
                var client = new Client { Id = Guid.NewGuid(), Name = "AA", FamilyName = "AA", Address = "AA Address", BirthDate = DateTime.UtcNow };
                dbContext.Client.Add(client);
                var product = new Product { Id = Guid.NewGuid(), Name = "MyProduct", Location = "Marrakech" };
                dbContext.Product.Add(product);
                var dossier = new Dossier
                {
                    Id = Guid.NewGuid(),
                    Duration = random.Next(1, 15),
                    ArrivalDate = DateTime.UtcNow,
                    FlightNumber = random.Next(1, 999).ToString(),
                    Type = "Type",
                    Client = new Client { Id = Guid.NewGuid(), Name = "AA", FamilyName = "AA", Address = "AA Address", BirthDate = DateTime.UtcNow },
                    Product = new Product { Id = Guid.NewGuid(), Name = "MyProduct", Location = "Marrakech" }
                };
                dbContext.Dossier.Add(dossier);
            };
            // Add records to the database
            dbContext.SaveChanges();
        }
    }
}

