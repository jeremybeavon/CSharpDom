namespace CSharpDom.Common.Editable
{
    public interface IHasEditableParameterType<TTypeReference> : IHasParameterType<TTypeReference>
    {
        new TTypeReference ParameterType { get; set; }
    }
}