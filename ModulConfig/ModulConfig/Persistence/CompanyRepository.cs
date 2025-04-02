using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulConfig.Models;

namespace ModulConfig.Persistence
{
    public class CompanyRepository : RepositoryBase, IRepository<Company>
    {
        private List<Company> companies;

        public CompanyRepository()
        {
            Implement();
            companies = new List<Company>();
        }

        public Company Create(Company obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Company obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Company Update(Company obj)
        {
            throw new NotImplementedException();
        }
    }
}

