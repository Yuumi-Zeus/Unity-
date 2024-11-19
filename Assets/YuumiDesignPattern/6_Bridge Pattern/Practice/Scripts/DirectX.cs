using UnityEngine;

namespace YuumiDesignPattern._6_Bridge_Pattern.Practice.Scripts
{
    public class DirectX : RenderEngine
    {
        public override void Render(string shapeName)
        {
            Debug.Log("使用 DirectX 渲染 " + shapeName);
        }
    }
}