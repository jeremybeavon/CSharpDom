namespace CSharpDom.TestTarget.Statements
{
    public sealed class ContinueStatement
    {
        public void TestContinue()
        {
            while (this.Condition())
            {
                continue;
            }
        }
    }
}
