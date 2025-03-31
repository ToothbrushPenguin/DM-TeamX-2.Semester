using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulConfig.Models
{
    class IOBoard
    {
        public string ApplicationVersion { get; set; }
        public string KernelVersion { get; set; }
        public string BoardModel { get; set; }

        public IOBoard(string applicationVersion, string kernelVersion, string boardModel)
        {
            ApplicationVersion = applicationVersion;
            KernelVersion = kernelVersion;
            BoardModel = boardModel;
        }
    }
}
