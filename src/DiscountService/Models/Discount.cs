using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountService.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public string ProductName  { get; set; }=  string.Empty;
        public decimal DiscountPercent  { get; set; }
    }
}