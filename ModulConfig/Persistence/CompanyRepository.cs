using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulConfig.Models;

namespace ModulConfig.Persistence
{
    public class CompanyRepository : IRepository<Company>
    {
        private List<Company> companies;

        public Company Create(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Delete(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAll()
        {
            throw new NotImplementedException();
        }

        public Company Read(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Company Update(params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}

