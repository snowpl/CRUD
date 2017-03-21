using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Data.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        public int TelephoneNumber { get; set; }

        public string Address { get; set; }

    }
}
