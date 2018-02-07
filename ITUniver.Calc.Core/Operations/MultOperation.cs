using ITUniver.Calc.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.Calc.Core.Operations
{
    public class MultOperation : IOperation
    {
        public int argCount
        {
            get { return 2; }

        }

        public string Name => "mult";

        public double Exec(double[] args)
        {
            return args.Aggregate((x, y) => x * y);
        }
    }

}
