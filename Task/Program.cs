using System.Configuration;
using System.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//Services.AddDbContext<LeadsContext>(options =>
//options.UseMySQL(Configuration.GetConnectionString("mysqll")));


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
