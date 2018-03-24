namespace CSharpDom.TestTarget.Statements
{
    public sealed class ReturnStatement
    {
        public void TestVoidReturn()
        {
            return;
        }

        public object TestReturn()
        {
            return null;
        }
    }
}
