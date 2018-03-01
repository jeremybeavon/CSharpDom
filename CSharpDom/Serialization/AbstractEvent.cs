using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class AbstractEvent : IAbstractEvent<AttributeGroup, IAbstractType, DelegateReference>
    {
        public AbstractEvent()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IAbstractType DeclaringType
        {
            get { return null; }
        }

        public DelegateReference EventType { get; set; }

        public string Name { get; set; }

        public AbstractMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }
        
        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractEvent(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEventChildren(this, visitor);
        }
    }
}
