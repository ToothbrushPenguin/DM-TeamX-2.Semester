using ModulConfig.Persistence;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulConfig.Models;
using System.Windows.Input;
using System.Windows;
using System.Windows.Navigation;
using ModulConfig.Views;

namespace ModulConfig.ViewModels
{
    internal class MainViewModel 
    {
        private IRepository<Company> companyRepository;
        private IRepository<User> userRepository;
        private IRepository<SupportNote> supportNoteRepository;
        private IRepository<SBC> sbcRepository;
        private IRepository<IOBoard> ioBoardRepository;
        private IRepository<Module> moduleRepository;

        public ObservableCollection<CompanyViewModel> CompanyVMs { get; set; }
        public ObservableCollection<UserViewModel> UserVMs { get; set; }
        public ObservableCollection<SupportNoteViewModel> SupportNoteVMs { get; set; }
        public ObservableCollection<SBCViewModel> SBCVMs { get; set; }
        public ObservableCollection<IOBoardViewModel> IOBoardVMs { get; set; }
        public ObservableCollection<ModuleViewModel> ModuleVMs { get; set; }

        public ICommand CreateUserCommand { get; set; }
        public ICommand GetUserCommand { get; set; }    

        public string IntialsTextField { get; set; }
        public string NameTextField { get; set; }

        UserViewModel SelectedUser_VM;
        public MainViewModel()
        {
            companyRepository = new CompanyRepository();
            userRepository = new UserRepository();
            supportNoteRepository = new SupportNoteRepository();
            sbcRepository = new SBCRepository();
            ioBoardRepository = new IOBoardRepository();
            moduleRepository = new ModuleRepository();
            CompanyVMs = new ObservableCollection<CompanyViewModel>();
            UserVMs = new ObservableCollection<UserViewModel>();
            SupportNoteVMs = new ObservableCollection<SupportNoteViewModel>();
            SBCVMs = new ObservableCollection<SBCViewModel>();
            IOBoardVMs = new ObservableCollection<IOBoardViewModel>();
            ModuleVMs = new ObservableCollection<ModuleViewModel>();

            CreateUserCommand = new RelayCommand(e => CreateNewUser());
            GetUserCommand = new RelayCommand(e => GetUser());

        }
        //Create new user and returns user to User_Vm list
        public void CreateNewUser()
        {
            User user = new User(IntialsTextField, NameTextField);
            userRepository.Create(user);
            UserViewModel user_VM = new UserViewModel(user); 
            UserVMs.Add(user_VM);

            MessageBox.Show($"User Created {user_VM.Initials} {user_VM.Name}");
        }

        //Gets User from login initials and opens information window
        public void GetUser()
        {
            SelectedUser_VM = UserVMs.FirstOrDefault(u => u.Initials == IntialsTextField);
            MainWindow.NavigationFrame.Navigate(new InformationView());
        }
    }
}
