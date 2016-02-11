namespace CSharpDom.Common
{
    public interface IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        IConstantGroup,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasFieldType<TTypeReference>,
        IHasConstants<TConstant>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TConstant : IConstant
    {
    }
}
