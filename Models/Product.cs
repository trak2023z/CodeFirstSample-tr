using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstSample.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Column("Name",TypeName ="ntext")]
        [MaxLength(30)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
