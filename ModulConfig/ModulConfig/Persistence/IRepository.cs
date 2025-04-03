using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModulConfig.Persistence
{
    public interface IRepository<T>
    {
        void Create(T obj);
        IEnumerable<T> ReadAll();
        void Update(T obj);
        void Delete(T obj);
    }
}
