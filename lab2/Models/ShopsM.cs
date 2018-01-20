using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab2.Models
{
    public class ShopsM
    {
        [Key]
        [Required]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "Shop ID length must be between 1 to 2 characters")]
        public string ID { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Shop name length must be between 2 to 20 characters")]
        public string City { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Shop address length must be between 2 to 30 characters")]
        public string Address { get; set; }
        [Required]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Shop phone number length must be 9 characters")]
        public string Phone { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Shop week days houres length must be 11 characters")]
        public string Week_days { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Shop weekend houres length must be 11 characters")]
        public string Week_end { get; set; }
    }
}
