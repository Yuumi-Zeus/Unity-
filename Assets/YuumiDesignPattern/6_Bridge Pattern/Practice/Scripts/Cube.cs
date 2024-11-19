namespace YuumiDesignPattern._6_Bridge_Pattern.Practice.Scripts
{
    public class Cube : Shape
    {
        public override void Draw()
        {
            RenderEngine.Render("Cube");
        }
    }
}