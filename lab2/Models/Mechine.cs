using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab2.Models
{
    public class Mechine//:Product
    {
        [Required]
        [Key]
        public string PRODUCT_ID { get; set; }
        [Required]
        public string NAME { get; set; }
        [Required]
        public double PRICE { get; set; }

        public double MAX_WEIGHT { get; set; }
    }
}