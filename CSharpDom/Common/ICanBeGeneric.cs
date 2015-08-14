namespace CSharpDom.Common
{
    public interface ICanBeGeneric
    {
        bool IsGeneric { get; }

        int GenericParameterCount { get; }
    }
}
