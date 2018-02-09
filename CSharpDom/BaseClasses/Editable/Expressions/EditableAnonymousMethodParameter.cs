using CSharpDom.Common;
using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableAnonymousMethodParameter<TTypeReference> :
        EditableExpression,
        IEditableAnonymousMethodParameter<TTypeReference>
        where TTypeReference : IEditableTypeReference
    {
        public abstract string Name { get; set; }

        public abstract AnonymousMethodParameterModifier Modifier { get; set; }

        public abstract TTypeReference ParameterType { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitAnonymousMethodParameter(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitAnonymousMethodParameter(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
        }
    }
}
