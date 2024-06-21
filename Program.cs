using Microsoft.EntityFrameworkCore;
using Proyecto_GalleryVibe_Web.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DBContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("CadenadeConexion"))
    );
var app = builder.Build();

using (var scop = app.Services.CreateScope())
{
    var data = scop.ServiceProvider.GetRequiredService<DBContext>();
    data.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); 
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
