using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ProtectedOverrideEvent :
        IProtectedOverrideEvent<AttributeGroup, ISealedType, DelegateReference>
    {
        public ProtectedOverrideEvent()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public ISealedType DeclaringType
        {
            get { return null; }
        }

        public DelegateReference EventType { get; set; }
        
        public string Name { get; set; }

        public MethodBody AddBody { get; set; }

        public MethodBody RemoveBody { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public bool IsInternal { get; set; }

        public bool IsSealed { get; set; }
        
        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitProtectedOverrideEvent(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitProtectedOverrideEventChildren(this, visitor);
        }
    }
}
