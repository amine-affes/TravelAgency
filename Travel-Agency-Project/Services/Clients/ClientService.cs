using Microsoft.EntityFrameworkCore;
using Travel_Agency_Project.Entities;
using Travel_Agency_Project.Entities.Clients;

namespace Travel_Agency_Project.Services.Clients
{
    public class ClientService : IClientService
    {
        private readonly Database _dbContext;
        public ClientService(Database dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Client?> GetClient(Guid clientId)
        {
            return await _dbContext.Client.FindAsync(clientId);
            //return new Client();
        }

        public async Task<List<Client>> GetClients()
        {
            var clients = await _dbContext.Client.ToListAsync<Client>();
            return clients;
            //return new List<Client>();
        }
    }
}
