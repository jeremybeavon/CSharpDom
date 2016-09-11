using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class RefExpressionWithCodeAnalysis<TExpression> : IRefExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitRefExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitRefExpressionChildren(this, visitor);
        }
    }
}
