namespace Observer.Common
{
    public abstract class Observer
    {
        protected string name;
        protected INotifier sub;

        public Observer(string name, INotifier sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public abstract void Update();
    }
}
