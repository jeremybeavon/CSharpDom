namespace CSharpDom.Common
{
    public interface IInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference> :
        IInterfaceProperty,
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
    {
        bool HasGet { get; }

        bool HasSet { get; }
    }
}
