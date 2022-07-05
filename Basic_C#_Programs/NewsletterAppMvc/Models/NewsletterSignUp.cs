using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsletterAppMvc.Models
{
    public class NewsletterSignUp
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string socialSecurityNumber { get; set; }
    }
}