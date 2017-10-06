using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableArrayIndexExpression<TExpression> :
        AbstractExpression,
        IArrayIndexExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Array { get; set; }

        public abstract IList<TExpression> Indexes { get; set; }

        IReadOnlyList<TExpression> IArrayIndexExpression<TExpression>.Indexes
        {
            get { return new ReadOnlyCollection<TExpression>(Indexes); }
        }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitArrayIndexExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitArrayIndexExpressionChildren(this, visitor);
        }
    }
}
