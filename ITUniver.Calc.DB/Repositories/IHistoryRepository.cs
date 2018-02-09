using ITUniver.Calc.DB.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.Calc.DB.Repositories
{

    public interface IHistoryRepository
    {
        IHistoryItem Find(long id);

        void Save(IHistoryItem item);

        void Delete(long id);

        IEnumerable<IHistoryItem> GetAll();


    }
}
