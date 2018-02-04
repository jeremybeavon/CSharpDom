namespace CSharpDom.Common.Editable
{
    public interface IEditableDelegateReference<TTypeReference> :
        IEditableDelegateReference,
        IEditableTypeReference,
        IHasEditableName,
        IHasEditableGenericParameters<TTypeReference>,
        IDelegateReference<TTypeReference>
        where TTypeReference : IEditableTypeReference
    {
    }
}