namespace CSharpDom.Common
{
    public interface IHasEventPropertyBody<TBody>
    {
        TBody AddBody { get; }

        TBody RemoveBody { get; }
    }
}
