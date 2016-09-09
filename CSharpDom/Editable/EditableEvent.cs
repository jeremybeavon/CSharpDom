using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TDelegateReference : IDelegateReference
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract TDeclaringType DeclaringType { get; set; }

        public abstract TDelegateReference EventType { get; set; }
        
        public abstract string Name { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

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
