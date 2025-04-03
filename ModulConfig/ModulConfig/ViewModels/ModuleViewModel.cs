using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
using ModulConfig.Models;

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
        public DateTime InstallationDay { get; set; }
        public string KeyID { get; set; }
        public string PublicKey { get; set; }
        public string SupportAPIVersion { get; set; }

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        public RelayCommand SelectFileCmd => new RelayCommand(execute => SelectFile(), canExecute => true);

        public ModuleViewModel(Module module)
        {
            this.module = module;
            SerialNumber = module.serial;
            Model = module.model;
            Variant = module.variant;
            InstallationDay = module.date;
            KeyID = module.KeyID;
            PublicKey = module.PublicKey;
            SupportAPIVersion = module.SupportAPIVersion;
        }

        public ModuleViewModel()
        {
            
        }

        public Module ImportFromJson()
        {
            Module newModule = null;
            if (File.Exists(FilePath))
            {
                moduleJson = File.ReadAllText(FilePath);
                if (!string.IsNullOrWhiteSpace(moduleJson))
                {
                    newModule = JsonSerializer.Deserialize<Module>(moduleJson);
                }
            }

            Debug.WriteLine(newModule.model);
            return newModule;
        }

        private void SelectFile()
        {
            var initialFileDir = System.IO.Path.GetFullPath("../Documents");
            var fileDialog = new OpenFileDialog()
            {
                InitialDirectory = initialFileDir,
                Filter = "Json files (*.json)|*.json|All files (*.*)|*.*",
                RestoreDirectory = true
            };
            if (fileDialog.ShowDialog() == true)
            {
                FilePath = fileDialog.FileName;
                ImportFromJson();
            } 
        }
    }
}
