using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCommon
{
    internal class OperationAdd : Operation
    {
        public override double GetResult() => NumberA + NumberB;
    }
}
