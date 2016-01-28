using CSharpDom.Common.Statements;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyStatement : IStatement
    {
        private static readonly Func<Statement, IStatement>[] statementBuilders = new Func<Statement, IStatement>[]
        {
            statement => CreateStatement(statement as AssignStatement, assign => new ReadOnlyAssignStatement(assign)),
            statement => CreateStatement(statement as BlockStatement, block => new ReadOnlyBlockStatement(block)),
            statement => CreateStatement(statement as ExpressionStatement, expression => new ReadOnlyExpressionStatement(expression))
        };

        private readonly IStatement readOnlyStatement;

        public ReadOnlyStatement(Statement statement)
        {
            readOnlyStatement = statementBuilders.Select(builder => builder(statement)).FirstOrDefault(output => output != null);
        }

        public static IReadOnlyList<ReadOnlyStatement> Create(IEnumerable<Statement> statements)
        {
            return statements.ToArray(statement => new ReadOnlyStatement(statement));
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            readOnlyStatement.Accept(visitor);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            readOnlyStatement.AcceptChildren(visitor);
        }

        private static IStatement CreateStatement<TStatement>(TStatement statement, Func<TStatement, IStatement> builder)
            where TStatement : Statement
        {
            return statement == null ? null : builder(statement);
        }
    }
}
