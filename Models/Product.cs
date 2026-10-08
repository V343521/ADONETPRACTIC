using System;
using System.Collections.Generic;
using System.Text;
namespace ADONETPRACTIC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}