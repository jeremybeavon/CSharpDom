namespace CSharpDom.TestTarget.Statements
{
    public sealed class IfStatement
    {
        public void TestIf()
        {
            if (this.Condition())
            {
                if (this.Condition())
                {
                }
                else if (this.Condition())
                {
                }
                else
                {
                }
            }
            else if (this.Condition())
            {
                if (this.Condition())
                {
                }
                else if (this.Condition())
                {
                }
                else
                {
                }
            }
            else
            {
                if (this.Condition())
                {
                }
                else if (this.Condition())
                {
                }
                else
                {
                }
            }
        }

        public void TestIfWithBlockStatement()
        {
            if (this.Condition())
                this.MethodCall();
            else if (this.Condition())
                this.MethodCall();
            else
                this.MethodCall();
        }
    }
}
