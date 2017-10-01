using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractParameter<TAttributeGroup, TTypeReference> :
        AbstractGenericVisitableObject,
        IParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }
        
        public abstract string Name { get; }

        public abstract TTypeReference ParameterType { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitParameter(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitParameterChildren(this, visitor);
        }
    }
}
