using ModulConfig.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulConfig.ViewModels
{
    internal class UserViewModel
    {
        private User user;

        public string Name { get; set; }
        public string Initials { get; set; }

        public UserViewModel(User user)
        {
            this.user = user;

            Name = user.Name;
            Initials = user.Initials;
        }
    }
}
