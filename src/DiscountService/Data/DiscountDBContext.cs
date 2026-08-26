using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscountService.Models;
using Microsoft.EntityFrameworkCore;

namespace DiscountService.Data
{
    public class DiscountDBContext: DbContext
    {
        public DiscountDBContext(DbContextOptions<DiscountDBContext> options) : base(options)
        {

        }

        public DbSet<Discount> Discounts { get; set; }
    }
}