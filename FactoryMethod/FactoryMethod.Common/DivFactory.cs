using SimpleFactoryCommon;

namespace FactoryMethod.Common
{
    public class DivFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationDiv();
        }
    }
}
