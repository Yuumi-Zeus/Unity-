namespace YuumiDesignPattern._1.状态模式
{
    /// <summary>
    /// 状态接口
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// 状态控制者（拥有者），表示此状态属于谁，属性
        /// </summary>
        public Context StateController { get; set; }

        /// <summary>
        /// 每个状态都要实现的方法
        /// </summary>
        void Handle();
    }

    /// <summary>
    /// 状态抽象类，其实可以把状态接口的东西全写到抽象类，如此做加深接口印象，接口表示方法和属性
    /// </summary>
    public abstract class AbstractState : IState
    {
        /// <summary>
        /// 继承接口的属性
        /// </summary>
        public Context StateController { get; set; }

        /// <summary>
        /// 在构造函数中赋值状态拥有者
        /// </summary>
        /// <param name="stateController"></param>
        protected AbstractState(Context stateController) => StateController = stateController;

        /// <summary>
        /// 抽象方法
        /// </summary>
        public abstract void Handle();
    }
}