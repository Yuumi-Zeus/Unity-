using System;
using Sirenix.OdinInspector;

namespace YuumiDesignPattern._6_Bridge_Pattern.Practice.Scripts
{
    [Serializable]
    public class UserClient
    {
        public Shape Shape;

        [Button("OpenGL 绘制 Sphere")]
        public void DrawOpenGLSphere()
        {
            Shape = new Cube();
            Shape.SetRenderEngine(new OpenGL());
            Shape.Draw();
        }

        [Button("DirectX 绘制 Sphere")]
        public void DrawDirectXSphere()
        {
            Shape = new Sphere();
            Shape.SetRenderEngine(new DirectX());
            Shape.Draw();
        }

        [Button("DirectX 绘制 Cube")]
        public void DrawDirectXCube()
        {
            Shape = new Cube();
            Shape.SetRenderEngine(new DirectX());
            Shape.Draw();
        }

        [Button("OpenGL 绘制 Cube")]
        public void DrawOpenGLCube()
        {
            Shape = new Cube();
            Shape.SetRenderEngine(new OpenGL());
            Shape.Draw();
        }
    }
}