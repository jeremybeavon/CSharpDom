using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class Attribute : IAttribute<ClassReference, UnnamedAttributeValue, NamedAttributeValue>
    {
        public Attribute()
        {
            NamedValues = new List<NamedAttributeValue>();
            UnnamedValues = new List<UnnamedAttributeValue>();
        }

        public ClassReference AttributeType { get; set; }

        public List<NamedAttributeValue> NamedValues { get; set; }

        public List<UnnamedAttributeValue> UnnamedValues { get; set; }

        IReadOnlyCollection<NamedAttributeValue> IAttribute<ClassReference, UnnamedAttributeValue, NamedAttributeValue>.NamedValues
        {
            get { return NamedValues; }
        }

        IReadOnlyList<UnnamedAttributeValue> IAttribute<ClassReference, UnnamedAttributeValue, NamedAttributeValue>.UnnamedValues
        {
            get { return UnnamedValues; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAttribute(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAttributeChildren(this, visitor);
        }
    }
}
