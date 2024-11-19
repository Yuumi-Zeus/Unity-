using UnityEngine;
using UnityEngine.SceneManagement;

namespace YuumiDesignPattern._1.状态模式
{
    /// <summary>
    /// 主菜单状态
    /// </summary>
    public class SceneStateMainMenu : AbstractSceneState
    {
        public SceneStateMainMenu(SceneController sceneController) : base(sceneController) { }

        public override void Enter()
        {
            Debug.Log("已经进入 " + nameof(SceneStateMainMenu) + " 状态");
            Debug.Log("此时可以加载场景资源！");
        }

        public override void Update()
        {
            Debug.Log("此时可以更新主菜单状态");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // 状态参数的变换
                SceneController.SetState(new SceneStateGame(SceneController));
                // 实际场景的变换
                SceneManager.LoadScene("GameScene");
            }
        }

        public override void Exit()
        {
            Debug.Log("此时退出，可以卸载部分资源！");
        }
    }
}