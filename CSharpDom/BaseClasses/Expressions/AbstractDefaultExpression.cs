using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractDefaultExpression<TTypeReference> :
        AbstractExpression,
        IDefaultExpression<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract TTypeReference Type { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitDefaultExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
