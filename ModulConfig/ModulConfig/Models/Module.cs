using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulConfig.Models
{
    public class Module
    {
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string Variant { get; set; }
        public DateOnly InstallationDay { get; set; }
        public string KeyID { get; set; }
        public string PublicKey { get; set; }
        public string SupportAPIVersion { get; set; }

        public Module(string serialNumber, string model, string variant, DateOnly installationDay, string keyID, string publicKey, string supportAPIVersion)
        {
            SerialNumber = serialNumber;
            Model = model;
            Variant = variant;
            InstallationDay = installationDay;
            KeyID = keyID;
            PublicKey = publicKey;
            SupportAPIVersion = supportAPIVersion;
        }
    }
}
