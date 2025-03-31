using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulConfig.Models
{
    public class SBC
    {
        public string Model { get; set; }
        public string SerialNumber { get; set; }


        public SBC(string model, string serialNumber)
        {
            Model = model;
            SerialNumber = serialNumber;
        }
    }
}
