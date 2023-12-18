using Travel_Agency_Project.Entities.Clients;

namespace Travel_Agency_Project.Entities
{
    public static class DataSeeder
    {
        public static void SeedData(Database dbContext)
        {
            // Check if there is any data in the table
            if (!dbContext.Client.Any())
            {
                // Seed some initial data
                var records = new[]
                {
                new Client { Id = Guid.NewGuid(), Name = "AA", FamilyName = "AA", Address = "AA Address", BirthDate = DateTime.UtcNow},
                new Client { Id = Guid.NewGuid(), Name = "BB", FamilyName = "BB", Address = "BB Address", BirthDate = DateTime.UtcNow},
                new Client { Id = Guid.NewGuid(), Name = "CC", FamilyName = "CC", Address = "CC Address", BirthDate = DateTime.UtcNow},
            };

                // Add records to the database
                dbContext.Client.AddRange(records);
                dbContext.SaveChanges();
            }
        }
    }
}
