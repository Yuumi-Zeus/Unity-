using UnityEngine;

namespace YuumiDesignPattern._2.外观模式.BasicPrototype
{
    /// <summary>
    /// 子系统抽象类
    /// </summary>
    public abstract class SubSystem
    {
        public abstract void Do();
    }

    /// <summary>
    /// 子系统 A ，有一个任务方法可以执行
    /// </summary>
    public class SystemA : SubSystem
    {
        public override void Do()
        {
            Debug.Log("SystemA called 执行任务");
        }
    }

    /// <summary>
    /// 子系统 B ，也有一个任务方法可以执行
    /// </summary>
    public class SystemB : SubSystem
    {
        public override void Do()
        {
            Debug.Log("SystemB called 执行任务");
        }
    }
}