using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ExplicitInterfaceProperty :
        IExplicitInterfaceProperty<AttributeGroup, IType, InterfaceReference, TypeReference, Accessor>
    {
        public ExplicitInterfaceProperty()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IType DeclaringType
        {
            get { return null; }
        }

        public InterfaceReference ExplicitInterface { get; set; }

        public Accessor GetAccessor { get; set; }
        
        public string Name { get; set; }

        public TypeReference PropertyType { get; set; }

        public Accessor SetAccessor { get; set; }
        
        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitExplicitInterfaceProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPropertyChildren(this, visitor);
        }
    }
}
