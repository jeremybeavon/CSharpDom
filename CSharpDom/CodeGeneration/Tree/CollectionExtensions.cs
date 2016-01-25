using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public static class CollectionExtensions
    {
        public static void AcceptIfNotNull<TStatement>(this Collection<TStatement> statements, StatementVisitor visitor)
            where TStatement : Statement
        {
            if (statements != null)
            {
                foreach (TStatement statement in statements)
                {
                    statement.Accept(visitor);
                }
            }
        }
    }
}
