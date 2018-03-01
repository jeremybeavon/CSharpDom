using CSharpDom.Common.Expressions;

namespace CSharpDom.Common
{
    public interface IClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        IClassLambdaProperty,
        ILambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>,
        IHasClassMemberInheritanceModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
    }
}
