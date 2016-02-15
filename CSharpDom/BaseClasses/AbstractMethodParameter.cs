using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractMethodParameter<TAttributeGroup, TTypeReference> :
        AbstractParameter<TAttributeGroup, TTypeReference>,
        IMethodParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
        public abstract ParameterModifier Modifier { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitMethodParameter(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitMethodParameterChildren(this, visitor);
        }
    }
}
