using System;
using CSharpDom.BaseClasses.Statements;
using CSharpDom.CodeGeneration.Tree.Types;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyWhileStatement : AbstractWhileStatement<ReadOnlyExpressionStatement, ReadOnlyStatement>
    {
        private readonly ReadOnlyExpressionStatement condition;
        private readonly ReadOnlyStatement statement;

        public ReadOnlyWhileStatement(WhileStatement whileStatement)
        {
            condition = new ReadOnlyExpressionStatement(whileStatement.Condition);
            statement = new ReadOnlyStatement(whileStatement.Statement);
        }

        public override ReadOnlyExpressionStatement Condition
        {
            get { return condition; }
        }

        public override ReadOnlyStatement Statement
        {
            get { return statement; }
        }
    }
}
