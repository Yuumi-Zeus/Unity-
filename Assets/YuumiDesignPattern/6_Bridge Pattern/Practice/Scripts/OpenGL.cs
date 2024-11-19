using UnityEngine;

namespace YuumiDesignPattern._6_Bridge_Pattern.Practice.Scripts
{
    public class OpenGL : RenderEngine
    {
        public override void Render(string shapeName)
        {
            Debug.Log("使用 OpenGL 渲染 " + shapeName);
        }
    }
}