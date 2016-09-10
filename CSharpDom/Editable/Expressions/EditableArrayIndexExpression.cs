using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableArrayIndexExpression<TExpression> : IArrayIndexExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Array { get; set; }

        public abstract IList<TExpression> Indexes { get; set; }

        IReadOnlyList<TExpression> IArrayIndexExpression<TExpression>.Indexes
        {
            get { return new ReadOnlyCollection<TExpression>(Indexes); }
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
