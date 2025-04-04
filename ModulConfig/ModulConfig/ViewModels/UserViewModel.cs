using ModulConfig.Models;
using ModulConfig.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulConfig.ViewModels
{
    public class UserViewModel
    {
        private User user;

        private IRepository<User> userRepo;

        public string Name { get; set; }
        public string Initials { get; set; }

        public UserViewModel(IRepository<User> userRepository)
        {
            userRepo = userRepository;

            user = new User(Name, Initials);
            userRepo.Create(user);
        }
    }
}
