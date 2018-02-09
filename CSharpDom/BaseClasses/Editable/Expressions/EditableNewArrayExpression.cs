using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableNewArrayExpression<TTypeReference, TExpression> :
        EditableExpression,
        IEditableNewArrayExpression<TTypeReference, TExpression>
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
    {
        public abstract IList<int> Dimensions { get; set; }

        public abstract TTypeReference ElementType { get; set; }

        public abstract IList<TExpression> InitialSizeExpressions { get; set; }

        IReadOnlyList<int> INewArrayExpression<TTypeReference, TExpression>.Dimensions
        {
            get { return new ReadOnlyCollection<int>(Dimensions); }
        }

        IReadOnlyList<TExpression> INewArrayExpression<TTypeReference, TExpression>.InitialSizeExpressions
        {
            get { return new ReadOnlyCollection<TExpression>(InitialSizeExpressions); }
        }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewArrayExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitNewArrayExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitNewArrayExpressionChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
