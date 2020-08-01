using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}