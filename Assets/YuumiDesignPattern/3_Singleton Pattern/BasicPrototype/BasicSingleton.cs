namespace YuumiDesignPattern._3.单例模式.BasicPrototype
{
    /// <summary>
    /// 抽象单例类，此时约束 T 必须可以直接 new (), 是最简便的抽象类，但是会违反《私有构造函数》要求
    /// 不过日常使用中，人为控制即可。
    /// </summary>
    public abstract class BasicSingleton<T> where T : new()
    {
        /// <summary>
        /// 1. 静态私有变量，用于存储实例
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
                    _instance = new T();
                }

                return _instance;
            }
        }

        /// <summary>
        /// protect 构造函数
        /// </summary>
        protected BasicSingleton() { }
    }

    public class BasicSingleton : BasicSingleton<BasicSingleton>
    {
        /// <summary>
        /// 共有构造函数，违反《私有构造函数》要求
        /// </summary>
        public BasicSingleton() { }
    }
}