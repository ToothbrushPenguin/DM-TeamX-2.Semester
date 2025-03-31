using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulConfig.Models
{
    public class SupportNote
    {
        public int Note_ID { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public bool Remark { get; set; }

        public SupportNote(int noteID, DateTime date, string title, string message, bool remark)
        {
            Note_ID = noteID;
            Date = date;
            Title = title;
            Message = message;
            Remark = remark;
        }
    }
}
