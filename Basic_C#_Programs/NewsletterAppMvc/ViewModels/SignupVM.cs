using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsletterAppMvc.ViewModels
{
    public class SignupVM
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
    }
}