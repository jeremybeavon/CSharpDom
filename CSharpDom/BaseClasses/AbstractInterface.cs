using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractInterface<TNamespace,
        TProject,
        TSolution,
        TAttributeGroup,
        TGenericParameter,
        TInterfaceReference,
        TEvent,
        TProperty,
        TIndexer,
        TMethod> :
        AbstractBasicType<TEvent, TProperty, TIndexer, TMethod>,
        IInterface<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>
        where TNamespace : INamespace
        where TProject : IProject
        where TSolution : ISolution
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
        where TEvent : IInterfaceEvent
        where TProperty : IInterfaceProperty
        where TIndexer : IInterfaceIndexer
        where TMethod : IInterfaceMethod
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract IReadOnlyList<TGenericParameter> GenericParameters { get; }

        public abstract IReadOnlyCollection<TInterfaceReference> Interfaces { get; }

        public abstract bool IsPartial { get; }

        public abstract string Name { get; }

        public abstract TNamespace Namespace { get; }

        public abstract TProject Project { get; }

        public abstract TSolution Solution { get; }

        public abstract TypeVisibilityModifier Visibility { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterface(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfaceChildren(this, visitor);
        }
    }
}
