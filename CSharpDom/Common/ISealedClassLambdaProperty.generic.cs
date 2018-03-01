using CSharpDom.Common.Expressions;

namespace CSharpDom.Common
{
    public interface ISealedClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        ISealedClassLambdaProperty,
        IHasSealedClassMemberInheritanceModifier,
        ILambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
    }
}
