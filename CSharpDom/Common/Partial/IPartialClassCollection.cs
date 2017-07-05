namespace CSharpDom.Common.Partial
{
    public interface IPartialClassCollection : IVisitable<IGenericVisitor>
    {
        int Count { get; }
    }
}
