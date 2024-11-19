using System;
using UnityEngine;

namespace YuumiDesignPattern._2.外观模式.BasicPrototype
{
    /// <summary>
    /// Facade 外观模式，用这个类来集合其他子系统，并在这个类中定义特殊方法，进行复用，同时避免了 Client 客户端（用户） 直接访问到子系统，
    /// 它只需要知道要达成什么目的，而不需要思考不同子系统之间的使用顺序和方法
    /// </summary>
    public class Facade : MonoBehaviour
    {
        SystemA _systemA;
        SystemB _systemB;

        void Start()
        {
            _systemA = new SystemA();
            _systemB = new SystemB();
        }

        /// <summary>
        /// 任务组 1 ，A 和 B 系统连续完成任务
        /// </summary>
        public void DoSomething()
        {
            Init();
            _systemA.Do();
            _systemB.Do();
        }

        /// <summary>
        /// 任务组 2 ，A 和 B 系统连续完成任务的中途输出一次
        /// </summary>
        public void DoSomething2()
        {
            Init();
            _systemA.Do();
            Debug.Log("DoSomething2");
            _systemB.Do();
        }

        void Init()
        {
            _systemA = new SystemA();
            _systemB = new SystemB();
        }
    }
}