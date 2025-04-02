using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulConfig.Models;

namespace ModulConfig.Persistence
{
    public class SBCRepository : RepositoryBase, IRepository<SBC>
    {
        private List<SBC> sbcs;
        public SBCRepository()
        {
            Implement();
            sbcs = new List<SBC>();
        }

        public SBC Create(SBC obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(SBC obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SBC> ReadAll()
        {
            throw new NotImplementedException();
        }

        public SBC Update(SBC obj)
        {
            throw new NotImplementedException();
        }
    }
}
