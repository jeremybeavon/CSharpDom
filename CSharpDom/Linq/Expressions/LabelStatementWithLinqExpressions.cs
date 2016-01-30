using CSharpDom.BaseClasses.Statements;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Linq.Expressions
{
    public sealed class LabelStatementWithLinqExpressions :
        AbstractLabelStatement,
        ILinqStatement<LabelExpression>
    {
        public LabelStatementWithLinqExpressions(LabelExpression statement)
        {
            Statement = statement;
        }

        public override string LabelName
        {
            get { return Statement.Target.Name; }
        }

        public LabelExpression Statement { get; private set; }

        Expression ILinqStatement.Statement
        {
            get { return Statement; }
        }
    }
}
