using FactoryMethod.Common;
using SimpleFactoryCommon;

IFactory factory = new AddFactory();
Operation operation = factory.CreateOperation();
operation.NumberA = 1;
operation.NumberB = 2;
Console.WriteLine(operation.GetResult());