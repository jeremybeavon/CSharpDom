namespace CSharpDom.TestTarget.Statements
{
    public sealed class SwitchStatement
    {
        public void TestSwitch()
        {
            switch (this.Integer())
            {
                case 0:
                    break;
                case 1:
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
