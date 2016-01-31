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
            statement => CreateStatement(statement as DoStatement, @do => new ReadOnlyDoStatement(@do)),
            statement => CreateStatement(statement as EmptyStatement, empty => new ReadOnlyEmptyStatement()),
            statement => CreateStatement(statement as ExpressionStatement, expression => new ReadOnlyExpressionStatement(expression)),
            statement => CreateStatement(statement as ForeachStatement, @foreach => new ReadOnlyForeachStatement(@foreach)),
            statement => CreateStatement(statement as ForStatement, @for => new ReadOnlyForStatement(@for)),
            statement => CreateStatement(statement as GotoStatement, @goto => new ReadOnlyGotoStatement(@goto)),
            statement => CreateStatement(statement as IfStatement, @if => new ReadOnlyIfStatement(@if)),
            statement => CreateStatement(statement as LabelStatement, label => new ReadOnlyLabelStatement(label)),
            statement => CreateStatement(statement as LockStatement, @lock => new ReadOnlyLockStatement(@lock)),
            statement => CreateStatement(statement as ReturnStatement, @return => new ReadOnlyReturnStatement(@return)),
            statement => CreateStatement(statement as TryStatement, @try => new ReadOnlyTryStatement(@try)),
            statement => CreateStatement(statement as UsingStatement, @using => new ReadOnlyUsingStatement(@using)),
            statement => CreateStatement(statement as VariableDeclarationStatement, variable => new ReadOnlyVariableDeclarationStatement(variable)),
            statement => CreateStatement(statement as WhileStatement, @while => new ReadOnlyWhileStatement(@while))
        };

        private readonly IStatement readOnlyStatement;

        public ReadOnlyStatement(Statement statement)
        {
            readOnlyStatement = statementBuilders.Select(builder => builder(statement)).First(output => output != null);
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
