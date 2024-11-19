using UnityEngine;

namespace YuumiDesignPattern._3.单例模式.BasicPrototype
{
    /// <summary>
    /// 适用于 Unity 的 MonoBehaviour 的单例抽象类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    {
        /// <summary>
        /// 1. 静态私有字段
        /// </summary>
        static T _instance;

        /// <summary>
        /// 2. 静态公有属性
        /// </summary>
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = Object.FindObjectOfType<T>();
                    // MonoBehaviour 是使用组件形式，不能直接 new ，所以需要创建一个 GameObject，并添加组件
                    if (_instance == null)
                    {
                        var obj = new GameObject
                        {
                            name = typeof(T).Name
                        };
                        _instance = obj.AddComponent<T>();
                    }
                }

                return _instance;
            }
        }
        // 3. 私有构造函数，此要求由 Unity 引擎完成，不允许外部直接实例化继承 MonoBehaviour 的类
    }
}