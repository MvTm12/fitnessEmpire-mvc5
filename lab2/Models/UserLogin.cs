using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab2.Models
{
    public class UserLogin
    {
        [Required]
        [Key]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "User ID must contain 9 digits")]
        public string USER_ID { get; set; }

        [Required]
        public string PASSWORD { get; set; }
    }
}