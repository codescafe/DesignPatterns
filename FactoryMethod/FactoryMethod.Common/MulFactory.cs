using SimpleFactoryCommon;

namespace FactoryMethod.Common
{
    public class MulFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationMul();
        }
    }
}
