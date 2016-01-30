using CSharpDom.BaseClasses.Statements;
using System.Linq.Expressions;
using System;

namespace CSharpDom.Linq.Expressions
{
    public sealed class ReturnStatementWithLinqExpressions :
        AbstractReturnStatement<ILinqExpression>,
        ILinqStatement<GotoExpression>
    {
        private readonly ILinqExpression expression;

        public ReturnStatementWithLinqExpressions(GotoExpression statement)
        {
            Statement = statement;
            expression = LinqExpressionBuilder.BuildExpression(statement.Value);
        }

        public override ILinqExpression Expression
        {
            get { return expression; }
        }

        public GotoExpression Statement { get; private set; }

        Expression ILinqStatement.Statement
        {
            get { return Statement; }
        }
    }
}
