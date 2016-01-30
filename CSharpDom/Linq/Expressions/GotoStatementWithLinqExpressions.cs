using CSharpDom.BaseClasses.Statements;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class GotoStatementWithLinqExpressions : AbstractGotoStatement, ILinqStatement<GotoExpression>
    {
        public GotoStatementWithLinqExpressions(GotoExpression statement)
        {
            Statement = statement;
        }

        public override string LabelName
        {
            get { return Statement.Target.Name; }
        }

        public GotoExpression Statement { get; private set; }

        Expression ILinqStatement.Statement
        {
            get { return Statement; }
        }
    }
}
