namespace CSharpDom.TestTarget.Statements
{
    public sealed class BreakStatement
    {
        public void TestBreak()
        {
            while (this.Condition())
            {
                break;
            }
        }
    }
}
