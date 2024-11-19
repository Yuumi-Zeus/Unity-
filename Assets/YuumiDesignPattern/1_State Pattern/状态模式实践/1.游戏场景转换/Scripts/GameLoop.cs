using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace YuumiDesignPattern._1.状态模式
{
    /// <summary>
    /// 游戏流程脚本，用于测试，不销毁
    /// </summary>
    public class GameLoop : MonoBehaviour
    {
        [ShowInInspector] public SceneController SceneController;

        void Awake()
        {
            SceneController = new SceneController();
            SceneController.SetState(new SceneStateMainMenu(SceneController));
            UnityEditor.Selection.activeGameObject = gameObject;
            DontDestroyOnLoad(gameObject);
        }

        void Update()
        {
            SceneController.Update();
        }
    }
}