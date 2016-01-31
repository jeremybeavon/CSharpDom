using CSharpDom.BaseClasses.Statements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Linq.Expressions
{
    public sealed class DefaultCaseStatementWithLinqExpressions :
        AbstractDefaultCaseStatement<ILinqStatement>,
        ILinqStatement<SwitchExpression>
    {
        private readonly IReadOnlyList<ILinqStatement> statements;

        public DefaultCaseStatementWithLinqExpressions(SwitchExpression statement)
        {
            Statement = statement;
            statements = LinqStatementBuilder.BuildStatements(statement.DefaultBody);
        }

        public SwitchExpression Statement { get; private set; }

        public override IReadOnlyList<ILinqStatement> Statements
        {
            get { return statements; }
        }

        Expression ILinqStatement.Statement
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
