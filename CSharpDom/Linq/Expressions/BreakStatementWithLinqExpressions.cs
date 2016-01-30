using CSharpDom.BaseClasses.Statements;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class BreakStatementWithLinqExpressions : AbstractBreakStatement, ILinqStatement<GotoExpression>
    {
        public BreakStatementWithLinqExpressions(GotoExpression statement)
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
