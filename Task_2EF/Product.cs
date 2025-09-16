using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2EF
{
    internal class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Unicode (false)]
        public string? Name { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string? Description { get; set; } = "no description";
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Sales { get; set; }
    }

        [PrimaryKey(nameof(CustomerId))]
    class Customers
    {
        public int CustomerId { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Unicode(false)]
        public string? Name { get; set; }

        [Column(TypeName = "varchar(80)")]
        [Unicode(true)]
        public string? Email { get; set; }
  
        public string? CreaditCardNumber { get; set; }
        public int Sales { get; set; }
    }

    class Store
    {
        [Key]
        public int StoreId { get; set; }
        [Column(TypeName = "varchar(80)")]
        [Unicode(false)]
        public string? Name { get; set; }
        public int Sales { get; set; }
    }

    class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int CustomerId { get; set; }
        public Customers? Customer { get; set; }
        public int StoreId { get; set; }
        public Store? Store { get; set; }
    }
}
