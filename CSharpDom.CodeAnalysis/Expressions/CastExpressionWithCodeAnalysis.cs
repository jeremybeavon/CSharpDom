using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class CastExpressionWithCodeAnalysis<TTypeReference, TExpression> :
        ICastExpression<TTypeReference, TExpression>
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public abstract TTypeReference Type { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitCastExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitCastExpressionChildren(this, visitor);
        }
    }
}
