using TemplateMethod.Common;

Console.WriteLine("The test paper of Student A: ");
TestPaperA studentA = new TestPaperA();
studentA.TestQuestion1();
studentA.TestQuestion2();
studentA.TestQuestion3();

Console.WriteLine("The test paper of Student B: ");
TestPaperB studentB = new TestPaperB();
studentB.TestQuestion1();
studentB.TestQuestion2();
studentB.TestQuestion3();
