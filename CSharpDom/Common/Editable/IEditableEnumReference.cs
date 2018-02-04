namespace CSharpDom.Common.Editable
{
    public interface IEditableEnumReference :
        IEditableTypeReference,
        IHasEditableName,
        IVisitable<IEditableVisitor>,
        IEnumReference
    {
    }
}