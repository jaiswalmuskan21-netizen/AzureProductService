using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using productservice.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Configuration.AddAzureKeyVault( 
    new Uri("https://muskankeyvaultkey.vault.azure.net/"),
    new DefaultAzureCredential()); // connector for manage identity(for local development)// defaultconnection will refer secret key

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration["MuskanSecretConnectionString1"]));


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();


