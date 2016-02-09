using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class ArrayIndexExpression : IArrayIndexExpression<Expression>
    {
        public ArrayIndexExpression()
        {
            Indexes = new List<Expression>();
        }

        public Expression Array { get; set; }

        public List<Expression> Indexes { get; set; }

        IReadOnlyList<Expression> IArrayIndexExpression<Expression>.Indexes
        {
            get { return Indexes; }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitArrayIndexExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitArrayIndexExpressionChildren(this, visitor);
        }
    }
}
