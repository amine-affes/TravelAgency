using Microsoft.EntityFrameworkCore;
using Travel_Agency_Project.Entities;
using Travel_Agency_Project.Entities.Dossiers;

namespace Travel_Agency_API.Services.Dossiers
{
    public class DossierService : IDossierService
    {
        private readonly Database _dbContext;

        public DossierService(Database dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Dossier?> GetDossierByClient(string name, string familyName)
        {
            return await _dbContext.Dossier
                .Include(x => x.Client)
                .Include(x => x.Product)
                .Where(x => x.Client.Name == name && x.Client.FamilyName == familyName)
                .FirstOrDefaultAsync();
        }
    }
}
