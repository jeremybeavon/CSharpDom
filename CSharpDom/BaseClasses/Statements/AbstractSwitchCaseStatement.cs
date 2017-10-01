using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractSwitchCaseStatement<TExpression, TStatement> :
        AbstractStatement,
        ISwitchCaseStatement<TExpression, TStatement>
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract IReadOnlyCollection<TExpression> Matches { get; }

        public abstract IReadOnlyList<TStatement> Statements { get; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitSwitchCaseStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitSwitchCaseStatementChildren(this, visitor);
        }
    }
}
