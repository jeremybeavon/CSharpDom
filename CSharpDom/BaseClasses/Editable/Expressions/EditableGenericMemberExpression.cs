using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Common;
using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableGenericMemberExpression<TExpression, TTypeReference> :
        EditableExpression,
        IEditableGenericMemberExpression<TExpression, TTypeReference>
        where TExpression : IEditableExpression
        where TTypeReference : IEditableTypeReference
    {
        public abstract string MemberName { get; set; }

        public abstract TExpression ObjectExpression { get; set; }

        public abstract IList<TTypeReference> GenericParameters { get; set; }

        IReadOnlyList<TTypeReference> IHasGenericParameters<TTypeReference>.GenericParameters =>
            new ReadOnlyCollection<TTypeReference>(GenericParameters);

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitGenericMemberExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitGenericMemberExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitGenericMemberExpressionChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
