using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class UnnamedAttributeValue : IUnnamedAttributeValue
    {
        public string RawValue { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUnnamedAttributeValue(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
