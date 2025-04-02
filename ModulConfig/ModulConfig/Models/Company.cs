using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulConfig.Models
{
    public class Company
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }

        public Company(string name, string email, string contact)
        {
            Name = name;
            Email = email;
            Contact = contact;
        }
    }
}
