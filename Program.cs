using Microsoft.EntityFrameworkCore;
using picpay_desafio.Data;
using picpay_desafio.DTO;
using picpay_desafio.Interface.Repositories;
using picpay_desafio.Interface.Services;
using picpay_desafio.Repositories;
using picpay_desafio.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



//Garantindo que a interface será servida (injecao de dependencia)
builder.Services.AddScoped<IUserRepository, UserRepository>();

//Services DTO
builder.Services.AddScoped<IUserService, UserService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PicpayDataContext>(options =>
options.UseSqlite("Data Source=./Data/picpay_desafio.db"));
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
