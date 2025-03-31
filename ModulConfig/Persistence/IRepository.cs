using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModulConfig.Persistence
{
    public interface IRepository<T>
    {
        T Create(params object[] parameters);
        T Read(params object[] parameters);
        IEnumerable<T> GetAll();
        T Update(params object[] parameters);
        void Delete(params object[] parameters);
    }
}
