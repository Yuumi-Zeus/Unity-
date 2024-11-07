using UnityEngine;

namespace YuumiDesignPattern._3.单例模式.BasicPrototype
{
    public class SingletonLaunch : MonoBehaviour
    {
        // C# Concrete Singleton
        public BasicSingleton BasicSingleton;

        public AdvancedSingletonConcrete AdvancedSingletonConcrete;

        // Unity Mono Singleton
        public EasyMonoSingletonConcrete easyMonoSingletonConcrete;
        public MonoSingletonConcrete monoSingletonConcrete;

        void Start()
        {
            // 通常在 Start 中赋值非自身的字段
            // C#
            // 直接使用静态属性即可获取
            BasicSingleton = BasicSingleton.Instance;
            // Basic 是可以 new 的，但是不推荐，因为会破坏单例，新创建的对象不等于 BasicSingletonConcrete.Instance
            // BasicSingletonConcrete = new  BasicSingletonConcrete();
            AdvancedSingletonConcrete = AdvancedSingletonConcrete.Instance;
            // Unity Mono
            // 直接使用静态属性即可获取
            // 但是 EasyMonoSingletonConcrete 必须场景中原本就存在挂载了这个脚本的物体
            easyMonoSingletonConcrete = EasyMonoSingletonConcrete.Instance;
            monoSingletonConcrete = MonoSingletonConcrete.Instance;
        }
    }
}