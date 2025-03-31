using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulConfig.Models
{
    class SupportNote
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Remark { get; set; }

        public SupportNote(DateTime date, string title, string message, string remark)
        {
            Date = date;
            Title = title;
            Message = message;
            Remark = remark;
        }
    }
}
