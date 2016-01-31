using CSharpDom.BaseClasses.Statements;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Linq.Expressions
{
    public sealed class FinallyStatementWithLinqExpressions :
        AbstractFinallyStatement<ILinqStatement>
    {
        private readonly IReadOnlyList<ILinqStatement> statements;

        public FinallyStatementWithLinqExpressions(TryExpression statement)
        {
            statements = LinqStatementBuilder.BuildStatements(statement.Finally);
        }

        public override IReadOnlyList<ILinqStatement> Statements
        {
            get { return statements; }
        }
    }
}
