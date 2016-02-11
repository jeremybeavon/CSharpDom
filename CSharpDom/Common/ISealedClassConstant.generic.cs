namespace CSharpDom.Common
{
    public interface ISealedClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        ISealedClassConstant,
        IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
        where TConstant : IConstant
    {
    }
}
