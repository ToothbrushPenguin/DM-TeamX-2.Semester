using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulConfig.Models;

namespace ModulConfig.ViewModels
{
    internal class ModuleViewModel
    {
        private Module module;

        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string Variant { get; set; }
        public DateOnly InstallationDay { get; set; }
        public string KeyID { get; set; }
        public string PublicKey { get; set; }
        public string SupportAPIVersion { get; set; }

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
    }
}
