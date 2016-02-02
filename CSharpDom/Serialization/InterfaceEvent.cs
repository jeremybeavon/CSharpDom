using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class InterfaceEvent : IInterfaceEvent<AttributeGroup, IType, DelegateReference>
    {
        public InterfaceEvent()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IType DeclaringType
        {
            get { return null; }
        }

        public DelegateReference EventType { get; set; }

        public InterfaceMemberInheritanceModifier InheritanceModifier { get; set; }

        public string Name { get; set; }
        
        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }
        
        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceEvent(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEventChildren(this, visitor);
        }
    }
}
