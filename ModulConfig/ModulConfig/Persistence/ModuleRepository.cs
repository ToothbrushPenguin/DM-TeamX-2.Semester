﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulConfig.Models;

namespace ModulConfig.Persistence
{
    public class ModuleRepository : RepositoryBase, IRepository<Module>
    {
        public ModuleRepository()
        {
            Implement();
            modules = new List<Module>();

        }
        private List<Module> modules;

        public Module Create(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Delete(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Module> GetAll()
        {
            throw new NotImplementedException();
        }

        public Module Read(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Module Update(params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
