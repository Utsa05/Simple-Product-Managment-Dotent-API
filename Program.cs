using Microsoft.EntityFrameworkCore;
using PRODUCTMANAGEMENTAPI.Data;
using PRODUCTMANAGEMENTAPI.Interfaces;
using PRODUCTMANAGEMENTAPI.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddDbContext<AppDBContext>(options=>options.UseInMemoryDatabase("ProductDb"));

builder.Services.AddScoped<IProductInterface,ProudctService>();

var app = builder.Build();


app.Run();
