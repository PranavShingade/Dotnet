using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace CodeFirstTest1.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public Guid CustomerId { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string ItemName { get; set; }

        [Required]
        public decimal ItemPrice { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get;set;}



    }
}
