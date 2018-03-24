namespace CSharpDom.TestTarget.Statements
{
    public sealed class WhileStatement
    {
        public void TestWhile()
        {
            while (this.Condition())
            {
            }
        }

        public void TestNestedWhile()
        {
            while (this.Condition())
            {
                while (this.Condition())
                {
                }
            }
        }

        public void TestWhileWithoutBlock()
        {
            while (this.Condition())
                this.MethodCall();
        }
    }
}
