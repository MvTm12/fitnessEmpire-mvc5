using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab2.Models
{
    public class UserVM
    {
        public User customer { get; set; }

        public List<User> customers { get; set; }
    }
}