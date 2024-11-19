namespace YuumiDesignPattern._6_Bridge_Pattern.Practice.Scripts
{
    public abstract class Shape
    {
        protected RenderEngine RenderEngine;

        public void SetRenderEngine(RenderEngine renderEngine) => RenderEngine = renderEngine;
        public abstract void Draw();
    }
}