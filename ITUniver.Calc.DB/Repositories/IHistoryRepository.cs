using ITUniver.Calc.DB.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.Calc.DB.Repositories
{

    public interface IHistoryRepository : IBaseRepository<IHistoryItem>
    {
       // IHistoryItem GetByOperation(long Id);
     }

    public interface IOperationRepository : IBaseRepository<Operation>
    {
    }
}
