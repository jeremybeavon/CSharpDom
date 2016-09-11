using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class OutExpressionWithCodeAnalysis<TExpression> : IOutExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitOutExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitOutExpressionChildren(this, visitor);
        }
    }
}
