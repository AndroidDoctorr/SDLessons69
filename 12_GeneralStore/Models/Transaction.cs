using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _12_GeneralStore.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        // Joining table - joins/connects two other tables

        [Required]
        public int ProductID { get; set; }

        [ForeignKey(nameof(ProductID))]
        public virtual Product Product { get; set; }


        [Required]
        public int CustomerID { get; set; }

        // [ForeignKey(nameof(CustomerID))]
        // public virtual Customer Customer { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateofTransaction { get; set; }

        public int Quantity { get; set; }
    }
}