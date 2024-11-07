using System;
using System.Reflection;

namespace YuumiDesignPattern._3.单例模式.BasicPrototype
{
    /// <summary>
    /// 进阶的单例抽象类，为了达到私有构造函数的要求，也就是不能在外界 new ，进一步防止人为操作失误
    /// 此时要用到反射，关键词：反射
    /// </summary>
    public abstract class AdvancedSingleton<T> where T : class
    {
        /// <summary>
        /// 1.静态私有字段，用于存储单例实例
        /// </summary>
        static T _instance;

        /// <summary>
        /// 2.静态公有属性
        /// </summary>
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    // 此时需要使用反射技术，从外界强制获取私有构造函数
                    var type = typeof(T);
                    /*
                     在 C# 中，`GetConstructor` 方法用于获取指定类型的构造函数。下面是对 `GetConstructor` 方法中各个参数的中文解释：

                    - **`BindingFlags.NonPublic | BindingFlags.Instance`**:
                    - `BindingFlags.NonPublic`: 指定要查找非公共构造函数（即私有或受保护的构造函数）。
                    - `BindingFlags.Instance`: 指定要查找实例构造函数，而不是静态构造函数。

                    - **`null`**:
                    - 这个参数通常用于指定一个 `Binder` 对象，用于选择重载方法和强制转换参数类型。如果为 `null`，则使用默认绑定器。

                    - **`Type.EmptyTypes`**:
                    - 这是一个表示空参数列表的数组。这里的意思是查找没有参数的构造函数。

                    - **`null`**:
                    - 这个参数用于指定参数的修改器。如果为 `null`，则表示没有参数修饰符。

                    总结：
                    - `BindingFlags.NonPublic | BindingFlags.Instance`: 查找非公共的实例构造函数。
                    - `null`: 使用默认绑定器。
                    - `Type.EmptyTypes`: 查找没有参数的构造函数。
                    - `null`: 没有参数修饰符。
                    */
                    var constructor = type.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null,
                        Type.EmptyTypes, null);
                    // 如果没有找到私有无参构造函数，则抛出异常
                    if (constructor == null)
                        throw new InvalidOperationException(
                            $" {typeof(T)} class 没有 private 无参构造函数，请声明准确的构造函数");

                    // 调用构造函数创建实例，并将其强制转换为T类型
                    return constructor.Invoke(null) as T;
                }

                return _instance;
            }
        }

        /// <summary>
        /// protected 构造函数
        /// </summary>
        protected AdvancedSingleton() { }
    }

    public class AdvancedSingletonConcrete : AdvancedSingleton<AdvancedSingletonConcrete>
    {
        /// <summary>
        /// 私有构造函数
        /// </summary>
        AdvancedSingletonConcrete() { }
    }
}