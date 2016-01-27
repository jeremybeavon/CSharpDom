namespace CSharpDom.Common
{
    public interface IHasParameter<TParameter>
    {
        TParameter Parameter { get; }
    }
}
