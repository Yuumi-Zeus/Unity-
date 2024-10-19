namespace YuumiDesignPattern._1.状态模式
{
    /// <summary>
    /// 状态拥有者
    /// </summary>
    public class SceneController
    {
        /// <summary>
        /// 当前状态
        /// </summary>
         ISceneState _currentState;

        /// <summary>
        /// 切换状态
        /// </summary>
        /// <param name="state"></param>
        public void SetState(ISceneState state)
        {
            _currentState?.Exit();
            _currentState = state;
            _currentState.Enter();
        }

        /// <summary>
        /// 状态共有方法，每个状态都有的行为，只是会有不同的结果
        /// </summary>
        public void Update()
        {
            _currentState.Update();
        }
    }
}