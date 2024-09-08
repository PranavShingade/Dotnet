using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace CodeFirstTest1.Models
{
    public class Customer
    {
        [Key]
        public Guid CustomerID { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)" )]
        public String FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public String LastName { get; set; }

        [Required]
        public DateTime DOB { get; set; }

    }
}
