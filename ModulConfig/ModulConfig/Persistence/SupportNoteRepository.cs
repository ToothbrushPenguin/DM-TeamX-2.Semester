using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulConfig.Models;

namespace ModulConfig.Persistence
{
    public class SupportNoteRepository : RepositoryBase, IRepository<SupportNote>
    {
        private List<SupportNote> supportNotes;
        public SupportNoteRepository()
        {
            Implement();
            supportNotes = new List<SupportNote>();
        }

        public SupportNote Create(SupportNote obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(SupportNote obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SupportNote> ReadAll()
        {
            throw new NotImplementedException();
        }

        public SupportNote Update(SupportNote obj)
        {
            throw new NotImplementedException();
        }
    }
}
