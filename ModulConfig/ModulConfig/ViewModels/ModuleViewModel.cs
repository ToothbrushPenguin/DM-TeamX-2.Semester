using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using ModulConfig.Models;
using ModulConfig.Persistence;

namespace ModulConfig.ViewModels
{
    public class ModuleViewModel
    {
        #region Fields And Properties
        private Module module;
        private string moduleJson;
        private string _filePath;
        private IRepository<Module> moduleRepository;

        private string serialNumber;
        private string model;
        private string variant;
        private DateOnly installationDay;
        private string keyID;
        private string publicKey;
        private string supportAPIVersion;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string SerialNumber
        {
            get => serialNumber;
            set
            {
                if (serialNumber != value)
                {
                    serialNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Model
        {
            get => model;
            set
            {
                if (model != value)
                {
                    model = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Variant
        {
            get => variant;
            set
            {
                if (variant != value)
                {
                    variant = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateOnly InstallationDay
        {
            get => installationDay;
            set
            {
                if (installationDay != value)
                {
                    installationDay = value;
                    OnPropertyChanged();
                }
            }
        }

        public string KeyID
        {
            get => keyID;
            set
            {
                if (keyID != value)
                {
                    keyID = value;
                    OnPropertyChanged();
                }
            }
        }

        public string PublicKey
        {
            get => publicKey;
            set
            {
                if (publicKey != value)
                {
                    publicKey = value;
                    OnPropertyChanged();
                }
            }
        }

        public string SupportAPIVersion
        {
            get => supportAPIVersion;
            set
            {
                if (supportAPIVersion != value)
                {
                    supportAPIVersion = value;
                    OnPropertyChanged();
                }
            }
        }

        public string FilePath
        {
            get => _filePath;
            set
            {
                if (_filePath != value)
                {
                    _filePath = value;
                    OnPropertyChanged();
                }
            }
        } 
        #endregion
        public RelayCommand SelectFileCmd => new RelayCommand(e => SelectFile());

        public ModuleViewModel(IRepository<Module> moduleRepository)
        {
         this.moduleRepository = moduleRepository;
        }
        public ModuleViewModel(Module module)
        {
            this.module = module;
            SerialNumber = module.SerialNumber;
            Model = module.Model;
            Variant = module.Variant;
            InstallationDay = module.InstallationDay;
            KeyID = module.KeyID;
            PublicKey = module.PublicKey;
            SupportAPIVersion = module.SupportAPIVersion;
        }

        public void SelectFile()
        {
            var initialFileDir = System.IO.Path.GetFullPath("../Documents");
            Module newModule = null;
            var fileDialog = new OpenFileDialog()
            {
                InitialDirectory = initialFileDir,
                Filter = "Json files (*.json)|*.json|All files (*.*)|*.*",
                RestoreDirectory = true
            };
            if (fileDialog.ShowDialog() == true)
            {
                FilePath = fileDialog.FileName;
                if (File.Exists(FilePath))
                {
                    moduleJson = File.ReadAllText(FilePath);
                    newModule = new Module(moduleJson);
                    MessageBox.Show("Topmodul indlæst");

                }
            }

            ModuleRepository moduleRepo = new ModuleRepository();
            moduleRepo.Create(newModule);
        }
    }
}
