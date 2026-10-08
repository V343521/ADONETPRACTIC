using System;
using System.Collections.Generic;
using System.Text;
namespace ADONETPRACTIC.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Product> Products { get; set; } = new();
    }
}