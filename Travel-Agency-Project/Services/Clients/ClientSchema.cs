using GraphQL.Types;

namespace Travel_Agency_Project.Services.Clients
{
    public class ClientSchema : Schema
    {
        public ClientSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<ClientQuery>();
        }
    }
}
