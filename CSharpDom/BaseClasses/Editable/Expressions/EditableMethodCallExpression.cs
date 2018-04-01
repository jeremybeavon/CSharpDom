using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableMethodCallExpression<TExpression, TTypeReference, TArgument> :
        EditableExpression,
        IEditableMethodCallExpression<TExpression, TTypeReference, TArgument>
        where TExpression : IEditableExpression
        where TTypeReference : IEditableTypeReference
        where TArgument : IEditableArgument
    {
        public abstract TExpression Expression { get; set; }

        public abstract IList<TArgument> Parameters { get; set; }

        public abstract IList<TTypeReference> GenericParameters { get; set; }

        IReadOnlyList<TArgument> IMethodCallExpression<TExpression, TTypeReference, TArgument>.Parameters
        {
            get { return new ReadOnlyCollection<TArgument>(Parameters); }
        }

        IReadOnlyList<TTypeReference> IMethodCallExpression<TExpression, TTypeReference, TArgument>.GenericParameters =>
            new ReadOnlyCollection<TTypeReference>(GenericParameters);

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitMethodCallExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitMethodCallExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitMethodCallExpressionChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
