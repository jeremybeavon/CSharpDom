namespace CSharpDom.Common.Editable
{
    public interface IHasEditableAccessors<TAccessor> : IHasAccessors<TAccessor>
    {
        new TAccessor GetAccessor { get; set; }

        new TAccessor SetAccessor { get; set; }
    }
}