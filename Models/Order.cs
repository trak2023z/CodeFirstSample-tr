using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstSample.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsOpen { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}