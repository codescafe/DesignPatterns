using SimpleFactoryCommon;

namespace FactoryMethod.Common
{
    public class AddFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }
}
