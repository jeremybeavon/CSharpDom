namespace CSharpDom.TestTarget.Statements
{
    public sealed class UsingStatement
    {
        public void TestUsing()
        {
            using (this.DisposableObject())
            {
            }
        }

        public void TestNestedUsing()
        {
            using (this.DisposableObject())
            {
                using (this.DisposableObject())
                {
                }
            }
        }

        public void TestUsingWithoutBlockStatement()
        {
            using (this.DisposableObject())
                this.MethodCall();
        }
    }
}
