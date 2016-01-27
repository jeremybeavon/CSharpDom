namespace CSharpDom.Common
{
    public interface INamedAttributeValue : IHasName, IVisitable<IGenericVisitor>
    {
        string RawValue { get; }
    }
}
