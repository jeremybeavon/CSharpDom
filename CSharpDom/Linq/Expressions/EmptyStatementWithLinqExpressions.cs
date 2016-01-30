using CSharpDom.BaseClasses.Statements;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class EmptyStatementWithLinqExpressions : AbstractEmptyStatement, ILinqStatement<DefaultExpression>
    {
        public EmptyStatementWithLinqExpressions(DefaultExpression statement)
        {
            Statement = statement;
        }

        public DefaultExpression Statement { get; private set; }

        Expression ILinqStatement.Statement
        {
            get { return Statement; }
        }
    }
}
