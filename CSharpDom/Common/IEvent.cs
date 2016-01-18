namespace CSharpDom.Common
{
    public interface IEvent<TDeclaringType> : IHasName, IHasDeclaringType<TDeclaringType>
    {
    }
}
