using UnityEngine;

namespace Yuumi._1_状态模式.基础原型
{
    /// <summary>
    /// 具体状态类 A
    /// </summary>
    public class ConcreteStateA : AbstractState
    {
        /// <summary>
        /// 继承抽象类中的构造函数
        /// </summary>
        /// <param name="stateController"></param>
        public ConcreteStateA(Context stateController) : base(stateController) { }

        /// <summary>
        /// 实现方法
        /// </summary>
        public override void Handle()
        {
            Debug.Log("ConcreteStateA 执行 Handle");
        }
    }
}