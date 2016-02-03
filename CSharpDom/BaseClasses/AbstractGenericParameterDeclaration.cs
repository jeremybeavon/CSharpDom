using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> :
        IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>
        where TClassReference : IClassReference
        where TGenericParameterReference : IGenericParameterReference
        where TInterfaceReference : IInterfaceReference
        where TAttributeGroup : IAttributeGroup
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TClassReference BaseClassConstraint { get; }

        public abstract GenericParameterDeclarationDirection Direction { get; }

        public abstract IReadOnlyCollection<TGenericParameterReference> GenericParameterConstraints { get; }

        public abstract bool HasEmptyConstructorConstraint { get; }

        public abstract IReadOnlyCollection<TInterfaceReference> InterfaceConstraints { get; }

        public abstract string Name { get; }

        public abstract GenericParameterTypeConstraint TypeConstraint { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameterDeclaration(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitGenericParameterDeclaration(this, visitor);
        }
    }
}
