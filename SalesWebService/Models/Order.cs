using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebService.Models
{
    public class Order
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public Order()
        {

        }
    }
}
