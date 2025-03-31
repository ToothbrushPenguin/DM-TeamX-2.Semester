using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulConfig.Models
{
    public class User
    {
        public string Name { get; set; }
        
        public string Initials { get; set; }

        public User(string name, string initials)
        {
            Name = name;
            Initials = initials;
        }
    }
}
