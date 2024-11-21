using System;
using Sirenix.OdinInspector;

namespace YuumiDesignPattern._7_Strategy_Pattern.BasicPrototype.Scripts
{
    [Serializable]
    public class Context
    {
        [ShowInInspector] Strategy _strategy;

        public void SetStrategy(Strategy strategy)
        {
            _strategy = strategy;
        }

        public void DoAlgorithm()
        {
            _strategy.Algorithm();
        }
    }
}