namespace CSharpDom.Common
{
    public interface IBuiltInTypeReference : ITypeReference
    {
        BuiltInType Type { get; }
    }
}
