using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractAnonymousMethodExpression<TParameter, TStatement> :
        AbstractExpression,
        IAnonymousMethodExpression<TParameter, TStatement>
        where TParameter : IAnonymousMethodParameter
        where TStatement : IStatement
    {
        public abstract IReadOnlyList<TParameter> Parameters { get; }

        public abstract IReadOnlyList<TStatement> Statements { get; }

        public abstract bool IsAsync { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitAnonymousMethodExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitAnonymousMethodExpressionChildren(this, visitor);
        }
    }
}
