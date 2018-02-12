using ITUniver.Calc.DB.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.Calc.DB.Repositories
{
    public interface IEntity
    {
        long Id { get; set; }
    }

    public interface IBaseRepository<T>
        where T : IEntity
    {
        T Find(long id);

        void Save(T item);

        void Delete(long id);

        IEnumerable<T> GetAll();


    }
}
