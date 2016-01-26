using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractSwitchCaseStatement<TExpression, TStatement> :
        ISwitchCaseStatement<TExpression, TStatement>
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract TExpression Match { get; }

        public abstract IReadOnlyList<TStatement> Statements { get; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitSwitchCaseStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitSwitchCaseStatementChildren(this, visitor);
        }
    }
}
