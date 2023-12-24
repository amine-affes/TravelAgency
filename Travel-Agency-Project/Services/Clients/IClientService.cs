using Travel_Agency_Project.Entities.Clients;
using Travel_Agency_Project.Entities.Dossiers;

namespace Travel_Agency_Project.Services.Clients
{
    public interface IClientService
    {
        public Task<Dossier?> GetClient(string name, string familyName);
    }
}
