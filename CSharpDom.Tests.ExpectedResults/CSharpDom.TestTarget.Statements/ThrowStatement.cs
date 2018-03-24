namespace CSharpDom.TestTarget.Statements
{
    public sealed class ThrowStatement
    {
        public void TestEmptyThrow()
        {
            try
            {
            }
            catch
            {
                throw;
            }
        }

        public object TestThrow()
        {
            throw this.Exception();
        }
    }
}
