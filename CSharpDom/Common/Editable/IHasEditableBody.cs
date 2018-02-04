namespace CSharpDom.Common.Editable
{
    public interface IHasEditableBody<TBody> : IHasBody<TBody>
    {
        new TBody Body { get; set; }
    }
}