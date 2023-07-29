using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.Service
{
    public interface IService<T> where T : class
    {
        int Insert(T t);

        int Delete(T t);
        int Update(T t);
        T Select(int Id);
        T Select(string Name);
        List<T> Select();
    }
}
