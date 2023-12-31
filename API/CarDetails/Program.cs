using CarDetails.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(optionsAction: opt =>
  {
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
 });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
