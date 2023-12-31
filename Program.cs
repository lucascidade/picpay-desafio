using Microsoft.EntityFrameworkCore;
using picpay_desafio.Data;
using picpay_desafio.DTO;
using picpay_desafio.Interface.Repositories;
using picpay_desafio.Interface.Services;
using picpay_desafio.Repositories;
using picpay_desafio.Services;
using AutoMapper;
using picpay_desafio.UnitOfWork;
using picpay_desafio.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



//Garantindo que a interface ser� servida (injecao de dependencia)
builder.Services.AddScoped<IUserRepository, UserRepository>();

//Services DTO
builder.Services.AddScoped<IUserService, UserService>();

//unit of work
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//transaction
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<ITransactionService, TransactionService>();

builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PicpayDataContext>(options =>
options.UseSqlite("Data Source=./Database/picpay_desafio.db"));


builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
