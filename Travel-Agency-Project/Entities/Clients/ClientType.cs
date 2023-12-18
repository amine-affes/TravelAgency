using GraphQL.Types;

namespace Travel_Agency_Project.Entities.Clients
{
    public class ClientType: ObjectGraphType<Client>
    {
        public ClientType() {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.FamilyName);
            Field(x => x.Address);
            Field(x => x.BirthDate);
            Field(x => x.CreatedAt);
        }
    }
}
