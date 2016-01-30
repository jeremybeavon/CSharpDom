using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Statements;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;

namespace CSharpDom.Linq.Expressions
{
    public sealed class ForStatementWithLinqExpressions :
        AbstractForStatement<ILinqExpression, IForInitializerStatement, ILinqStatement>,
        ILinqStatement<LoopExpression>
    {
        private readonly ILinqStatement statement;

        public ForStatementWithLinqExpressions(LoopExpression statement)
        {
            LinqStatement = statement;
            this.statement = LinqStatementBuilder.BuildStatement(statement.Body);
        }

        public LoopExpression LinqStatement { get; private set; }

        public override ILinqExpression Condition
        {
            get { return null; }
        }

        public override IReadOnlyCollection<ILinqExpression> IncrementExpressions
        {
            get { return new ILinqExpression[0]; }
        }

        public override IForInitializerStatement InitialValueStatement
        {
            get { return null; }
        }

        public override ILinqStatement Statement
        {
            get { return statement; }
        }

        Expression ILinqStatement.Statement
        {
            get { return LinqStatement; }
        }

        LoopExpression ILinqStatement<LoopExpression>.Statement
        {
            get { return LinqStatement; }
        }
    }
}
