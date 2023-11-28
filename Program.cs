using RestEncuestasAPI.Data;
using RestEncuestasAPI.Data.Repositories;
using RestEncuestasAPI.Extensions;
using RestEncuestasAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// DbContexts
builder.Services.AddDbContext<EncuestaContext>();
// Repositories and services
builder.Services.AddScoped<IEncuestaRepository, EncuestaRepository>();
builder.Services.AddScoped<IEncuestasService, EncuestasService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

app.EnsureDbCreated();

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
