namespace CSharpDom.Common.Editable
{
    public interface IEditableClassReference<TTypeReference> :
        IEditableClassReference,
        IEditableTypeReference,
        IHasEditableName,
        IHasEditableGenericParameters<TTypeReference>,
        IClassReference<TTypeReference>
        where TTypeReference : IEditableTypeReference
    {
    }
}