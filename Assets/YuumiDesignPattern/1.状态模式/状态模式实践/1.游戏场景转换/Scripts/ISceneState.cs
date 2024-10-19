namespace YuumiDesignPattern._1.状态模式
{
    /// <summary>
    /// 接口
    /// </summary>
    public interface ISceneState
    {
        public SceneController SceneController { get; set; }
        void Enter();
        void Update();
        void Exit();
    }

    /// <summary>
    /// 状态抽象接口
    /// </summary>
    public abstract class AbstractSceneState : ISceneState
    {
        public SceneController SceneController { get; set; }
        public abstract void Enter();
        public abstract void Update();
        public abstract void Exit();

        public AbstractSceneState(SceneController sceneController) => SceneController = sceneController;
    }
    
    
}