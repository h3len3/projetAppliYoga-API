using Microsoft.EntityFrameworkCore;
using ProjetYoga.Application.Interfaces;
using ProjetYoga.Application.Interfaces.Repositories;
using ProjetYoga.Application.Interfaces.Services;
using ProjetYoga.Application.Services;
using ProjetYoga.Infrastructure;
using ProjetYoga.Infrastructure.Repositories;
using ProjetYoga.Infrastructure.Smtp;
using System.Net.Mail;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//
builder.Services.AddDbContext<ProjetYogaContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("Main"))
);

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IEventRepository, EventRepository>();
builder.Services.AddScoped<IEventService, EventService>();
builder.Services.AddScoped<IAdeptRepository, AdeptRepository>();
builder.Services.AddScoped<IAdeptService, AdeptService>();
builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IPlaceEventYogaService, PlaceEventYogaService>();
builder.Services.AddScoped<IPlaceEventYogaRepository, PlaceEventYogaRepository>();
builder.Services.AddScoped<ITypeSubRepository, TypeSubRepository>();
builder.Services.AddScoped<ITypeSubService, TypeSubService>();
builder.Services.AddScoped<IPaymentModeRepository, PaymentModeRepository>();
builder.Services.AddScoped<IPaymentModeService, PaymentModeService>();
//

// Pour envoi de mails
builder.Services.AddScoped(c => new SmtpClient
{
    Host = builder.Configuration["Smtp:Host"] ?? throw new Exception("Missing Smtp Configuration"),
    Port = int.Parse(builder.Configuration["Smtp:Port"] ?? throw new Exception("Missing Smtp Configuration")),
    Credentials = new NetworkCredential
    {
        UserName = builder.Configuration["Smtp:Username"] ?? throw new Exception("Missing Smtp Configuration"),
        Password = builder.Configuration["Smtp:Password"] ?? throw new Exception("Missing Smtp Configuration"),
    }

});
builder.Services.AddScoped<IMailer, Mailer>();
//

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
