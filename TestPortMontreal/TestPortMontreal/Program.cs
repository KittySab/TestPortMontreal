using TestPortMontreal.Application.Arrivees;
using TestPortMontreal.Application.Departs;
using TestPortMontreal.Infrastructure.Arrivees;
using TestPortMontreal.Infrastructure.Departs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IArriveeRepository, ArriveeRepository>();
builder.Services.AddScoped<IArriveeService, ArriveeService>();
builder.Services.AddScoped<IDepartRepository, DepartRepository>();
builder.Services.AddScoped<IDepartService, DepartService>();

var app = builder.Build();

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
