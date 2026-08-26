using Azure.Identity;
using DiscountService.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddAzureKeyVault( 
    new Uri("https://muskankeyvaultkey.vault.azure.net/"),
    new DefaultAzureCredential());



builder.Services.AddControllers();

// builder.Services.AddDbContext<DiscountDBContext>(options =>
//     options.UseSqlServer("Server=tcp:yamanserver.database.windows.net,1433;Initial Catalog=ProductDB;Persist Security Info=False;User ID=sqlserveradmin;Password=admin@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));  //secret key name
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DiscountDBContext>(options => options.UseSqlServer(builder.Configuration["MuskanSecretConnectionString1"]));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();