using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCommon
{
    public class OperationFactory
    {
        public static Operation CreateOperation(string operation) => operation switch
        {
            "+" => new OperationAdd(),
            "-" => new OperationSub(),
            "*" => new OperationMul(),
            "/" => new OperationDiv(),
            _ => throw new ArgumentException("Invalid operation")
        };
    }
}
