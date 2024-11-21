using UnityEngine;

namespace YuumiDesignPattern._8_Template_Method_Pattern.BasicPrototype.Scripts
{
    public class ConcreteBehaviourB : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Debug.Log("ConcreteBehaviourB.PrimitiveOperation1");
        }

        protected override void PrimitiveOperation2()
        {
            Debug.Log("ConcreteBehaviourB.PrimitiveOperation2");
        }
    }
}