using CSharpDom.BaseClasses.Statements;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class SwitchCaseStatementWithLinqExpressions :
        AbstractSwitchCaseStatement<ILinqExpression, ILinqStatement>
    {
        private readonly IReadOnlyCollection<ILinqExpression> matches;
        private readonly IReadOnlyList<ILinqStatement> statements;

        public SwitchCaseStatementWithLinqExpressions(SwitchCase statement)
        {
            Statement = statement;
            matches = LinqExpressionBuilder.BuildExpressions(statement.TestValues);
            statements = LinqStatementBuilder.BuildStatements(statement.Body);
        }

        public override IReadOnlyCollection<ILinqExpression> Matches
        {
            get { return matches; }
        }

        public SwitchCase Statement { get; private set; }

        public override IReadOnlyList<ILinqStatement> Statements
        {
            get { return statements; }
        }
    }
}
