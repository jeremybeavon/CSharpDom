using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractAnonymousMethodParameter<TTypeReference> :
        AbstractExpression,
        IAnonymousMethodParameter<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract string Name { get; }

        public abstract AnonymousMethodParameterModifier Modifier { get; }

        public abstract TTypeReference ParameterType { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitAnonymousMethodParameter(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
