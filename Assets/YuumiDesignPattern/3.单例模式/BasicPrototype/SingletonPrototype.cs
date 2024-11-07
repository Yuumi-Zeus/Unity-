/// <summary>
/// 单例模式原型，是 C# 的，不继承 Mono
/// </summary>
public class SingletonPrototype
{
    /// <summary>
    /// 私有静态变量
    /// </summary>
    static SingletonPrototype _instance;

    /// <summary>
    /// 私有构造函数
    /// </summary>
    SingletonPrototype() { }

    /// <summary>
    /// 共有静态属性
    /// </summary>
    public static SingletonPrototype Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SingletonPrototype();
            }

            return _instance;
        }
    }
}