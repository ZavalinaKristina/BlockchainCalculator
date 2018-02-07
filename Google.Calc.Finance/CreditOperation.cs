using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Calc.Finance
{
    public class CreditOperation: ITUniver.Calc.Core.Interface.IOperation
    {
        public int argCount
        {
            get { return 2; }

        }
        public string Name => "credit";

        public double Exec(double[] args)
        {
            return args.Aggregate((x, y) => (x*1.094) / y);
        }
    }
}
