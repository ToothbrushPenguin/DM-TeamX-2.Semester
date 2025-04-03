using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using ModulConfig.Models;
using ModulConfig.Persistence;

namespace ModulConfig.ViewModels
{
    internal class ModuleViewModel
    {
        private Module module;
        private string moduleJson;
        private string _filePath;

        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string Variant { get; set; }
        public DateOnly InstallationDay { get; set; }
        public string KeyID { get; set; }
        public string PublicKey { get; set; }
        public string SupportAPIVersion { get; set; }

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        public RelayCommand SelectFileCmd => new RelayCommand(e => SelectFile());

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

        // Only used for testing - used in datacontext in informationView.xaml.cs
        public ModuleViewModel()
        {

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
