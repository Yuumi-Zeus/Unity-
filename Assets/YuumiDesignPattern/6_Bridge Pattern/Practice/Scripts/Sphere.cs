namespace YuumiDesignPattern._6_Bridge_Pattern.Practice.Scripts
{
    public class Sphere : Shape
    {
        public override void Draw()
        {
            RenderEngine.Render("Sphere");
        }
    }
}