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
        private List<IOBoard> ioBoards;
        public IOBoardRepository()
        {
            Implement();
            ioBoards = new List<IOBoard>();
        }

        public IOBoard Create(IOBoard obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(IOBoard obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IOBoard> ReadAll()
        {
            throw new NotImplementedException();
        }

        public IOBoard Update(IOBoard obj)
        {
            throw new NotImplementedException();
        }
    }
}
    
