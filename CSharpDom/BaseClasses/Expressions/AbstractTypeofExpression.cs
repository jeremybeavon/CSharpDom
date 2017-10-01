using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractTypeofExpression<TTypeReference> :
        AbstractExpression,
        ITypeofExpression<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract TTypeReference Type { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitTypeofExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
