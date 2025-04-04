using ModulConfig.Models;
using ModulConfig.Persistence;
using ModulConfig.Views;
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

        public void GetUser()
        {
            var user = userRepo.ReadAll().FirstOrDefault(u => u.Initials == Initials);
            if (user != null)
            {
                Name = user.Name;
                Initials = user.Initials;
                MainWindow.NavigationFrame.Navigate(new InformationView());
            }
            else
            {
                throw new Exception("User not found");
            }
        }
    }
}
