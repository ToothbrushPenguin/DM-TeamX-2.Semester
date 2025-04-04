using ModulConfig.Models;
using ModulConfig.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulConfig.ViewModels
{
    public class SupportNoteViewModel
    {
        private SupportNote supportNote;

        public int Note_ID { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public bool Remark { get; set; }

        public SupportNoteViewModel(SupportNote supportNote)
        {
            this.supportNote = supportNote;
            Note_ID = supportNote.Note_ID;
            Date = supportNote.Date;
            Title = supportNote.Title;
            Message = supportNote.Message;
            Remark = supportNote.Remark;
           
        }

    }
}
