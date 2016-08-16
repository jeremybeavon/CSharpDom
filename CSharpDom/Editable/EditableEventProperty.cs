using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> : 
        IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
        public virtual IReadOnlyCollection<TAttributeGroup> AddAttributes { get; set; }

        public virtual TMethodBody AddBody { get; set; }

        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual TDelegateReference EventType { get; set; }
        
        public virtual string Name { get; set; }

        public virtual IReadOnlyCollection<TAttributeGroup> RemoveAttributes { get; set; }

        public virtual TMethodBody RemoveBody { get; set; }

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
