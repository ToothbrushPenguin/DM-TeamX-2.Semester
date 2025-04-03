using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ModulConfig.Models
{
    public class Module
    {
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string Variant { get; set; }
        public DateOnly Date { get; set; }
        public string KeyID { get; set; }
        public string PublicKey { get; set; }
        public string SupportAPIVersion { get; set; }
        public Module(string moduleJson)
        {
            using (JsonDocument doc = JsonDocument.Parse(moduleJson))
            {
                JsonElement root = doc.RootElement;

                SerialNumber = root.GetProperty("serial").GetString();
                Model = root.GetProperty("model").GetString();
                Variant = root.GetProperty("variant").GetString();

                // Konverter DateTime til DateOnly
                DateTime parsedDate = root.GetProperty("date").GetDateTime();
                Date = DateOnly.FromDateTime(parsedDate);

                // key -> id og public_key
                if (root.TryGetProperty("key", out JsonElement keyElement))
                {
                    KeyID = keyElement.GetProperty("id").GetString();
                    PublicKey = keyElement.GetProperty("public_key").GetString();
                }

                // supportapi -> version
                if (root.TryGetProperty("supportapi", out JsonElement supportElement))
                {
                    SupportAPIVersion = supportElement.GetProperty("version").GetString();
                }
            }
        }
    }
}
