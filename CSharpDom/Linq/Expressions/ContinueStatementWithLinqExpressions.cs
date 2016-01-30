using CSharpDom.BaseClasses.Statements;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class ContinueStatementWithLinqExpressions : AbstractContinueStatement, ILinqStatement<GotoExpression>
    {
        public ContinueStatementWithLinqExpressions(GotoExpression statement)
        {
            Statement = statement;
        }

        public GotoExpression Statement { get; private set; }

        Expression ILinqStatement.Statement
        {
            get { return Statement; }
        }
    }
}
