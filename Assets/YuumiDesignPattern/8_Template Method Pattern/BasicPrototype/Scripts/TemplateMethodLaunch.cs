using Sirenix.OdinInspector;
using UnityEngine;

namespace YuumiDesignPattern._8_Template_Method_Pattern.BasicPrototype.Scripts
{
    public class TemplateMethodLaunch : MonoBehaviour
    {
        [ShowInInspector] public AbstractClass AbstractClass;

        [Button("执行模板行为 A")]
        public void DoConcreteA()
        {
            AbstractClass = new ConcreteBehaviourA();
            AbstractClass.TemplateMethod();
        }

        [Button("执行模板行为 B")]
        public void DoConcreteB()
        {
            AbstractClass = new ConcreteBehaviourB();
            AbstractClass.TemplateMethod();
        }
    }
}