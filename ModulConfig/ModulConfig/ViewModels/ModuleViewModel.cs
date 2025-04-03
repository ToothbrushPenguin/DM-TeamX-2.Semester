using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        public DateOnly InstallationDay { get; set; }
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
            SerialNumber = module.SerialNumber;
            Model = module.Model;
            Variant = module.Variant;
            InstallationDay = module.InstallationDay;
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
            

            return newModule;
        }

        private void SelectFile()
        {
            var fileDialog = new OpenFileDialog()
            {
                InitialDirectory = "../Documents",
                Filter = "Image files (*.bmp, *.jpg)|*.bmp;*.jpg|All files (*.*)|*.*",
                RestoreDirectory = true
            };
            if (fileDialog.ShowDialog() == true)
            {
                FilePath = fileDialog.FileName;
            } 
        }
    }
}
