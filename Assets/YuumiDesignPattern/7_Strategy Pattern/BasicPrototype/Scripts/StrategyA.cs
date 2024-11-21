using UnityEngine;

namespace YuumiDesignPattern._7_Strategy_Pattern.BasicPrototype.Scripts
{
    public class StrategyA : Strategy
    {
        public override void Algorithm()
        {
            Debug.Log("StrategyA 执行！");
        }
    }
}