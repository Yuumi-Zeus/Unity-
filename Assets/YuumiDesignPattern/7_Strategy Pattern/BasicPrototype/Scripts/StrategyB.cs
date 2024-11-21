using UnityEngine;

namespace YuumiDesignPattern._7_Strategy_Pattern.BasicPrototype.Scripts
{
    public class StrategyB : Strategy
    {
        public override void Algorithm()
        {
            Debug.Log("StrategyB 执行！");
        }
    }
}