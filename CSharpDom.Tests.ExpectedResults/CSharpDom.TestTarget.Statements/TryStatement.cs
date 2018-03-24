namespace CSharpDom.TestTarget.Statements
{
    public sealed class TryStatement
    {
        public void TestTryCatch()
        {
            try
            {
            }
            catch
            {
            }
        }

        public void TestTryFinally()
        {
            try
            {
            }
            finally
            {
            }
        }

        public void TestTryCatchFinally()
        {
            try
            {
            }
            catch
            {
            }
            finally
            {
            }
        }

        public void TestNestedTryCatchFinally()
        {
            try
            {
                try
                {
                }
                catch
                {
                }
                finally
                {
                }
            }
            catch
            {
                try
                {
                }
                catch
                {
                }
                finally
                {
                }
            }
            finally
            {
                try
                {
                }
                catch
                {
                }
                finally
                {
                }
            }
        }

        public void TestTryCatches()
        {
            try
            {
            }
            catch (StatementException)
            {
            }
            catch (StatementException2 exception)
            {
                this.MethodCall(exception);
            }
            catch (StatementException3 exception) when (exception is StatementException3)
            {
            }
            catch
            {
            }
        }
    }
}
