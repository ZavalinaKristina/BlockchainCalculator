using ITUniver.Calc.DB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.Calc.DB.Modules
{
    public interface IHistoryItem : IEntity
    {

        long Operation { get; set; }
        string Args { get; set; }
        double? Result { get; set; }
        DateTime ExecDate { get; set; }
    }


}
