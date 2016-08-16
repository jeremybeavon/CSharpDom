using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TDelegateReference : IDelegateReference
    {
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual TDelegateReference EventType { get; set; }
        
        public virtual string Name { get; set; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEvent(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEventChildren(this, visitor);
        }
    }
}
