using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulConfig.Models
{
    public class Module
    {
        public string Serial { get; set; }
        public string Model { get; set; }
        public string Variant { get; set; }
        public DateOnly Date { get; set; }
        public string ID { get; set; }
        public string Public_Key { get; set; }
        public string SupportAPI { get; set; }

        public Module(string moduleJson)
        {
            
        }
    }
}
