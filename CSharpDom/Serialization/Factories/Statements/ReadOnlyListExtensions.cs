using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Statements;
using System.Collections.Generic;

namespace CSharpDom.Serialization.Factories.Statements
{
    public static class ReadOnlyListExtensions
    {
        public static List<Statement> ToStatementListUsingFactory<TStatement>(
            this IReadOnlyList<TStatement> statements)
            where TStatement : IStatement
        {
            return statements.ToList(statement => new StatementFactory(statement).Value);
        }
    }
}
