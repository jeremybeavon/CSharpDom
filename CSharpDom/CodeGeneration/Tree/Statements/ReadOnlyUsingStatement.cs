using System;
using CSharpDom.BaseClasses.Statements;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyUsingStatement :
        AbstractUsingStatement<ReadOnlyExpressionStatement, ReadOnlyStatement>
    {
        private readonly ReadOnlyExpressionStatement expression;
        private readonly ReadOnlyStatement statement;

        public ReadOnlyUsingStatement(UsingStatement usingStatement)
        {
            expression = new ReadOnlyExpressionStatement(usingStatement.Expression);
            statement = new ReadOnlyStatement(usingStatement.Statement);
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
