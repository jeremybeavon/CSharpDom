namespace CSharpDom.CodeGeneration.Tree
{
    public static class StatementExtensions
    {
        public static void AcceptIfNotNull(this Statement statement, StatementVisitor visitor)
        {
            if (statement != null)
            {
                statement.Accept(visitor);
            }
        }
    }
}
