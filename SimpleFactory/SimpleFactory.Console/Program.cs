using SimpleFactoryCommon;

Operation operation = OperationFactory.CreateOperation("+");
operation.NumberA = 1;
operation.NumberB = 2;
Console.WriteLine(operation.GetResult());