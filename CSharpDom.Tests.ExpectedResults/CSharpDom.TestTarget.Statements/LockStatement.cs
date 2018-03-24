namespace CSharpDom.TestTarget.Statements
{
    public sealed class LockStatement
    {
        public void TestLock()
        {
            lock (this.LockObject())
            {
            }
        }

        public void TestNestedLock()
        {
            lock (this.LockObject())
            {
                lock (this.LockObject())
                {
                }
            }
        }

        public void TestLockWithBlockStatement()
        {
            lock (this.LockObject())
                this.MethodCall();
        }
    }
}
