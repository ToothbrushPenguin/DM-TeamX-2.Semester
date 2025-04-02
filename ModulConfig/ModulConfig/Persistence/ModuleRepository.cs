using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulConfig.Models;

namespace ModulConfig.Persistence
{
    public class ModuleRepository : RepositoryBase, IRepository<Module>
    {
        private List<Module> modules;
        public ModuleRepository()
        {
            Implement();
            modules = new List<Module>();

        }

        public Module Create(Module obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Module obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Module> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Module Update(Module obj)
        {
            throw new NotImplementedException();
        }
    }
}
