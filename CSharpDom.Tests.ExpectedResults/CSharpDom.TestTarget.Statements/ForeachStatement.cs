namespace CSharpDom.TestTarget.Statements
{
    public sealed class ForeachStatement
    {
        public void TestForeach()
        {
            foreach (object obj in this.Enumerable())
            {
            }
        }

        public void TestNestedForeach()
        {
            foreach (object obj in this.Enumerable())
            {
                foreach (object obj2 in this.Enumerable())
                {
                }
            }
        }

        public void TestForeachWithoutBlockStatement()
        {
            foreach (object obj in this.Enumerable())
                this.MethodCall();
        }
    }
}
