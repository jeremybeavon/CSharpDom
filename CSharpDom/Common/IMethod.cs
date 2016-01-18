namespace CSharpDom.Common
{
    public interface IMethod<TDeclaringType> : IHasName, ICanBeGeneric, IHasDeclaringType<TDeclaringType>
    {
    }
}
