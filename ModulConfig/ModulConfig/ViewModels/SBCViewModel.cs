using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulConfig.Models;

namespace ModulConfig.ViewModels
{
    public class SBCViewModel
    {
        private SBC sbc;

        public string Model {  get; set; }
        public string SerialNumber { get; set; }

        public SBCViewModel(SBC sbc)
        {
            this.sbc = sbc;
            Model = sbc.Model;
            SerialNumber = sbc.SerialNumber;
        }
    }
}
