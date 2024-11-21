using UnityEngine;

namespace YuumiDesignPattern._8_Template_Method_Pattern.BasicPrototype.Scripts
{
    public class ConcreteBehaviourA : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Debug.Log("ConcreteBehaviourA.PrimitiveOperation1");
        }

        protected override void PrimitiveOperation2()
        {
            Debug.Log("ConcreteBehaviourA.PrimitiveOperation2");
        }
    }
}