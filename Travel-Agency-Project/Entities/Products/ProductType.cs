using GraphQL.Types;

namespace Travel_Agency_Project.Entities.Products
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Location);
            Field(x => x.CreatedAt);
        }
    }
}
