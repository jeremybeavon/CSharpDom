namespace CSharpDom.Common
{
    public interface IUnnamedAttributeValue : IVisitable<IGenericVisitor>
    {
        string RawValue { get; }
    }
}
