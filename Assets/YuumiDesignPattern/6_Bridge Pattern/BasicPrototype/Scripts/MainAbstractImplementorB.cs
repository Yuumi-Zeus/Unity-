using UnityEngine;

namespace YuumiDesignPattern._6_Bridge_Pattern.BasicPrototype.Scripts
{
    public class MainAbstractImplementorB : MainAbstract
    {
        public override void Operation()
        {
              var tool = SecondaryTool.GetType();
            Debug.Log("MainAbstractImplementorB 要开始执行了，此时工具为: " + tool.Name);
            SecondaryTool.DoSomething();
        }
    }
}