using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractParameter<TAttributeGroup, TTypeReference> : IParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract ParameterModifier Modifier { get; }

        public abstract string Name { get; }

        public abstract TTypeReference ParameterType { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitParameter(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitParameter(this, visitor);
        }
    }
}
