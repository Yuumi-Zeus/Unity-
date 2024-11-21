# 模板方法模式

## 基础概念

- 在一个操作方法中定义算法的流程，其中某些步骤由子类完成。模板方法模式让子类在不变更原有算法流程的情况下，还能够重新定义其中的步骤
- 模板方法模式看起来和策略模式很类似，但是策略模式针对的是某一个计算过程的算法，而模板方法模式，对应的是一个固定的流程，可能会接触不同类型的部分
- 同时有点类似于外观模式封装的子系统方法，但是他们对应的范围是不一样的，外观模式所处理的层级是整个项目级别的，模板方法通常是不同的小操作。但在某些时候，也是可以替换的
- 如果在程序设计过程中，你需要更新一段代码，发现还有一段代码也需要进行相同的修改，那么此时可以考虑模板方法模式

## 原型实现

- Abstract Class
- Concrete Behaviour

---

*<u>**AbstractClass**</u>*

```csharp
namespace YuumiDesignPattern._8_Template_Method_Pattern.BasicPrototype.Scripts
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
        }

        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();
    }
}
```

*<u>**ConcreteBehaviour A**</u>*

```csharp
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
```

*<u>**TemplateMethodLaunch**</u>*

```csharp
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
```

