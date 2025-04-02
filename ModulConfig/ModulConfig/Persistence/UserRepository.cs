using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulConfig.Models;

namespace ModulConfig.Persistence
{
    public class UserRepository : RepositoryBase, IRepository<User>
    {
        public UserRepository()
        {
            Implement();
            users = new List<User>();
        }
        private List<User> users;
        public User Create(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Delete(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User Read(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public User Update(params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
