using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace YuumiDesignPattern._2.外观模式.BasicPrototype
{
    /// <summary>
    /// 客户端（用户）部分，只需要通过外观模式，Facade Hub 去实现想要的效果。而实现效果的步骤编写在 Facade 中，
    /// 那么客户端在使用时，就不必了解子系统的内部方法，以及步骤。同时可以达到快速修改的目的。
    /// </summary>
    public class Client : MonoBehaviour
    {
        public Facade facadeHub;

        [Title("测试按钮")]
        [Button("DoSomething", ButtonSizes.Large, ButtonStyle.Box, ButtonAlignment = 0.5f)]
        public void ClientDoSomething()
        {
            facadeHub.DoSomething();
            // 如果不使用 Facade 外观模式的话，需要在 Client 中获取这两个子系统，那么我们就需要去自己了解达成这个目的的过程中，
            // 两个系统是如何运作的，如果是接手其他人的工作或者是让新人来完成这部分，不需要去理解，直接使用对应的方法即可
            // 如果不使用 Facade，如下
            // systemA.Do;
            // systemB.Do;
            // 实际情况不会这么简单，可能这个效果的步骤需要很多 XXX
            // 那么就不需要每次都编写一次，节省时间，也防止复制时出错，更能够在修改的时候，只需要修改一次，而不是使用了这个步骤的每一个地方
        }

        [Button("DoSomething2", ButtonSizes.Large, ButtonStyle.Box, ButtonAlignment = 0.5f)]
        public void ClientDoSomething2()
        {
            facadeHub.DoSomething2();
        }
    }
}