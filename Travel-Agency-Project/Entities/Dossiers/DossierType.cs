using GraphQL.Types;
using Travel_Agency_Project.Entities.Clients;
using Travel_Agency_Project.Entities.Products;

namespace Travel_Agency_Project.Entities.Dossiers
{
    public sealed class DossierType : ObjectGraphType<Dossier>
    {
        public DossierType()
        {
            Field(x => x.Id);
            Field(x => x.Type);
            Field(x => x.ArrivalDate);
            Field(x => x.Duration);
            Field(x => x.FlightNumber);
            Field(x => x.CreatedAt);
            Field<ClientType>(
                "Client",
                resolve: context =>
                {
                    var dossier = context.Source; // The Dossier instance
                    return dossier.Client;
                }
            );
            Field<ProductType>(
                "Product",
                resolve: context =>
                {
                    var dossier = context.Source; // The Dossier instance
                    return dossier.Product;
                }
            );
        }
    }
}
