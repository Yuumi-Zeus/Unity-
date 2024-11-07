using UnityEngine;

namespace YuumiDesignPattern._3.单例模式.BasicPrototype
{
    /// <summary>
    /// 适用于 Unity 的，最简单的 MonoBehaviour 的单例模式，
    /// 此方法必须在场景启动前就拥有这个物体，并挂在这个脚本组件
    /// EasyMonoSingletonConcrete 类名更换成你需要的类名
    /// </summary>
    public class EasyMonoSingletonConcrete : MonoBehaviour
    {
        /// <summary>
        /// 公有的静态属性，用于获取单例
        /// </summary>
        public static EasyMonoSingletonConcrete Instance { get; private set; }

        /// <summary>
        /// Awake 中进行单例赋值
        /// </summary>
        void Awake()
        {
            Instance = this;
        }
    }
}