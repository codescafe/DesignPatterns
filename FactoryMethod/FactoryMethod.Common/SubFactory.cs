using SimpleFactoryCommon;

namespace FactoryMethod.Common
{
    public class SubFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }
}
