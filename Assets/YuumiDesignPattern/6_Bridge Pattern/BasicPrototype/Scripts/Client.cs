using System;
using Sirenix.OdinInspector;

namespace YuumiDesignPattern._6_Bridge_Pattern.BasicPrototype.Scripts
{
    [Serializable]
    public class Client
    {
        public MainAbstract Main;

        [Button("使用 Main A 调用 Secondary A")]
        public void DoAA()
        {
            var main = new MainAbstractImplementorA();
            main.SetSecondary(new SecondaryAbstractImplementorA());
            main.Operation();
        }

        [Button("使用 Main A 调用 Secondary B")]
        public void DoAB()
        {
            var main = new MainAbstractImplementorA();
            main.SetSecondary(new SecondaryAbstractImplementorB());
            main.Operation();
        }

        [Button("使用 Main B 调用 Secondary A")]
        public void DoBA()
        {
            var main = new MainAbstractImplementorB();
            main.SetSecondary(new SecondaryAbstractImplementorA());
            main.Operation();
        }

        [Button("使用 Main B 调用 Secondary B")]
        public void DoBB()
        {
            var main = new MainAbstractImplementorB();
            main.SetSecondary(new SecondaryAbstractImplementorB());
            main.Operation();
        }
    }
}