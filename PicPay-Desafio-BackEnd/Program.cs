using Microsoft.EntityFrameworkCore;
using PicPay_Desafio_BackEnd.Infra;
using PicPay_Desafio_BackEnd.Infra.Repository.Carteiras;
using PicPay_Desafio_BackEnd.Infra.Repository.Transferencias;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
builder.Services.AddDbContext<ApplicationDbContext>(options => 
options.UseMySql(builder.Configuration.GetConnectionString("defaultConnection"), serverVersion));

builder.Services.AddScoped<ICarteiraRepository, CarteiraRepository>();
builder.Services.AddScoped<ITransferenciaRepository, TransferenciaRepository>();

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
