namespace YuumiDesignPattern._6_Bridge_Pattern.BasicPrototype.Scripts
{
    public abstract class MainAbstract
    {
        protected SecondaryAbstract SecondaryTool;
        public abstract void Operation();

        public void SetSecondary(SecondaryAbstract secondary)
        {
            SecondaryTool = secondary;
        }
    }
}