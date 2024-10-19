using UnityEngine;

namespace YuumiDesignPattern._1.状态模式
{
    /// <summary>
    /// 状态拥有者
    /// </summary>
    public class Context
    {
        /// <summary>
        /// 当前状态，字段，
        /// 使用接口类型作为字段类型存储，依赖接口，而不依赖具体实现类
        /// </summary>
        IState _currentState;

        /// <summary>
        /// 设置状态的方法，或者改变状态的方法
        /// </summary>
        /// <param name="theState"></param>
        public void SetState(IState theState)
        {
            Debug.Log("SetState: " + theState);
            _currentState = theState;
        }

        /// <summary>
        /// 特定行为，调用不同状态的相同行为
        /// </summary>
        public void Request()
        {
            Debug.Log("触发 Request 方法");
            _currentState.Handle();
        }
    }
}