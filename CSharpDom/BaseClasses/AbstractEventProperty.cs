using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> : 
        IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
        public abstract TMethodBody AddBody { get; }

        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract TDelegateReference EventType { get; }
        
        public abstract string Name { get; }

        public abstract TMethodBody RemoveBody { get; }
        
        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEventPropertyChildren(this, visitor);
        }
    }
}
