using Sirenix.OdinInspector;
using UnityEngine;

namespace YuumiDesignPattern._7_Strategy_Pattern.BasicPrototype.Scripts
{
    public class StrategyLaunch : MonoBehaviour
    {
        public Context context = new Context();

        [Button("设置策略算法为 A")]
        public void SetStrategyA()
        {
            context?.SetStrategy(new StrategyA());
            Debug.Log("设置策略算法为 StrategyA");
        }

        [Button("设置策略算法为 B")]
        public void SetStrategyB()
        {
            context?.SetStrategy(new StrategyB());
            Debug.Log("设置策略算法为 StrategyB");
        }

        [Button("执行计算")]
        public void DoAlgorithm()
        {
            context?.DoAlgorithm();
        }
    }
}