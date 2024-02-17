namespace Decorator.Common
{
    public class Person
    {
        public Person()
        {
        }

        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            System.Console.WriteLine("装扮的{0}", name);
        }
    }
}
