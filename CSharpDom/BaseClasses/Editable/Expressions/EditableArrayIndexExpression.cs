using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableArrayIndexExpression<TExpression, TArgument> :
        EditableExpression,
        IEditableArrayIndexExpression<TExpression, TArgument>
        where TExpression : IEditableExpression
        where TArgument : IEditableArgument
    {
        public abstract TExpression Array { get; set; }

        public abstract IList<TArgument> Indexes { get; set; }

        IReadOnlyList<TArgument> IArrayIndexExpression<TExpression, TArgument>.Indexes
        {
            get { return new ReadOnlyCollection<TArgument>(Indexes); }
        }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitArrayIndexExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitArrayIndexExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitArrayIndexExpressionChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
