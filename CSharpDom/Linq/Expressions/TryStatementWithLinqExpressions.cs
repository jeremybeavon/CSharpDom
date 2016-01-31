using CSharpDom.BaseClasses.Statements;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Linq.Expressions
{
    public sealed class TryStatementWithLinqExpressions :
        AbstractTryStatement<ILinqStatement, CatchStatementWithLinqExpressions, FinallyStatementWithLinqExpressions>,
        ILinqStatement<TryExpression>
    {
        private readonly IReadOnlyList<ILinqStatement> tryStatements;
        private readonly IReadOnlyCollection<CatchStatementWithLinqExpressions> catchStatements;
        private readonly FinallyStatementWithLinqExpressions finallyStatement;

        public TryStatementWithLinqExpressions(TryExpression statement)
        {
            Statement = statement;
            tryStatements = LinqStatementBuilder.BuildStatements(statement.Body);
            catchStatements = statement.Handlers.ToArray(@catch => new CatchStatementWithLinqExpressions(@catch));
            if (statement.Finally != null)
            {
                finallyStatement = new FinallyStatementWithLinqExpressions(statement);
            }
        }

        public override IReadOnlyCollection<CatchStatementWithLinqExpressions> CatchStatements
        {
            get { return catchStatements; }
        }

        public override FinallyStatementWithLinqExpressions FinallyStatement
        {
            get { return finallyStatement; }
        }

        public TryExpression Statement { get; private set; }

        public override IReadOnlyList<ILinqStatement> TryStatements
        {
            get { return tryStatements; }
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
