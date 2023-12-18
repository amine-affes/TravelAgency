using GraphQL;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using Travel_Agency_Project.Entities;
using Travel_Agency_Project.Entities.Clients;
using Travel_Agency_Project.Services.Clients;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
// Add DbContext
builder.Services.AddDbContext<Database>(options => {
    var config = builder.Configuration;
    var connectionString = config.GetConnectionString("database");

    options.UseSqlite(connectionString);
});
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<ClientType>();
builder.Services.AddScoped<ClientQuery>();
builder.Services.AddScoped<ISchema, ClientSchema>();
builder.Services.AddGraphQL(b => b
    .AddAutoSchema<ClientQuery>()  // schema
    .AddSystemTextJson());   // serializer


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
    // migrate database, only during development
    using var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<Database>();
    await db.Database.MigrateAsync();
    DataSeeder.SeedData(db);
}

app.UseHttpsRedirection();

//app.UseAuthorization();

app.UseWebSockets();
app.UseGraphQL("/graphql");            // url to host GraphQL endpoint
//app.UseGraphQL<ISchema>("/graphql");            // url to host GraphQL endpoint
app.UseGraphQLPlayground(
    "/",                               // url to host Playground at
    new GraphQL.Server.Ui.Playground.PlaygroundOptions
    {
        GraphQLEndPoint = "/graphql",         // url of GraphQL endpoint
        SubscriptionsEndPoint = "/graphql",   // url of GraphQL endpoint
    });

//app.MapControllers();


await app.RunAsync();
