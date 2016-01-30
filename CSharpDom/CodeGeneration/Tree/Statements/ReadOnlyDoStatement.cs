using CSharpDom.BaseClasses.Statements;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public abstract class ReadOnlyDoStatement : AbstractDoStatement<ReadOnlyExpressionStatement, ReadOnlyStatement>
    {
        private readonly ReadOnlyExpressionStatement condition;
        private readonly ReadOnlyStatement statement;

        public ReadOnlyDoStatement(DoStatement doStatement)
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
