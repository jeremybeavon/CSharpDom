using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        AbstractGenericVisitableObject,
        IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
        public abstract IReadOnlyCollection<TAttributeGroup> AddAttributes { get; }

        public abstract TMethodBody AddBody { get; }

        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract TDelegateReference EventType { get; }
        
        public abstract string Name { get; }

        public abstract IReadOnlyCollection<TAttributeGroup> RemoveAttributes { get; }

        public abstract TMethodBody RemoveBody { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEventProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEventPropertyChildren(this, visitor);
        }
    }
}
