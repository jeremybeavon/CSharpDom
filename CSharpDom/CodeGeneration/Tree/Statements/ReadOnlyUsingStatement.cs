using System;
using CSharpDom.BaseClasses.Statements;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyUsingStatement :
        AbstractUsingStatement<ReadOnlyExpressionStatement, ReadOnlyStatement>
    {
        private readonly ReadOnlyExpressionStatement expression;
        private readonly ReadOnlyStatement statement;

        public ReadOnlyUsingStatement(LockStatement lockStatement)
        {
            expression = new ReadOnlyExpressionStatement(lockStatement.Expression);
            statement = new ReadOnlyStatement(lockStatement.Statement);
        }

        public override ReadOnlyExpressionStatement Expression
        {
            get { return expression; }
        }

        public override ReadOnlyStatement Statement
        {
            get { return statement; }
        }
    }
}
