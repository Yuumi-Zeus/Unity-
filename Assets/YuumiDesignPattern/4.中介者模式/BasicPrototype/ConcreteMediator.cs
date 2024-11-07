namespace YuumiDesignPattern._4.中介者模式.BasicPrototype
{
    public class ConcreteMediator : Mediator
    {
        ConcreteColleagueA _colleagueA;
        ConcreteColleagueB _colleagueB;

        public void SetColleagueA(ConcreteColleagueA colleagueA)
        {
            _colleagueA = colleagueA;
        }

        public void SetColleagueB(ConcreteColleagueB colleagueB)
        {
            _colleagueB = colleagueB;
        }

        public override void Notify(Colleague colleague, string message)
        {
            if (colleague is ConcreteColleagueA)
            {
                _colleagueB.Request(message);
            }
            else if (colleague is ConcreteColleagueB)
            {
                _colleagueA.Request(message);
            }
        }
    }
}