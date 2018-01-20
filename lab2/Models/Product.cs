using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab2.Models
{
    public class Product
    {
        [Required]
        [Key]
        public string PRODUCT_ID { get; set; }
        [Required]
        public string BRAND { get; set; }
        
        [Required]
        public string TYPE { get; set; }
        public string DESCRIPTION { get; set; }

        public string PICNAME { get; set; }


    }

}