using Sirenix.OdinInspector;
using Sirenix.Utilities.Editor;
using UnityEngine;

namespace YuumiDesignPattern._1.状态模式
{
    public class 状态模式原型测试启动脚本 : MonoBehaviour
    {
        [LabelText("StateController 状态拥有者")] [ShowInInspector]
        public Context StateController;

        [Title("测试说明")]
        [ShowInInspector]
        [DisplayAsString(false, 15, TextAlignment.Left, true)]
        public string Info
        {
            get
            {
                GUIHelper.RequestRepaint();
                return "按A键切换状态为 A \n按B键切换状态为B \n按空格键触发 Request 方法";
            }
        }

        void Start()
        {
            StateController = new Context();
            StateController?.SetState(new ConcreteStateA(StateController));
            UnityEditor.Selection.activeGameObject = gameObject;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                StateController?.SetState(new ConcreteStateA(StateController));
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                StateController?.SetState(new ConcreteStateB(StateController));
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                StateController?.Request();
            }
        }
    }
}