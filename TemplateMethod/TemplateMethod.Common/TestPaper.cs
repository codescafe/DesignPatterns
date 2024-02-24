namespace TemplateMethod.Common
{
    public class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("Question 1: What is the capital of China?");
            Console.WriteLine("A. Beijing");
            Console.WriteLine("B. Shanghai");
            Console.WriteLine("C. Guangzhou");
            Console.WriteLine("D. Shenzhen");
            Console.WriteLine("Answer: " + Answer1());
        }

        public void TestQuestion2()
        {
            Console.WriteLine("Question 2: What is the capital of France?");
            Console.WriteLine("A. Paris");
            Console.WriteLine("B. Marseille");
            Console.WriteLine("C. Lyon");
            Console.WriteLine("D. Toulouse");
            Console.WriteLine("Answer: " + Answer2());
        }

        public void TestQuestion3()
        {
            Console.WriteLine("Question 3: What is the capital of Japan?");
            Console.WriteLine("A. Tokyo");
            Console.WriteLine("B. Osaka");
            Console.WriteLine("C. Nagoya");
            Console.WriteLine("D. Yokohama");
            Console.WriteLine("Answer: " + Answer3());
        }

        public virtual string Answer1()
        {
            return "Answer: A";
        }

        public virtual string Answer2()
        {
            return "Answer: A";
        }

        public virtual string Answer3()
        {
            return "Answer: A";
        }
    }
}
