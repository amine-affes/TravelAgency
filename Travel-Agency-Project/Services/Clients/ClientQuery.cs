using GraphQL;
using GraphQL.Types;
using Travel_Agency_Project.Entities.Dossiers;

namespace Travel_Agency_Project.Services.Clients
{
    public class ClientQuery : ObjectGraphType
    {
        [Obsolete]
        public ClientQuery(IClientService clientService)
        {
            Field<ListGraphType<DossierType>>(Name = "Client",
                arguments: new QueryArguments(new QueryArgument<StringGraphType> { Name = "name" },
                new QueryArgument<StringGraphType> { Name = "familyName" }),
                resolve: x => clientService.GetClient(x.GetArgument<string>("name"), x.GetArgument<string>("familyName")).Result);
        }
    }
}
