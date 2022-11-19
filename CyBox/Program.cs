using CyBox;
using CyBox.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);
// Add services to the container.
builder.Services.AddDbContext<CyBoxDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("StoreConnStr")));

startup.ConfigureServices(builder.Services); // calling ConfigureServices method
var app = builder.Build();
startup.Configure(app, builder.Environment); // calling Configure method

