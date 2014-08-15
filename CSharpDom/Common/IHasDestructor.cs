namespace CSharpDom.Common
{
    public interface IHasDestructor<TDestructor>
    {
        TDestructor Destructor { get; }
    }
}
