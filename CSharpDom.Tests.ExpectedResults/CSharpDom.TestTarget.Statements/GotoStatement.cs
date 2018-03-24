namespace CSharpDom.TestTarget.Statements
{
    public sealed class GotoStatement
    {
        public void TestGoto()
        {
            TestLabel:
            this.MethodCall();
            goto TestLabel;
        }
    }
}
