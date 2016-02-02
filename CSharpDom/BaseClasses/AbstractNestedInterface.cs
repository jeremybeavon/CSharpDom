using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> :
        AbstractBasicType<TEvent, TProperty, TIndexer, TMethod>,
        INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
        where TEvent : IInterfaceEvent
        where TProperty : IInterfaceProperty
        where TIndexer : IInterfaceIndexer
        where TMethod : IInterfaceMethod
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract IReadOnlyList<TGenericParameter> GenericParameters { get; }

        public abstract IReadOnlyCollection<TInterfaceReference> Interfaces { get; }

        public abstract string Name { get; }
        
        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedInterfaceChildren(this, visitor);
        }
    }
}
