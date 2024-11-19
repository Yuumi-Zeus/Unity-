using Sirenix.OdinInspector;
using UnityEngine;

namespace YuumiDesignPattern._4.中介者模式.BasicPrototype
{
    public class MediatorLaunch : MonoBehaviour
    {
        ConcreteMediator _concreteMediatorHub;

        ConcreteColleagueA _colleagueA;
        ConcreteColleagueB _colleagueB;

        [ShowInInspector] public string Info => "启动场景后，点击按钮。";

        void Awake()
        {
            _concreteMediatorHub = new ConcreteMediator();
            _colleagueA = new ConcreteColleagueA(_concreteMediatorHub);
            _colleagueB = new ConcreteColleagueB(_concreteMediatorHub);
            _concreteMediatorHub.SetColleagueA(_colleagueA);
            _concreteMediatorHub.SetColleagueB(_colleagueB);
        }

        [Button("A 调用 B ", ButtonSizes.Large)]
        public void SendMessage()
        {
            _colleagueA.Send("A 调用 B ");
        }

        [Button("B 调用 A ", ButtonSizes.Large)]
        public void SendMessage2()
        {
            _colleagueB.Send("B 调用 A ");
        }
    }
}