# 策略模式

## 基础概念

- 定义一组算法，并封装每个算法，让他们可以彼此交换使用。策略模式让这些算法在客户端使用它们时更加独立。
- 策略模式主要用于对同一个过程的不同算法，将具体算法存储到一个策略实例对象中，在运行时选择合适的策略实例对象。
- 可以一定程度上减少 `if-else` 的多次使用
- 实现过程非常简单，本质上就是一个多态的使用，和外观模式有点类似，但是外观模式主要处理一个客户端面对多个子系统，一个流程步骤可能有多个子系统参与，而策略模式是将一整套算法封装在一个对象中，根据情况选择合适的算法，只需要少量的判断，且易于扩展。

---

补充：

- 实际上策略模式的原型实现与状态模式更加类似，都是有一个外界持有策略抽象类引用（状态基类引用），然后根据实际情况进行修改
- 但是状态模式，不同的状态之间是有关联的，比如XX 状态切换到另一个状态，在状态切换的过程，也是可以有不同的逻辑的，状态通常是同级的
- 而策略模式，不同策略之间，它包含的通常仅仅为一些计算过程，而这些计算过程是相互独立的，而且也不会有切换时的逻辑。
- 两者在新增内容时，会有明显区别，状态模式必须考虑状态切换，从谁到谁，需要全局思考，而策略模式新增算法，直接创建新算法，立刻使用。

## 原型实现

- Strategy 策略抽象类
- Concrete Strategy 具体算法类
- Context 执行类

---

*<u>**Strategy**</u>*

```CS
namespace YuumiDesignPattern._7_Strategy_Pattern.BasicPrototype
{
    public abstract class Strategy 
    {
        public abstract void Algorithm();
    }
}

```

*<u>**StrategyA**</u>*

```csharp
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
```

*<u>**StrategyB**</u>*

```csharp
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
```

*<u>**Context**</u>*

```csharp
using System;

namespace YuumiDesignPattern._7_Strategy_Pattern.BasicPrototype.Scripts
{
    [Serializable]
    public class Context
    {
        Strategy _strategy;

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
```

***<u>StrategyLaunch</u>***

```csharp
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
```

