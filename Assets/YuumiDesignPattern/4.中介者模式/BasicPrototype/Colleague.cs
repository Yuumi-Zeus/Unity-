namespace YuumiDesignPattern._4.中介者模式.BasicPrototype
{
    public abstract class Colleague
    {
        protected readonly Mediator Mediator;

        protected Colleague(Mediator mediator) => Mediator = mediator;

        public abstract void Request(string message);
    }
}