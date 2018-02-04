namespace CSharpDom.Common.Editable
{
    public interface IEditableBuiltInTypeReference : IEditableTypeReference, IBuiltInTypeReference
    {
        new BuiltInType Type { get; set; }
    }
}