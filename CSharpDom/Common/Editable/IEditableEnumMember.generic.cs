namespace CSharpDom.Common.Editable
{
    public interface IEditableEnumMember<TAttributeGroup, TDeclaringType> :
        IEditableEnumMember,
        IHasEditableName,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IEnumMember<TAttributeGroup, TDeclaringType>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableEnum
    {
    }
}