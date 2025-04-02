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
        public SBCRepository()
        {
            Implement();
            sbcs = new List<SBC>();
        }

        private List<SBC> sbcs;
        public SBC Create(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Delete(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SBC> GetAll()
        {
            throw new NotImplementedException();
        }

        public SBC Read(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public SBC Update(params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
