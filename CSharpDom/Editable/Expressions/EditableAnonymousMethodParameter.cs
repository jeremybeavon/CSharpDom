using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableAnonymousMethodParameter<TTypeReference> :
        AbstractExpression,
        IAnonymousMethodParameter<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract string Name { get; set; }

        public abstract AnonymousMethodParameterModifier Modifier { get; set; }

        public abstract TTypeReference ParameterType { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitAnonymousMethodParameter(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
