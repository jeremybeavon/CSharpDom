using CSharpDom.Common.Expressions;

namespace CSharpDom.Common
{
    public interface ILambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        IProperty,
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasPropertyType<TTypeReference>,
        IHasLambdaExpression<TExpression>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
    }
}
