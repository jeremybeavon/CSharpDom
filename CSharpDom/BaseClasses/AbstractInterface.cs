using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractInterface<TNamespace,
        TDocument,
        TProject,
        TSolution,
        TAttributeGroup,
        TGenericParameter,
        TInterfaceReference,
        TEvent,
        TProperty,
        TIndexer,
        TMethod> :
        AbstractInterfaceType<TAttributeGroup,TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>,
        IInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>
        where TNamespace : INamespace
        where TDocument : IDocument
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
        public abstract TDocument Document { get; }
        
        public abstract TNamespace Namespace { get; }

        public abstract TProject Project { get; }

        public abstract TSolution Solution { get; }

        public abstract TypeVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterface(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfaceChildren(this, visitor);
        }
    }
}
