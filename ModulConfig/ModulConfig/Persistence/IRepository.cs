using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModulConfig.Persistence
{
    public interface IRepository<T>
    {
        T Create(T obj);
        IEnumerable<T> ReadAll();
        T Update(T obj);
        void Delete(T obj);
    }
}
