using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CustomerProduct
    {
        [Key, Column(Order = 0)]
        public string CustomerId { get; set; }
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual ApplicationUser Customer { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}