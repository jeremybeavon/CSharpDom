using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableNewExpression<TTypeReference, TArgument> :
        EditableExpression,
        IEditableNewExpression<TTypeReference, TArgument>
        where TTypeReference : IEditableTypeReference
        where TArgument : IEditableArgument
    {
        public abstract IList<TArgument> Parameters { get; set; }

        public abstract TTypeReference Type { get; set; }

        IReadOnlyList<TArgument> INewExpression<TTypeReference, TArgument>.Parameters
        {
            get { return new ReadOnlyCollection<TArgument>(Parameters); }
        }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitNewExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitNewExpressionChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
