using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractLockStatement<TExpression, TStatement> :
        AbstractStatement,
        ILockStatement<TExpression, TStatement>
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract TExpression Expression { get; }

        public abstract TStatement Statement { get; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitLockStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitLockStatementChildren(this, visitor);
        }
    }
}
