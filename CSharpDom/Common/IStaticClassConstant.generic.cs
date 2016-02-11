namespace CSharpDom.Common
{
    public interface IStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        IStaticClassConstant,
        IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
        where TConstant : IConstant
    {
    }
}
