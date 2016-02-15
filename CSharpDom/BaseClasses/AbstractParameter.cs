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
        
        public abstract string Name { get; }

        public abstract TTypeReference ParameterType { get; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitParameter(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitParameterChildren(this, visitor);
        }
    }
}
