using UnityEngine;

namespace Yuumi._1_状态模式.基础原型
{
    /// <summary>
    /// 具体状态类 B
    /// </summary>
    public class ConcreteStateB : AbstractState
    {
        /// <summary>
        /// 继承抽象类中的构造函数
        /// </summary>
        /// <param name="stateController"></param>
        public ConcreteStateB(Context stateController) : base(stateController) { }

        /// <summary>
        /// 实现方法
        /// </summary>
        public override void Handle()
        {
            Debug.Log("ConcreteStateB 执行 Handle");
        }
    }
}