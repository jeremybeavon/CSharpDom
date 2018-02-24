using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractArgument<TExpression> : AbstractExpression, IArgument<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; }

        public abstract string Name { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitArgument(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitArgumentChildren(this, visitor);
        }
    }
}
