using System;
using CSharpDom.BaseClasses.Statements;
using CSharpDom.CodeGeneration.Tree.Types;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public abstract class ReadOnlyWhileStatement : AbstractDoStatement<ReadOnlyExpressionStatement, ReadOnlyStatement>
    {
        private readonly ReadOnlyExpressionStatement condition;
        private readonly ReadOnlyStatement statement;

        public ReadOnlyWhileStatement(DoStatement doStatement)
        {
            condition = new ReadOnlyExpressionStatement(doStatement.Condition);
            statement = new ReadOnlyStatement(doStatement.Statement);
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
