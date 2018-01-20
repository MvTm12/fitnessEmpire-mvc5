using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab2.Models
{
    public class User
    {
        [Key]
        [Required]
        [StringLength(9, MinimumLength = 9,ErrorMessage ="User ID must contain 9 digits")]
        public string USER_ID { get; set; }


        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "User name length must be between 2 to 20 characters")]
        public string PASSWORD { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "First name length must be between 2 to 20 characters")]
        public string  FNAME { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Last name length must be between 2 to 20 characters")]
        public string LNAME { get; set; }
        
        
        public string Roles { get; set; }
    }
}