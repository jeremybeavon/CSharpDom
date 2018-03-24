namespace CSharpDom.TestTarget.Statements
{
    public sealed class DoStatement
    {
        public void TestDo()
        {
            do
            {
            } while (this.Condition());
        }

        public void TestNestedDo()
        {
            do
            {
                do
                {
                } while (this.Condition());
            } while (this.Condition());
        }

        public void TestDoWithoutBlock()
        {
            do
                this.MethodCall();
            while (this.Condition());
        }
    }
}
