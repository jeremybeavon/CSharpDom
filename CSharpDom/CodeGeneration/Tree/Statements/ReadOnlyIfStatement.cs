using CSharpDom.BaseClasses.Statements;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyIfStatement :
        AbstractIfStatement<ReadOnlyExpressionStatement, ReadOnlyStatement>
    {
        private readonly ReadOnlyExpressionStatement condition;
        private readonly ReadOnlyStatement thenStatement;
        private readonly ReadOnlyStatement elseStatement;

        public ReadOnlyIfStatement(IfStatement ifStatement)
        {
            condition = new ReadOnlyExpressionStatement(ifStatement.Condition);
            thenStatement = new ReadOnlyStatement(ifStatement.ThenStatement);
            if (ifStatement.ElseStatement != null)
            {
                elseStatement = new ReadOnlyStatement(ifStatement.ElseStatement);
            }
        }

        public override ReadOnlyExpressionStatement Condition
        {
            get { return condition; }
        }

        public override ReadOnlyStatement ElseStatement
        {
            get { return elseStatement; }
        }

        public override ReadOnlyStatement ThenStatement
        {
            get { return thenStatement; }
        }
    }
}
