using UnityEngine;
using UnityEngine.SceneManagement;

namespace YuumiDesignPattern._1.状态模式
{
    /// <summary>
    /// 战斗界面状态
    /// </summary>
    public class SceneStateGame : AbstractSceneState
    {
        public SceneStateGame(SceneController sceneController) : base(sceneController) { }

        public override void Enter()
        {
            Debug.Log("已经进入 " + nameof(SceneStateGame) + " 状态");
            Debug.Log("此时可以加载场景资源！");
        }

        public override void Update()
        {
            Debug.Log("此时可以更新游戏状态！");
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                SceneController.SetState(new SceneStateMainMenu(SceneController));
                SceneManager.LoadScene("MainMenuScene");
            }
        }

        public override void Exit()
        {
            Debug.Log("已经退出 " + nameof(SceneStateGame) + " 状态");
        }
    }
}