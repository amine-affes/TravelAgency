using GraphQL.Types;

namespace Travel_Agency_Project.Entities.Dossiers
{
    public class DossierType : ObjectGraphType<Dossier>
    {
        public DossierType()
        {
            Field(x => x.Id);
            Field(x => x.Type);
            Field(x => x.ArrivalDate);
            Field(x => x.Duration);
            Field(x => x.FlightNumber);
            Field(x => x.CreatedAt);
        }
    }
}
