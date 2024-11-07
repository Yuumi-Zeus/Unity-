using System;
using YuumiDesignPattern._3.单例模式.BasicPrototype;

namespace YuumiDesignPattern._5.游戏主循环.BasicPrototype
{
    /// <summary>
    /// 通常 GameLoop 是单例，所以继承 MonoSingleton
    /// </summary>
    public class GameLoop : MonoSingleton<GameLoop>
    {
        // 定义公共事件给外界订阅
        // 也可以直接使用 Action ，更加方便 
        public event Action OnStart;
        public event Action OnUpdate;
        public event Action OnFixedUpdate;
        public event Action OnLateUpdate;
        public event Action OnQuit;

        void Awake()
        {
            // 切换场景不销毁
            DontDestroyOnLoad(gameObject);
        }

        void Start()
        {
            OnStart?.Invoke();
        }

        void Update()
        {
            // 如果觉得 Update 中还需要控制顺序，那么可以定义多个事件，并在 Update 中按对应顺序发布
            OnUpdate?.Invoke();
        }

        void FixedUpdate()
        {
            OnFixedUpdate?.Invoke();
        }

        void LateUpdate()
        {
            OnLateUpdate?.Invoke();
        }

        void OnApplicationQuit()
        {
            OnQuit?.Invoke();
        }
    }
}