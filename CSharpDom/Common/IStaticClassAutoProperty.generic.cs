using CSharpDom.Common.Expressions;

namespace CSharpDom.Common
{
    public interface IStaticClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> :
        IStaticClassAutoProperty,
        IAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TAccessor : IStaticClassAccessor
        where TExpression : IExpression
    {
    }
}
