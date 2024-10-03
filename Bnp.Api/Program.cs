using Bnp.Application.Interfaces;
using Bnp.Application.Services;
using Bnp.Application.Validations;
using Bnp.Infrastructure.Interfaces;
using Bnp.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISecurityService, SecurityService>();
builder.Services.AddScoped<IExternalCall, ExternalCall>();
builder.Services.AddScoped<ISecurityRepository, SecurityRepository>();
builder.Services.AddSingleton<IsinValidations>();

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
