using GraphQL;
using GraphQL.Types;
using Travel_Agency_Project.Entities.Clients;

namespace Travel_Agency_Project.Services.Clients
{
    public class ClientQuery : ObjectGraphType
    {
        [Obsolete]
        public ClientQuery(IClientService clientService)
        {
            Field<ListGraphType<ClientType>>(Name = "Clients",
                resolve: x =>
                {
                    try
                    {
                        return clientService.GetClients();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                });
            Field<ListGraphType<ClientType>>(Name = "Client",
                arguments: new QueryArguments(new QueryArgument<GuidGraphType> { Name = "id" }),
                resolve: x => clientService.GetClient(x.GetArgument<Guid>("id")));
        }
    }
}
