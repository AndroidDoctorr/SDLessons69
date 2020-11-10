using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _12_GeneralStore.Models
{
    public class Restock
    {
        [Required]
        public int Quantity { get; set; }
    }
}