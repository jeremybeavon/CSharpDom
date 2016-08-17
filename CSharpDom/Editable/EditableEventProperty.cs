using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public class EditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> : 
        IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
        public virtual ICollection<TAttributeGroup> AddAttributes { get; set; }

        public virtual TMethodBody AddBody { get; set; }

        public virtual ICollection<TAttributeGroup> Attributes { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual TDelegateReference EventType { get; set; }
        
        public virtual string Name { get; set; }

        public virtual ICollection<TAttributeGroup> RemoveAttributes { get; set; }

        public virtual TMethodBody RemoveBody { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasEventPropertyBodyAttributes<TAttributeGroup>.AddAttributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(AddAttributes); }
        }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        IReadOnlyCollection<TAttributeGroup> IHasEventPropertyBodyAttributes<TAttributeGroup>.RemoveAttributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(RemoveAttributes); }
        }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEventProperty(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEventPropertyChildren(this, visitor);
        }
    }
}
