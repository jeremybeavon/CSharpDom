using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableCastExpression<TTypeReference, TExpression> :
        AbstractExpression,
        ICastExpression<TTypeReference, TExpression>
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public abstract TTypeReference Type { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitCastExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitCastExpressionChildren(this, visitor);
        }
    }
}
