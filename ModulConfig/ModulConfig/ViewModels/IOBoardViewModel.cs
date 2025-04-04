using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulConfig.Models;

namespace ModulConfig.ViewModels
{
    public class IOBoardViewModel
    {
        private IOBoard ioBoard;
        public string ApplicationVersion { get; set; }
        public string KernelVersion { get; set; }
        public string BoardModel {  get; set; }

        public IOBoardViewModel(IOBoard ioBoard)
        {
            this.ioBoard = ioBoard;
            ApplicationVersion = ioBoard.ApplicationVersion;
            KernelVersion = ioBoard.KernelVersion;
            BoardModel = ioBoard.BoardModel;
        }
    }
}
