namespace CSharpDom.Common
{
    public interface IProtectedOverrideMember : IVisitable<IGenericVisitor>
    {
        bool IsInternal { get; }

        bool IsSealed { get; }
    }
}
