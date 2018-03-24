namespace CSharpDom.TestTarget.Statements
{
    public sealed class ForStatement
    {
        public void TestFor()
        {
            for (int index = 0; index < 10; index++)
            {
            }
        }

        public void TestNestedFor()
        {
            for (int index = 0; index < 10; index++)
            {
                for (int index2 = 0; index2 < 10; index2++)
                {
                }
            }
        }

        public void TestForWithoutBlockStatement()
        {
            for (int index = 0; index < 10; index++)
                this.MethodCall();
        }
    }
}
