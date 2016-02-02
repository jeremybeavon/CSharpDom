using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ExplicitInterfaceEvent :
        IExplicitInterfaceEvent<AttributeGroup, IType, InterfaceReference, DelegateReference, MethodBody>
    {
        public ExplicitInterfaceEvent()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IType DeclaringType
        {
            get { return null; }
        }

        public DelegateReference EventType { get; set; }

        public InterfaceReference ExplicitInterface { get; set; }

        public string Name { get; set; }

        public MethodBody AddBody { get; set; }

        public MethodBody RemoveBody { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitExplicitInterfaceEvent(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEventPropertyChildren(this, visitor);
        }
    }
}
