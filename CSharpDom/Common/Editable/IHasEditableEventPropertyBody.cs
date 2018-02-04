namespace CSharpDom.Common.Editable
{
    public interface IHasEditableEventPropertyBody<TBody> : IHasEventPropertyBody<TBody>
    {
        new TBody AddBody { get; set; }

        new TBody RemoveBody { get; set; }
    }
}