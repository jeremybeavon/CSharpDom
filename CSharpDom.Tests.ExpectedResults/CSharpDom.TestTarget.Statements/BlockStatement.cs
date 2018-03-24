namespace CSharpDom.TestTarget.Statements
{
    public sealed class BlockStatement
    {
        public void TestBlock()
        {
            {
            }
        }

        public void TestNestedBlock()
        {
            {
                {
                }
            }
        }
    }
}
