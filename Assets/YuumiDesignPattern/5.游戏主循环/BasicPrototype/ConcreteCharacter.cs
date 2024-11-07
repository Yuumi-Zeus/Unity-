using UnityEngine;

namespace YuumiDesignPattern._5.游戏主循环.BasicPrototype
{
    public class ConcreteCharacter : MonoBehaviour
    {
        void Awake()
        {
            GameLoop.Instance.OnStart += Init;
            GameLoop.Instance.OnUpdate += CharacterUpdate;
        }

        /// <summary>
        /// 游戏对象初始化
        /// </summary>
        public void Init()
        {
            Debug.Log("游戏对象进行初始化");
        }

        /// <summary>
        /// 指游戏对象更新的流程
        /// </summary>
        public void CharacterUpdate()
        {
            // 订阅事件无法控制执行顺序，那么可以在订阅事件之前封装方法，控制执行顺序
            UserInput();
            UpdateGameLogic();
        }

        /// <summary>
        /// 指用户输入
        /// </summary>
        void UserInput()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("按下了 A 键");
            }
        }

        /// <summary>
        /// 指游戏逻辑更新部分
        /// </summary>
        void UpdateGameLogic()
        {
            Debug.Log("游戏对象逻辑更新");
        }
    }
}