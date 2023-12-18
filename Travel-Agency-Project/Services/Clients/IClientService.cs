using Travel_Agency_Project.Entities.Clients;

namespace Travel_Agency_Project.Services.Clients
{
    public interface IClientService
    {
        public Task<List<Client>> GetClients();
        public Task<Client?> GetClient(Guid clientId);
    }
}
