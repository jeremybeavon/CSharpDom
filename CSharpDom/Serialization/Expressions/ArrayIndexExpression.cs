using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class ArrayIndexExpression : IArrayIndexExpression<Expression, Argument>
    {
        public ArrayIndexExpression()
        {
            Indexes = new List<Argument>();
        }

        public Expression Array { get; set; }

        public List<Argument> Indexes { get; set; }

        IReadOnlyList<Argument> IArrayIndexExpression<Expression, Argument>.Indexes
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
