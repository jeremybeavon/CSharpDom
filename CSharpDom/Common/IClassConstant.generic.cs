namespace CSharpDom.Common
{
    public interface IClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        IClassConstant,
        IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
        where TConstant : IConstant
    {
    }
}
