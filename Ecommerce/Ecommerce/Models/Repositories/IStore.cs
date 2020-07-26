using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models.Repositories
{
    public interface IStore<T>
    {
        List<T> List();
        T Find(int? id);

        void ADD(T Model);
        void Update(int id, T Model);
        void Delete(int id);
    }
}
