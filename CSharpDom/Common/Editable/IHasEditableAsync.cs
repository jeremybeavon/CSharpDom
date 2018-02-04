namespace CSharpDom.Common.Editable
{
    public interface IHasEditableAsync : IHasAsync
    {
        new bool IsAsync { get; set; }
    }
}