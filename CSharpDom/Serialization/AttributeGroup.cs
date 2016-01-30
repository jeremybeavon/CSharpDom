using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class AttributeGroup : IAttributeGroup<Attribute>
    {
        public AttributeGroup()
        {
            Attributes = new List<Attribute>();
        }

        public List<Attribute> Attributes { get; set; }

        IReadOnlyCollection<Attribute> IHasAttributes<Attribute>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAttributeGroup(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAttributeGroupChildren(this, visitor);
        }
    }
}
