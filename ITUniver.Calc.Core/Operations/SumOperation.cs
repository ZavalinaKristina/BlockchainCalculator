using ITUniver.Calc.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.Calc.Core.Operations
{
    public class SumOperation : IOperation
    {
        public int argCount
        {
            get { return 2; }

        }

        public string Name => "sum";

        public double Exec(double[] args)
        {
            return args.Sum();
        }
    }

}
