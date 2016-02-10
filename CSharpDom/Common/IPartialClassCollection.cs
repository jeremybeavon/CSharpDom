namespace CSharpDom.Common
{
    public interface IPartialClassCollection : IVisitable<IGenericVisitor>
    {
        int Count { get; }
    }
}
