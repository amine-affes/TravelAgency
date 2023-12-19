using Travel_Agency_Project.Entities.Dossiers;

namespace Travel_Agency_API.Services.Dossiers
{
    public interface IDossierService
    {
        public Task<Dossier?> GetDossierByClient(string name, string familyName);
    }
}
