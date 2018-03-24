namespace CSharpDom.TestTarget.Statements
{
    public sealed class GotoCaseStatement
    {
        public void TestGotoCase()
        {
            switch (this.Integer())
            {
                case 0:
                    break;
                case 1:
                    goto case 0;
            }
        }
    }
}
