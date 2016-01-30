using System;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class NamedAttributeValue : INamedAttributeValue
    {
        public string Name { get; set; }

        public string RawValue { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNamedAttributeValue(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
