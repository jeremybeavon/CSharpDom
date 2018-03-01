using CSharpDom.Common.Expressions;

namespace CSharpDom.Common
{
    public interface IStaticClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        IStaticClassLambdaProperty,
        ILambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
    }
}
