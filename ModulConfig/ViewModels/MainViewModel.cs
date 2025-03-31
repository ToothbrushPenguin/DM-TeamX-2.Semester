using ModulConfig.Persistence;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulConfig.Models;

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
        }
    }
}
