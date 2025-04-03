using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulConfig.Models
{
    public class Module
    {
        public string serial { get; set; }
        public string model { get; set; }
        public string variant { get; set; }
        public DateTime date { get; set; }
        public Key key{ get; set; }
        public string KeyID { get; set; }
        public string PublicKey { get; set; }
        public string SupportAPIVersion { get; set; }

        public Module(string serial, string model, string variant, DateTime date, string keyID, string publicKey, string supportAPIVersion)
        {
            serial = serial;
            this.model = model;
            this.variant = variant;
            date = date;
            Key key = new Key()
            {
                id = "54",
                public_key = "a"
            };
            KeyID = key.id;
            PublicKey = key.public_key;
            SupportAPIVersion = supportAPIVersion;
        }
    }
}

public class Key
{
    public string id { get; set; }
    public string public_key { get; set; }

    public Key()
    {
        
    }
}
