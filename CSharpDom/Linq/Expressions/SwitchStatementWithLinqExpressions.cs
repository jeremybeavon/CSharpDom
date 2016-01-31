using CSharpDom.BaseClasses.Statements;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;

namespace CSharpDom.Linq.Expressions
{
    public sealed class SwitchStatementWithLinqExpressions :
        AbstractSwitchStatement<ILinqExpression, SwitchCaseStatementWithLinqExpressions, DefaultCaseStatementWithLinqExpressions>,
        ILinqStatement<SwitchExpression>
    {
        private readonly ILinqExpression expression;
        private readonly IReadOnlyCollection<SwitchCaseStatementWithLinqExpressions> cases;
        private readonly DefaultCaseStatementWithLinqExpressions defaultCase;

        public SwitchStatementWithLinqExpressions(SwitchExpression statement)
        {
            Statement = statement;
            expression = LinqExpressionBuilder.BuildExpression(statement.SwitchValue);
            cases = statement.Cases.ToArray(@case => new SwitchCaseStatementWithLinqExpressions(@case));
            if (statement.DefaultBody != null)
            {
                defaultCase = new DefaultCaseStatementWithLinqExpressions(statement);
            }
        }

        public override IReadOnlyCollection<SwitchCaseStatementWithLinqExpressions> Cases
        {
            get { return cases; }
        }

        public override DefaultCaseStatementWithLinqExpressions DefaultCase
        {
            get { return defaultCase; }
        }

        public override ILinqExpression Expression
        {
            get { return expression; }
        }

        public SwitchExpression Statement { get; private set; }

        Expression ILinqStatement.Statement
        {
            get { return Statement; }
        }
    }
}
