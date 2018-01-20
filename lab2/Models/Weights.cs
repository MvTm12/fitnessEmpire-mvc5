using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab2.Models
{
    public class Weights //:Product
    {
        [Required]
        [Key]
        public string PRODUCT_ID { get; set; }
        [Required]
        public string WEIGHT_TYPE { get; set; }
        [Required]
        public double PRICE_OF1 { get; set; }

        [Required]
        public double WEIGHT { get; set; }

        [Required]
        public string COVERED { get; set; }

    }
}