using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulConfig.Models;

namespace ModulConfig.Persistence
{
    public class IOBoardRepository : RepositoryBase, IRepository<IOBoard>
    {
        public IOBoardRepository()
        {
            Implement();
            ioBoards = new List<IOBoard>();
        }

        private List<IOBoard> ioBoards;
        public IOBoard Create(params object[] parameters)
        {
            throw new NotImplementedException();
        }
        public void Delete(params object[] parameters)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<IOBoard> GetAll()
        {
            throw new NotImplementedException();
        }
        public IOBoard Read(params object[] parameters)
        {
            throw new NotImplementedException();
        }
        public IOBoard Update(params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
    
