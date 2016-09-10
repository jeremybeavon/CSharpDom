using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableTernaryOperatorExpression<TExpression> : ITernaryOperatorExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Left { get; set; }

        public abstract TExpression Middle { get; set; }

        public abstract TExpression Right { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitTernaryOperatorExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitTernaryOperatorExpressionChildren(this, visitor);
        }
    }
}
