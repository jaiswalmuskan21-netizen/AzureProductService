using System;
using Microsoft.EntityFrameworkCore;
using productservice.Models;
//using Microsoft.EntityFrameworkCore;
namespace productservice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


    public DbSet<product> Products { get; set; }
    }
}