using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class InterfaceProperty : IInterfaceProperty<AttributeGroup, IInterfaceType, TypeReference, InterfaceAccessor>
    {
        public InterfaceProperty()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IInterfaceType DeclaringType
        {
            get { return null; }
        }

        public InterfaceAccessor GetAccessor { get; set; }
        
        public InterfaceMemberInheritanceModifier InheritanceModifier { get; set; }

        public string Name { get; set; }

        public TypeReference PropertyType { get; set; }

        public InterfaceAccessor SetAccessor { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPropertyChildren(this, visitor);
        }
    }
}
