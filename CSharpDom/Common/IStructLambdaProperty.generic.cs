using CSharpDom.Common.Expressions;

namespace CSharpDom.Common
{
    public interface IStructLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        IStructLambdaProperty,
        ILambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>,
        IHasStructMemberInheritanceModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
    }
}
