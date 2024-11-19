using UnityEngine;

namespace YuumiDesignPattern._4.中介者模式.BasicPrototype
{
    public class ConcreteColleagueA : Colleague
    {
        public ConcreteColleagueA(Mediator mediator) : base(mediator) { }

        public void Send(string message)
        {
            Mediator.Notify(this, message);
        }

        public override void Request(string message)
        {
            Debug.Log("ConcreteA 收到消息：" + message);
            Debug.Log("ConcreteA 执行！");
        }
    }
}