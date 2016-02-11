namespace CSharpDom.Common
{
    public interface IStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        IStructConstant,
        IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TTypeReference : ITypeReference
        where TConstant : IConstant
    {
    }
}
