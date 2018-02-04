namespace CSharpDom.Common.Editable
{
    public interface IHasEditableDestructor<TDestructor> : IHasDestructor<TDestructor>
    {
        new TDestructor Destructor { get; set; }
    }
}