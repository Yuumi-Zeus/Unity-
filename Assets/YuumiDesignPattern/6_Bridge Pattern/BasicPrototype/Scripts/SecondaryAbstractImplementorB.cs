using UnityEngine;

namespace YuumiDesignPattern._6_Bridge_Pattern.BasicPrototype.Scripts
{
    public class SecondaryAbstractImplementorB : SecondaryAbstract
    {
        public override void DoSomething()
        {
             Debug.Log($"SecondaryAbstractImplementorB 执行了，但不知道谁要它执行");
        }
    }
}