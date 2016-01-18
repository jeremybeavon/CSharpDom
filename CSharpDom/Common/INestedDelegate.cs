namespace CSharpDom.Common
{
    public interface INestedDelegate<TDeclaringType> :
        IHasName,
        ICanBeGeneric,
        IHasDeclaringType<TDeclaringType>
    {
    }
}
