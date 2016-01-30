using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class Event : IEvent<AttributeGroup, IBasicType, DelegateReference>
    {
        public Event()
        {
            Attributes = new List<AttributeGroup>();
            FieldAttributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IBasicType DeclaringType
        {
            get { return null; }
        }

        public DelegateReference EventType { get; set; }

        public List<AttributeGroup> FieldAttributes { get; set; }

        public MemberInheritanceModifier InheritanceModifier { get; set; }

        public string Name { get; set; }

        public MemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyCollection<AttributeGroup> IHasFieldAttributes<AttributeGroup>.FieldAttributes
        {
            get { return FieldAttributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEvent(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEventChildren(this, visitor);
        }
    }
}
