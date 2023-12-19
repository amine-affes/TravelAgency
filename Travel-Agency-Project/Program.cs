using GraphQL;
using GraphQL.Types;
using Travel_Agency_Project.Entities.Clients;
using Travel_Agency_Project.Entities.Dossiers;
using Travel_Agency_Project.Services.Clients;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<ClientType>();
builder.Services.AddScoped<DossierType>();
builder.Services.AddScoped<ClientQuery>();
builder.Services.AddScoped<ISchema, ClientSchema>();
builder.Services.AddGraphQL(b => b
    .AddAutoSchema<ClientQuery>()  // schema
    .AddSystemTextJson());   // serializer


var app = builder.Build();

app.UseHttpsRedirection();


app.UseWebSockets();
app.UseGraphQL("/graphql");            // url to host GraphQL endpoint
app.UseGraphQLPlayground(
    "/",                               // url to host Playground at
    new GraphQL.Server.Ui.Playground.PlaygroundOptions
    {
        GraphQLEndPoint = "/graphql",         // url of GraphQL endpoint
        SubscriptionsEndPoint = "/graphql",   // url of GraphQL endpoint
    });



await app.RunAsync();
