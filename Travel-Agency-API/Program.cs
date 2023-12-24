using Microsoft.EntityFrameworkCore;
using Travel_Agency_API.Services.Dossiers;
using Travel_Agency_Project.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add DbContext
builder.Services.AddDbContext<Database>(options => {
    var config = builder.Configuration;
    var connectionString = config.GetConnectionString("database");

    options.UseSqlite(connectionString);
});

builder.Services.AddScoped<IDossierService, DossierService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    // migrate database, only during development
    using var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<Database>();
    await db.Database.MigrateAsync();
    DataSeeder.SeedData(db);
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
